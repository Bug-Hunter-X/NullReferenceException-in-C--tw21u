# NullReferenceException in C# Example

This repository contains a simple C# example demonstrating a common runtime error: the `NullReferenceException`.  The example shows how to trigger this exception and offers a solution to prevent it.

## Bug Description

The `bug.cs` file shows an instance of `ExampleClass` where the `MyProperty` is not initialized before it is accessed in `MyMethod()`.  This results in a `NullReferenceException` when the code attempts to call `ToString()` on a null reference.

## Solution

The `bugSolution.cs` file presents a corrected version.  The solution initializes `MyProperty` to prevent the exception.  It shows how to assign a default value using the null-coalescing operator (`??`) as an example. 

## How to Reproduce

1. Clone this repository.
2. Compile and run `bug.cs`.  You'll observe a `NullReferenceException`. 
3. Compile and run `bugSolution.cs`.  This should run without error.