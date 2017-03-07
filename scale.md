# Scale
To manage scalability in Trawiller Back-End and prepared it for heavy traffic we are going to implement the next architecture.

[Image: Scale_Diagram.jpg]

To keep the quality of services when the number of users/agents/consumers will be growing we need to keep attention closely to the next elements:

•	Because we are accepting all kind of big files without limitations, the Blob Storage and Table Storage are likely to reach their threshold. A solution of this threshold is created multiple Storage Accounts and replicate the same scheme when the platform is reaching their storage limits
•	Keep the track of all Web Servers and SQL Servers to know when add new nodes. Could use tools like SCOM for monitoring purpose. (On-Premises)
•	If the system is mount totally in a cloud provider, configure the auto-grow settings
•	Load Tests to know the platform limits