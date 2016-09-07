#!bin/bash
#Shortest Time Remaining Next (STRN) Algorithm Version 24
#Date Started: 24th July 2015
#Date Completed: 26th July 2015

#Get Input for Arrival Time & Burst Time
echo " ";

echo -n "Arrival Time inputs: ";
read -a arrival_time;

echo -n "Burst Time inputs: ";
read -a burst_time;

#Count Number of Processes
PROCESSES=${#arrival_time[@]};

#Calculate The total time for COMPLETION OF ALL PROCESS
total_time=0;

for i in ${burst_time[@]}; do
	let total_time+=$i
done

#Calculate SMALLEST ARRIVAL TIME
smallest=0;

for((i=0;i<PROCESSES;i++)); do
	if [ ${arrival_time[i]} -lt ${arrival_time[smallest]} ]; then
		smallest=$i;
	fi
done

early_bird=${arrival_time[smallest]};

#Calculte the total RUN TIME OF CPU
if [ $early_bird -ne 0 ]; then
	let total_time+=$early_bird;
fi 

#Sort the Processes, initialize array for WAITING TIME, Add Turnaround time
sorted=();
waiting_time=();
turnaround_time=();

for((i=0;i<PROCESSES;i++)); do
	sorted+=($i);
	waiting_time+=(0);
	let total_turnaround_time+=${burst_time[${i}]};
done

temp=0;

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

			temp=${sorted[${i}]};
			sorted[i]=${sorted[${j}]};
			sorted[j]=$temp;

		fi
	done
done

#Operation STRN: Begin
current_process=-1;
previous_process=0;

echo -e "\nTIME \t\t PROCESS";
echo -e "==== \t\t =======";

for((current_time=$early_bird;current_time<total_time;current_time++)); do
	previous_process=$current_process;

	#Check if there is Burst Time on ANY process
	for((i=0;i<PROCESSES;i++)); do
		if  [ ${burst_time[i]} -ne 0 ]; then
			current_process=$i;
			break;
		fi
	done

	#Check who has the shortest burst AND has arrived/already in queue
	for((i=0;i<PROCESSES;i++)); do
		if  [ ${burst_time[i]} -ne 0 ] && 
			[ ${burst_time[i]} -lt ${burst_time[current_process]} ] &&
		   	[ ${arrival_time[i]} -le $current_time ]; then
				current_process=$i;
		fi
	done

	#Finding the Process Number
	let current=${sorted[${current_process}]}+1;

	#Burst Time deduction by 1 millisecond
	let burst_time[current_process]-=1;

	#Waiting Time Calculation per process
	for((i=0;i<PROCESSES;i++)); do
		if [ $i -ne $current_process ] && 
		   [ ${burst_time[i]} -ne 0 ] && 
		   [ ${arrival_time[i]} -le $current_time ]; then
				let waiting_time[i]+=1;
		fi
	done

	#Implement Gantt Chart (Use Mr. Timothy's Version)
	if [ $previous_process -ne $current_process ]; then
		echo -e $((current_time))" \t\t   P"$current;
	fi

done

echo -e $current_time " \t\t   End";

echo -e "\n";

#Find Total Waiting Time and complete Total Turnaround Time
total_waiting_time=0;

for i in ${waiting_time[@]}; do
	let total_waiting_time+=$i;
done

let total_turnaround_time+=$total_waiting_time;

#Calculate Average Waiting Time and Average Turnaround Time
Average_Turnaround=$(awk "BEGIN {printf \"%.2f\",${total_turnaround_time}/${PROCESSES}}");
Average_Waiting=$(awk "BEGIN {printf \"%.2f\",${total_waiting_time}/${PROCESSES}}");

#Stats about Algorithm
echo "Total Waiting Time: "$total_waiting_time"ms";
echo "Total Turnaround Time: "$total_turnaround_time"ms";
echo "Average Waiting Time: "$Average_Waiting"ms";
echo "Average Turnaround Time: "$Average_Turnaround"ms";
echo " ";