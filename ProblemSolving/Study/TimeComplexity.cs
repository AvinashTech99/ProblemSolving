/*
 
Time complexity tells us how the running time increases as the input size increases.

 Time complexity is measured using asymptotic notations, primarily Big O notation, to describe how an algorithm's runtime grows in relation to its input size.

Other notations like Omega (\(\Omega \)) and Theta (\(\Theta \)) are also used to denote the best-case and average-case scenarios, respectively. 

--------------- Setps ------------------------------------------------
1 >> Count how many times each part of the code runs
loops, recursions, iterated operations
Example:
    for (int i = 0; i < n; i++)
    {
    }
    this loop runs n times -> O(n) 


2>> Ignore constant-time operations

    simple operation like addition, subtraction, assignment, comparison
    All of these are O(1).
 

3>> Focus on loops

    loops tell you the dominant time
    for (int i = 0; i < n; i++)
      for (int j = 0; j < n; j++)
      {
      }
    
    Inner loops run n tomes
    Outer loop runs n times

    Total operations = n * n = n^2 -> O(n^2)

4 >> Add time  when loops are sequential
    for (int i = 0; i < n; i++)
    {
    }
    for (int j = 0; j < m; j++)
    {
    }
    Total operations = n + m -> O(n + m) 

    for (int i = 0; i < n; i++)
    {
    }
    for (int j = 0; j < n; j++)
    {
    }
    Total operations = n + n = 2n -> O(n)
    

5 >> Multiply time when loops are nested
    for (int i = 0; i < n; i++)
      for (int j = 0; j < m; j++)
      {
      }
    
    Total operations = n * m -> O(n*m)
 
6 >> Drop non-dominant terms and constants
    O(n^2 + n) -> O(n^2)
    O(n + log n) -> O(n)
    O(n^2 + n log n) -> O(n^2) 
    
    O(2n + 5) → O(n)
    O(n² + n) → O(n²)

 */
