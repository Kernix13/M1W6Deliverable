# C# Console app to convert between feet and meters

A simple C# console application that converts a distance in feet/meters to meters/feet. The user chooses the type of conversion and enters their measurement value to convert.

## Overview

This app lets the user pick if they want to:

1. Convert feet to meters, or
2. Convert meters to feet

There is only 2 elements in the conversion values array:

```cs
double[] conversions = new double[] { 0.3048, 3.28084 };
```

That should be a 2D array that allows for any English distance conversion (inches, feet, yards, miles, etc.) to any Metric conversion (meters, centimeters, kilometers, etc.)

This can then be extended for weights, temperatures, or any other value that can be converted from one unit of measure to another once the 2D array is created. That would require additional input from the user. At this time, the app is a simple one and adding additional conversion options will be added later.

<br>

## Prerequisites

- [.NET SDK 10.0](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio Code](https://code.visualstudio.com/) with C# Dev Kit

<!--
   Maybe add NuGet to the above list
   Google: "sample readme for a c# console application"
 -->

<br>

## Installation & Usage

1. Clone this repository and switch into project folder
   ```sh
   git clone https://github.com/Kernix13/M1W6Deliverable
   cd M1W6Deliverable
   ```
2. Compile a build of the application
   ```sh
   dotnet build
   ```
3. Run the application
   ```sh
   dotnet run
   ```
4. Create a solution file
   ```sh
   dotnet new sln
   ```
5. Link the project to the solution
   ```sh
   dotnet sln add M1W6Deliverable.csproj
   ```

### Quick Start

```sh
git clone https://github.com/Kernix13/M1W6Deliverable
cd M1W6Deliverable
dotnet build
dotnet run
dotnet new sln
dotnet sln add M1W6Deliverable.csproj
```

<br>

## Future Improvements

1. Allow for other conversions other than distance measurements
2. Allow for any unit of measurement to be converted
