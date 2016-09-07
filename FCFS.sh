#!/bin/bash

arrival_time=();
burst_time=();
total_time=0;
priority_table=();
PROCESSES_num=();

#Get Input for Arrival Time & Burst Time and maintain proper number of input
echo " ";

echo -n "Enter number of processes(Range between 3-10): ";
read PROCESSES;

echo " ";
#Prompt user to input between 3 to 10
while [ $PROCESSES -lt 3 ] || [ $PROCESSES -gt 10 ]; do
	echo -n "Number of Processes out of range. Enter Again: ";
	read PROCESSES
done

#Input for each data
for((i=0;i<PROCESSES;i++)); do
	echo -n "Enter Arrival Time for Process P"$((i+1))": ";
	read arrival;

	echo -n "Enter Burst Time for Process P"$((i+1))": ";
	read burst;

	echo -n "Enter Priority for Process P"$((i+1))": ";
	read priority;

	echo " ";

	arrival_time+=($arrival);
	burst_time+=($burst);
	priority_table+=($priority);
	PROCESSES_num+=($i);
	let total_time+=$burst;
done

#We need to swap, hence we need a temp as usual
#4 temp variables are : temp_arrival, temp_burst, temp_priority, temp_PROCESSES

temp_arrival=${arrival_time[0]}
temp_burst=${burst_time[0]}
temp_priority=${priority_table[0]}
temp_PROCESSES=${PROCESSES_num[0]}

for((i=0;i<PROCESSES;i++)); do
	for((j=i;j<PROCESSES;j++)); do
	if [ ${arrival_time[${j}]} -lt ${arrival_time[${i}]} ]; then
		#swapping if the next arrival time is less than that in front
		temp_arrival=${arrival_time[${j}]}
		temp_burst=${burst_time[${j}]}
		temp_priority=${priority_table[${j}]}
		temp_PROCESSES=${PROCESSES_num[${j}]}
		
		arrival_time[j]=${arrival_time[${i}]}
		burst_time[j]=${burst_time[${i}]}
		priority_table[j]=${priority_table[${i}]}
		PROCESSES_num[j]=${PROCESSES_num[${i}]}
		
		arrival_time[i]=$temp_arrival
		burst_time[i]=$temp_burst
		priority_table[i]=$temp_priority
		PROCESSES_num[i]=$temp_PROCESSES
	elif [ ${arrival_time[${j}]} -eq ${arrival_time[${i}]} ] && [ ${priority_table[${j}]} -lt ${priority_table[${i}]} ]; then
		temp_arrival=${arrival_time[${j}]}
		temp_burst=${burst_time[${j}]}
		temp_priority=${priority_table[${j}]}
		temp_PROCESSES=${PROCESSES_num[${j}]}
		
		arrival_time[j]=${arrival_time[${i}]}
		burst_time[j]=${burst_time[${i}]}
		priority_table[j]=${priority_table[${i}]}
		PROCESSES_num[j]=${PROCESSES_num[${i}]}
		
		arrival_time[i]=$temp_arrival
		burst_time[i]=$temp_burst
		priority_table[i]=$temp_priority
		PROCESSES_num[i]=$temp_PROCESSES
	fi
	done
done

#to allow higher priority process to run, the easier way to run each process is by running one(second) by one(second), hence we need to get
#total burst time to loop through the whole line of process
#new variable : total_burst_time

for((w=0;w<PROCESSES;w++)); do
	let total_burst_time+=${burst_time[${w}]}
done

#We separate each second as block(imagine it as blocks of time).
#new variable : current_block
#Cannot initiate current_block as first process in queue because ---processes may arrive at the same time but with different priority

for((i=0;i<total_burst_time;i++)); do
	for((j=0;j<PROCESSES;j++)); do
		echo "nothing"
	done 
done	
 
#Give Data For Each Process
echo -e "PROCESS(P) \t    ARRIVAL TIME \t     BURST TIME \t PRIORITY";
echo -e "========== \t    ============ \t     ========== \t ========";

for((i=0;i<PROCESSES;i++)); do
	echo -e "P"$((PROCESSES_num[i]+1)) "\t\t\t" ${arrival_time[i]} "\t\t\t" ${burst_time[i]} "\t\t" ${priority_table[i]}
done 

echo $total_burst_time