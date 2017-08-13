# Scale
When the number of users/agents/consumers grows from 100 per day, to a 10000000 per day.
We will scaled out the web app services and redis cache by replicating the resource group globally to all necesary regions. 
CosmosDB will be also scaled out by adding global database regions to documentdb, this action will automatically replicate the data to all regions.
Azure traffic manager will be added to handle petitions and redirect them to the its closest endpoint to minimize latency. 