# NullReferenceException in C# Example

This repository demonstrates a common C# coding error: the dreaded `NullReferenceException`. The `bug.cs` file shows the problematic code, while `bugSolution.cs` provides a solution.

## The Problem

The `ExampleClass` has a property `MyProperty`. The `MyMethod` attempts to access and use `MyProperty` without checking for null. If the constructor does not correctly initialize `MyProperty`, or if the class is instantiated without setting `MyProperty`, accessing `MyProperty` will result in a `NullReferenceException`.

## The Solution

The solution involves checking whether `MyProperty` is null before accessing it. This can be done using a simple `if` statement or the null-conditional operator (`?.`).  The `bugSolution.cs` provides an example of a corrected class.