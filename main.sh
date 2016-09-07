#!/bin/bash

#Declare Variables
total_time=0;
smallest=0;
sorted=();
temp=0;

#Array declarations
burst_time=();
arrival_time=();
sorted=();
process_priority=();
quantum=0;

#Statistical Data
total_turnaround_time_fcfs=0;
total_waiting_time_fcfs=0;
total_turnaround_time_rr=0;
total_waiting_time_rr=0;
total_turnaround_time_queue=0;
total_waiting_time_queue=0;
total_turnaround_time_strn=0;
total_waiting_time_strn=0;

#Get Input for Arrival Time, Burst Time, Priority and maintain proper number of input
echo " ";

echo -n "Enter number of processes(Range between 3-10): ";
read PROCESSES;

while [ $PROCESSES -lt 3 ] || [ $PROCESSES -gt 10 ]; do
	echo -n "Number of Processes out of range. Enter Again: ";
	read PROCESSES
done

echo " ";

for((i=0;i<PROCESSES;i++)); do

	echo -n "Enter Arrival Time for Process P"$((i+1))": ";
	read arrival;

	echo -n "Enter Burst Time for Process P"$((i+1))": ";
	read burst;

	echo -n "Enter Priority number for P"$((i+1))" (Range from 1-6): ";
	read priority;

	echo " ";

	arrival_time+=($arrival);
	burst_time+=($burst);
	process_priority+=($priority);

	let total_time+=$burst;

	sorted+=($i);
done

echo -n "Enter Time Quantum: ";
read quantum;
echo " ";

#Total Waiting Time: Part 1
let total_waiting_time_fcfs-=$total_time;
let total_waiting_time_rr-=$total_time;
let total_waiting_time_queue-=$total_time;
let total_waiting_time_strn-=$total_time;

#Calculate SMALLEST ARRIVAL TIME
for((i=0;i<PROCESSES;i++)); do
	if [ ${arrival_time[i]} -lt ${arrival_time[smallest]} ]; then
		smallest=$i;
	fi
done

early_bird=${arrival_time[smallest]};

#Calculate total run time of CPU
if [ $early_bird -ne 0 ]; then
	let total_time+=$early_bird;
fi 

#Sort the Processes and initialize array for waiting time
for((i=0;i<PROCESSES;i++)); do
	let j=$i+1;
	for((;j<PROCESSES;j++)); do
		if [ ${arrival_time[j]} -lt ${arrival_time[i]} ]; then

			temp=${arrival_time[${i}]};
			arrival_time[i]=${arrival_time[${j}]};
			arrival_time[j]=$temp;

			temp=${burst_time[${i}]};
			burst_time[i]=${burst_time[${j}]};
			burst_time[j]=$temp;

			temp=${process_priority[${i}]};
			process_priority[i]=${process_priority[${j}]};
			process_priority[j]=$temp;

			temp=${sorted[${i}]};
			sorted[i]=${sorted[${j}]};
			sorted[j]=$temp;

		fi
	done
done

echo -n "FCFS Preemptive Algorithm will begin shortly";
sleep 3;
echo -e "\n"
current_process=-1;
previous_process=0;

#FCFS: Begin
echo -e "\nTIME \t\t PROCESS(P)";
echo -e "==== \t\t ==========";

#Gantt Chart: Mr. Timothy's Version
if [ $early_bird -ne 0 ]; then
	echo -e " 0 \t\t  Idle";
fi

fcfs_burst_time=("${burst_time[@]}")

for((current_time=$early_bird;current_time<total_time;current_time++)); do
	previous_process=$current_process;

	#Check if there is Burst Time on ANY process
	for((i=0;i<PROCESSES;i++)); do
		if  [ ${fcfs_burst_time[i]} -ne 0 ] && [ ${arrival_time[i]} -le $current_time ]; then
			current_process=$i;
			break;
		fi
	done

	#Check who has the higher priority  AND has arrived/already in queue
	for((i=0;i<PROCESSES;i++)); do
		if  [ $current_process -ne $i ] &&[ ${process_priority[i]} -eq ${process_priority[current_process]} ]; then
			if [ ${arrival_time[i]} -lt ${arrival_time[current_process]} ]; then
				current_process=$i;
			fi
		elif  [ ${fcfs_burst_time[i]} -ne 0 ] && 
			[ ${process_priority[i]} -lt ${process_priority[current_process]} ] &&
		   	[ ${arrival_time[i]} -le $current_time ]; then
				current_process=$i;
		fi
	done

	#Finding the Process Number
	let current=${sorted[${current_process}]}+1;

	#Burst Time deduction by 1 millisecond
	let fcfs_burst_time[current_process]-=1;

	#Gantt Chart - Mr. Timothy's Version
	if [ $previous_process -ne $current_process ]; then
		echo -e " "$((current_time))" \t\t     P"$current;
	fi

	#Turnaround Time for process
	if [ ${fcfs_burst_time[current_process]} -eq 0 ]; then
		let turnaround_process=$current_time-${arrival_time[${current_process}]};
		let turnaround_process++;
		let total_turnaround_time_fcfs+=turnaround_process
	fi
