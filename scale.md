# Scale
1. **Software Support**
    * Software support scaling by using a longer hash length. We start by using 3 characters to support aprox 100 request p/ day, and make it higher as the number of dailly requests grow, or as we run out of possible hashes.
    
2. **Hardware Support**
    * Horizontal scalling by adding new workers at the rest service layer, and adding new cache nodes and/or database nodes as volume and traffic goes higher
