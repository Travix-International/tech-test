# Assumptions

1. The problem should be solved at application level.
2. Infrastructure just should be used to scale horizontally, responding to the use of resources (CPU/memory/etc).
3. A cron is used to remove/disable the older fares.
4. A relational databased is used like MySQL