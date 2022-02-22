# Methodologies and Technologies of Program Development - Laboratory work 1

## Description

The program solves quadratic equation. based on the three coefficients, input by the user.

Quadratic equation is an equation of the form:

    a * x^2 + b * x + c = 0
    
In equation: *a*, *b*, *c* are numbers and *x* is a variable.

The program uses following algorithm to solve the equation:

- If there are no coefficients or coefficient a is equal to zero, the program will not count roots as the equation will not be quadratic
- If there is coefficient, the problem counts discriminant:
        
        D = b^2 - 4 \* a \* c

  - If *D < 0*, returns null as there are no roots to such equations
  - If *D = 0*, there is single root:

          x = -b / (2 * a)

  - If *D > 0*, there are two roots:

           x1 = (-b + sqrt(D)) / (2 * a),
           x2 = (-b - sqrt(D)) / (2 * a)

## Installation and usage

You must install .Net framework to run the program (*the program is written in framework .Net Core version 3.1, minimal version of .Net SDK 5.0.403*).

To run the program, clone the repository from github:

    git clone https://github.com/IvanOmelchenkoIP/MTD-Lab1.git

You can run the program:

- Directly from *src* dirtectory of the project 
- Using path to the project

### Direct launch

To launch the proggram directly from the *src* folder, you can use command:

    dotnet run

You can write a path to a text file when launching the app like this:

    dotnet run yourPathToTextFile

*For example:*

    dotnet run D:\MTD-Lab1\testFiles\01.txt

### Launch using path

To launch the program using path, you can use following command:

    dotnet run --project yourPathToProject

*For example:*

    dotnet run --project D:\MTD-Lab1\src\MTD-Lab1.csproj

You can write a path to the text file when launching app like this:

    dotnet run --project yourPathToProject yourpathToTextFile

*For example:*
    
    dotnet run --project D:\MTD-Lab1\src\MTD-Lab1.csproj D:\MTD-Lab1\testFiles\01.txt

## Input modes

There are two work modes of the program:

- File mode
- Interactive mode

### File mode

**File mode occurs when the path to a  text file is written when calling the program.** This means that coefficients for solving equation will be taken from the file the user has written path to. To extract data correctly, a text file with the content of following format is required:

    a\sb\sc\n
    
In the format: *\s* is space symbol, *\n* a symbol of transition to a new string, *a*, *b*, *c* are coefficients that must be real numbers with '.' as a floating sign. Coefficient *a* must not be zero.

*Possible errors during file input:*

- File can not be found by given path. The program will log an error and will not count the roots of equation
- Amount of coefficients in file is not equal to that of a standart quadratic equation (does not equal to three). The program will log an error and will not counnt the roots of equation
- Coefficient *a* is input as zero The program will log an error and will not count the roots
- Coefficient (any) is not a real number. The program wil log an error and will not count the roots

### Interractive mode

**Interractive mode occurs when no file path is written when calling the program.** It requires users to manually input coefficients. The coefficients must be real numbers with '.' as a floating sign. Coefficient *a* must not be zero.

*Possible errors during interractive input:*

- Coefficient *a* is input as 0. The program will ask to re-enter the coefficient
- Coefficient (any) is not a real number. The program will ask to re-enter the number

## Revert Commit

[Link to Revert Commit](https://github.com/IvanOmelchenkoIP/MTD-Lab1/commit/b0b7c5814b79991bb2bb00f656763aa1ed7c96f4)

[Link to Commit it reverts](https://github.com/IvanOmelchenkoIP/MTD-Lab1/commit/7ee2f49c64260cfa71569e1159153e8b34e021af)