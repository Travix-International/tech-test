# Scale

All proposed solutions are easily can be scaled both vertically and horizontally

To be sure that system have fail over solution DB must have multi-instance architecture with organized into cluster
 
Requests can be scaled in 2 level by DNS round robin and by Nginx upstream between few hotplug node.js instances hosted on different machines
 
There must be an monitoring solution like Zabbix that will monitor entire sytem and alert in case of unusual situation 