done

echo -e " "$current_time " \t\t    End";

echo -e "\n";

#Waiting Time: Part II
let total_waiting_time_fcfs+=$total_turnaround_time_fcfs

#Calculate Average Waiting Time and Average Turnaround Time
Average_Turnaround_FCFS=$(awk "BEGIN {printf \"%.2f\",${total_turnaround_time_fcfs}/${PROCESSES}}");
Average_Waiting_FCFS=$(awk "BEGIN {printf \"%.2f\",${total_waiting_time_fcfs}/${PROCESSES}}");

#Stats about Algorithm
echo "Total Waiting Time: "$total_waiting_time_fcfs"ms";
echo "Total Turnaround Time: "$total_turnaround_time_fcfs"ms";
echo "Average Waiting Time: "$Average_Waiting_FCFS"ms";
echo "Average Turnaround Time: "$Average_Turnaround_FCFS"ms";
echo " ";

#FCFS: End

echo -n "Round Robin Algorithm will begin shortly";
sleep 3;
echo -e "\n"

#RR: Begin
echo -e "\nTIME \t\t PROCESS(P)";
echo -e "==== \t\t ==========";

#Gantt Chart: Mr. Timothy's Version
if [ $early_bird -ne 0 ]; then
	echo -e " 0 \t\t    Idle";
fi

#Add The First Process to top of the Queue: Index and Burst Time
queue_index=();
queue_burst=();

queue_burst+=(${burst_time[0]});
queue_index+=(${sorted[0]});
process_counter=1;
subtractor=0;
previous=0;

for((current_time=$early_bird;current_time<total_time;)); do

	#Find Process Number
	let current=${queue_index[0]}+1;

	#Implement Gantt Chart - Use Mr.Timothy's Version
	if [ $previous -ne $current ]; then
		echo -e " "$current_time" \t\t     P"$current;
	fi

	#Check Subtraction
	if [ ${queue_burst[0]} -lt $quantum ]; then
		subtractor=${queue_burst[0]};
	else
		subtractor=$quantum;
	fi

	#Deduct Burst Time and Update Current Time
	let queue_burst[0]-=$subtractor;
	let current_time+=$subtractor;

	#Check if any process arrived during time and Add To Queue
	for((i=process_counter;i<PROCESSES;i++)); do
		if [ ${arrival_time[i]} -le $current_time ]; then
			queue_burst+=(${burst_time[${i}]});
			queue_index+=(${sorted[${i}]});
		elif [ ${arrival_time[i]} -gt $current_time ]; then
			break;
		fi

		let process_counter+=1;
	done

	#Check If Previous Process still has burst time. If so, add to end of Queue
	#Otherwise, add Total Arrival Time and Total Turnaround Time;
	if [ ${queue_burst[0]} -ne 0 ]; then
		queue_burst+=(${queue_burst[0]});
		queue_index+=(${queue_index[0]});
	else
		let current-=1;

		let turnaround_time=$current_time-${arrival_time[${current}]};
		let total_turnaround_time_rr+=turnaround_time;

		let current+=1;
	fi

	#Delegate Previous Process
	previous=$current;

	#Delete current Process
	queue_burst=(${queue_burst[@]:$(($remover + 1))})
	queue_index=(${queue_index[@]:$(($remover + 1))})

done

let total_waiting_time_rr+=$total_turnaround_time_rr

echo -e " "$current_time " \t\t    End";

echo -e "\n";

