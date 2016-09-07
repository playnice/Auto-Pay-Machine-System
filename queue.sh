#!/bin/bash
#Chong Hon Siong's Three Queue simulation

#Attribute Declarations
smallest=0;
total_time=0;

#Array declarations
burst_time=();
arrival_time=();
sorted=();
process_priority=();

#Statistics
total_turnaround_time_queue=0;
total_waiting_time_queue=0;

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

let total_waiting_time_queue-=$total_time;

echo " ";

#Get Time Quantum
echo -n "Enter Time Quantum: ";
read quantum;

echo " ";

#Calculate earliest arrival time
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

echo -e "\nTIME \t\t PROCESS(P) \t\t QUEUE NUMBER";
echo -e "==== \t\t ========== \t\t ============";

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

current=0;
previous=0;

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
			#Special Condition 2: If Q2 and Q3 is empty, elevate to Q2
			if [ ${#queue_three_index[@]} -eq 0 ] && [ ${#queue_two_index[@]} -eq 0 ]; then
				queue_two_burst+=(${burst_time[${i}]});
				queue_two_index+=(${sorted[${i}]});	
			else
				queue_three_burst+=(${burst_time[${i}]});
				queue_three_index+=(${sorted[${i}]});	
			fi
		fi

		let current_process++;
	done

	#Check which queue is not empty
	if   [ ${#queue_one_index} -ne 0 ]; then
		cpu_control=1;
	elif [ ${#queue_two_index} -ne 0 ]; then
		cpu_control=2;
	else
		cpu_control=3;
	fi

	# #Use a Switch-Case statement. Don't forget to end the last line of a statement with ";;"
	case $cpu_control in
		1) 	#Round Robin
			#Find Process Number
			let current=${queue_one_index[0]}+1;

			#Implement Gantt Chart - Use Mr.Timothy's Version
			if [ $previous -ne $current ]; then
				#echo -e "\nPrevious process was P"$previous " Next Process is P"$current
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
				let turnaround_process++;
				let total_turnaround_time_queue+=turnaround_process;

				queue_two_burst=(${queue_two_burst[@]:$(($remover + 1))});
				queue_two_index=(${queue_two_index[@]:$(($remover + 1))});

				let current+=1;
			fi

			#Delegate Previous Process
			previous=$current
			;;
			
		3)  #First Come First Serve
			#Finding the Process Number
			let current=${queue_three_index[0]}+1;

			#Gantt Chart - Mr. Timothy's Version
			if [ $previous -ne $current ]; then
				#echo -e "\nPrevious process was P"$previous " Next Process is P"$current
				echo -e " "$current_time" \t\t     P"$current;
			fi

			#Burst Time deduction by 1 millisecond
			let queue_three_burst[0]-=1;
			let current_time++;

			if [ ${queue_three_burst[0]} -eq 0 ]; then
				let current-=1;

				let turnaround_process=$current_time-${arrival_time[${current}]};
				let turnaround_process++;
				let total_turnaround_time_queue+=turnaround_process;

				queue_three_burst=(${queue_three_burst[@]:$(($remover + 1))});
				queue_three_index=(${queue_three_index[@]:$(($remover + 1))});

				let current+=1;
			fi

			#Delegate Previous Process
			previous=$current
			;;
	esac
done

echo -e " "$current_time " \t\t    End";

echo -e "\n";

let total_waiting_time_queue+=$total_turnaround_time_queue

#Calculate Average Waiting Time and Average Turnaround Time
Average_Turnaround=$(awk "BEGIN {printf \"%.2f\",${total_turnaround_time_queue}/${PROCESSES}}");
Average_Waiting=$(awk "BEGIN {printf \"%.2f\",${total_waiting_time_queue}/${PROCESSES}}");

#Stats about Algorithm
echo "Total Waiting Time: "$total_waiting_time_queue"ms";
echo "Total Turnaround Time: "$total_turnaround_time_queue"ms";
echo "Average Waiting Time: "$Average_Waiting"ms";
echo "Average Turnaround Time: "$Average_Turnaround"ms";
echo " ";