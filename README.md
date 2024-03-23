# E-Series Approximation

This repository contains a C# program that approximates the mathematical constant e, also known as Euler's number, using a series expansion.

## Description

The program calculates the value of e by summing the inverse of factorial for each number from 0 to a specified limit. This method is based on the infinite series expansion of e:

$$ e = \sum_{n=0}^{\infty} \frac{1}{n!} $$

Due to the limitations of computational resources and data types, the program uses a fixed number of terms to approximate e.

## Getting Started

### Dependencies

- .NET 8.0 SDK or higher
- Visual Studio 2022 or any compatible IDE that supports C# development

### Installing

- Clone the repository using `git clone https://github.com/mht83/e_series.git`.
- Open the solution file in Visual Studio or your preferred IDE.

### Executing program

- Build the solution.
- Run the program.
- The output will display the approximate value of e and the actual value of e as defined in the `System.Math` class.