#Calculate Average Waiting Time and Average Turnaround Time
Average_Turnaround_RR=$(awk "BEGIN {printf \"%.2f\",${total_turnaround_time_rr}/${PROCESSES}}");
Average_Waiting_RR=$(awk "BEGIN {printf \"%.2f\",${total_waiting_time_rr}/${PROCESSES}}");

#Stats about Algorithm
echo "Total Waiting Time: "$total_waiting_time_rr"ms";
echo "Total Turnaround Time: "$total_turnaround_time_rr"ms";
echo "Average Waiting Time: "$Average_Waiting_RR"ms";
echo "Average Turnaround Time: "$Average_Turnaround_RR"ms";
echo " ";

#RR: End

echo -n "Three Queue Simulation will begin shortly";
sleep 3;
echo -e "\n"
current_process=0;

#Three Queue: Start

echo -e "\nTIME \t\t PROCESS(P)";
echo -e "==== \t\t ==========";

#Gantt Chart
if [ $early_bird -ne 0 ]; then
	echo -e " 0 \t\t   Idle";
fi

#Three Queue Simulation starts here
queue_one_burst=();
queue_one_index=();

queue_two_burst=();
queue_two_index=();

queue_three_burst=();
queue_three_index=();

for((current_time=$early_bird;current_time<total_time;)); do

	for((i=current_process;i<PROCESSES;i++)); do

	#Check if Process has arrived before current time. Otherwise, end loop
		if [ ${arrival_time[i]} -gt $current_time ]; then
			break;

		#Priority 1-2; Add to queue one
		elif [ ${process_priority[i]} -le 2 ]; then
			#Add Process to queue
			queue_one_burst+=(${burst_time[${i}]});
			queue_one_index+=(${sorted[${i}]});


		#Priority 3-4; Add to queue two
		elif [ ${process_priority[i]} -le 4 ]; then
			#Add Process to queue
			queue_two_burst+=(${burst_time[${i}]});
			queue_two_index+=(${sorted[${i}]});

		#Priority 5-6; Add to queue three
		else
			queue_three_burst+=(${burst_time[${i}]});
			queue_three_index+=(${sorted[${i}]});	
		fi

		let current_process++;
	done

	#Special Condition 2: If Q2 is empty, elevate EVERYTHING from Q3 to Q2
	if [ ${#queue_two_index[@]} -eq 0 ]; then 
		queue_two_index=("${queue_three_index[@]}");
		queue_two_burst=("${queue_three_burst[@]}");

		queue_three_index=();
		queue_three_burst=();
	fi
	#grouignrui

	#Check which queue is not empty
	if   [ ${#queue_one_index} -ne 0 ]; then
		cpu_control=1;
	else
		cpu_control=2;
	fi

	#Use a Switch-Case statement. Don't forget to end the last line of a statement with ";;"
	case $cpu_control in
		1) 	#Round Robin
			#Find Process Number
			let current=${queue_one_index[0]}+1;

			#Implement Gantt Chart - Use Mr.Timothy's Version
			if [ $previous -ne $current ]; then
				echo -e " "$current_time" \t\t     P"$current;
			fi

			#Check Subtraction
			if [ ${queue_one_burst[0]} -lt $quantum ]; then
				subtractor=${queue_one_burst[0]};
			else
				subtractor=$quantum;
			fi

			#Deduct Burst Time and Update Current Time
			let queue_one_burst[0]-=$subtractor;
			let current_time+=$subtractor;

			#Check If Previous Process still has burst time. If so, add to end of Queue
			#Otherwise, add Total Arrival Time and Total Turnaround Time;
			if [ ${queue_one_burst[0]} -ne 0 ]; then
				queue_one_burst+=(${queue_one_burst[0]});
				queue_one_index+=(${queue_one_index[0]});
			else
				let current-=1;

				let turnaround_time=$current_time-${arrival_time[${current}]};
				let total_turnaround_time_queue+=turnaround_time;

				let current+=1;
			fi

			#Delegate Previous Process
			previous=$current;

			#Delete current Process
			queue_one_burst=(${queue_one_burst[@]:$(($remover + 1))})
			queue_one_index=(${queue_one_index[@]:$(($remover + 1))})
			;;
			
		2)  #First Come First Serve
			#Finding the Process Number
			let current=${queue_two_index[0]}+1;

			#Gantt Chart - Mr. Timothy's Version
			if [ $previous -ne $current ]; then
				#echo -e "\nPrevious process was P"$previous " Next Process is P"$current
				echo -e " "$current_time" \t\t     P"$current;
			fi

			#Burst Time deduction by 1 millisecond
			let queue_two_burst[0]-=1;
			let current_time++;

			if [ ${queue_two_burst[0]} -eq 0 ]; then
				let current-=1;

				let turnaround_process=$current_time-${arrival_time[${current}]};
				let total_turnaround_time_queue+=turnaround_process;

				queue_two_burst=(${queue_two_burst[@]:$(($remover + 1))});
				queue_two_index=(${queue_two_index[@]:$(($remover + 1))});

				let current+=1;
			fi

			#Delegate Previous Process
			previous=$current;
			;;
	esac
done

echo -e " "$current_time " \t\t    End";

echo -e "\n";

let total_waiting_time_queue+=$total_turnaround_time_queue;

#Calculate Average Waiting Time and Average Turnaround Time
Average_Turnaround_Queue=$(awk "BEGIN {printf \"%.2f\",${total_turnaround_time_queue}/${PROCESSES}}");
Average_Waiting_Queue=$(awk "BEGIN {printf \"%.2f\",${total_waiting_time_queue}/${PROCESSES}}");

#Stats about Algorithm
echo "Total Waiting Time: "$total_waiting_time_queue"ms";
echo "Total Turnaround Time: "$total_turnaround_time_queue"ms";
echo "Average Waiting Time: "$Average_Waiting_Queue"ms";
echo "Average Turnaround Time: "$Average_Turnaround_Queue"ms";
echo " ";

#Three Queue: End

echo -n "Shortest Time Remaining Next Algorithm will begin shortly";
sleep 3;
echo -e "\n"
current_process=-1;
previous_process=0;

#STRN: Begin
echo -e "\nTIME \t\t PROCESS(P)";
echo -e "==== \t\t ==========";

#Gantt Chart
if [ $early_bird -ne 0 ]; then
	echo -e " 0 \t\t   Idle";
fi

for((current_time=$early_bird;current_time<total_time;current_time++)); do
	previous_process=$current_process;

	#Check if there is Burst Time on ANY process
	for((i=0;i<PROCESSES;i++)); do
		if  [ ${burst_time[i]} -ne 0 ] && [ ${arrival_time[i]} -le $current_time ]; then
			current_process=$i;
		fi
	done

	#Check who has the shortest burst AND has arrived/already in queue
	for((i=0;i<PROCESSES;i++)); do
		if  [ $current_process -ne $i ] &&[ ${burst_time[i]} -eq ${burst_time[current_process]} ]; then
			if [ ${arrival_time[i]} -lt ${arrival_time[current_process]} ]; then
				current_process=$i;
			fi
		elif  [ ${burst_time[i]} -ne 0 ] && 
			[ ${burst_time[i]} -lt ${burst_time[current_process]} ] &&
		   	[ ${arrival_time[i]} -le $current_time ]; then
				current_process=$i;
		fi
	done

	#Burst Time deduction by 1 millisecond
	let burst_time[current_process]-=1;

	#Find Process Number
	let current=${sorted[${current_process}]}+1;

	#Gantt Chart
	if [ $previous_process -ne $current_process ]; then
		echo -e " "$current_time " \t\t     P"$current;
	fi

	#Turnaround Time for process
	if [ ${burst_time[current_process]} -eq 0 ]; then
		let turnaround_process=$current_time-${arrival_time[${current_process}]};
		let turnaround_process++;
		let total_turnaround_time_strn+=turnaround_process
	fi
done

echo -e " "$current_time " \t\t    End";

echo -e "\n";

#Waiting Time: Part II
let total_waiting_time_strn+=$total_turnaround_time_strn

#Calculate Average Waiting Time and Average Turnaround Time
Average_Turnaround_STRN=$(awk "BEGIN {printf \"%.2f\",${total_turnaround_time_strn}/${PROCESSES}}");
Average_Waiting_STRN=$(awk "BEGIN {printf \"%.2f\",${total_waiting_time_strn}/${PROCESSES}}");

#Stats about Algorithm
echo "Total Waiting Time: "$total_waiting_time_strn"ms";
echo "Total Turnaround Time: "$total_turnaround_time_strn"ms";
echo "Average Waiting Time: "$Average_Waiting_STRN"ms";
echo "Average Turnaround Time: "$Average_Turnaround_STRN"ms";
echo " ";
