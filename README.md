# C# RestSharp PET API Project 

## Overview
This repository contains a C# project built to interact with the PET API using the RestSharp library. 

## Prerequisites
- .NET Framework or .NET Core installed (version X.X.X)
- Some familiarity with C# language and RESTful APIs
- An IDE that supports C# (like Visual Studio or VS Code)

## Setup
1. Clone the repository: `git clone <repo-link>`
2. Open the solution file with your preferred IDE.
3. Make sure all the required libraries are included.

## Test run
 
### Run with Visual Studio
1. Open "Test Explorer", top navigation menu Test --> Test Explorer (This step only required if you haven't opened it yet)
2. Select .runsettings file, top navigation menu Test --> Configure Run Settings --> Select Solution Wide runsettings File
3. Right click on test of group of the tests you want to run and select "Run" from context menu
 
### Run from command line
1. Open command line inside of the test project directory
2. Type the following command "dotnet test --settings prod.runsettings"