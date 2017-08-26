# Assumptions
- A key part of this solution is the DB size estimation.
  A separate excel file is added with the calculations but the main assumptions there are:
  * The challange's details (5M searches per day, 15K unique routes)
  * In order to describe the route a record of about 1Kbytes is needed (uncompressed)
    This is based on a made up record file (see record.json).
  * Total results that needs caching per route per day is 30 on average - assuming this doesn't change much during a given day.
  * In order to allow for mistakes a 10x factor was added to the final size estimation.

- Assuming origin and destination airports are represented in the system as a 'long' value.
  This can be changed to string or GUID with slight implications on data size but the design will
  still hold.
- 
