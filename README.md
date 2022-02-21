# Methodologies and Technologies of Program Development - Laboratory work 1

## Description

The program solves quadratic equation. based on the three coefficients, input by the user.

Quadratic equation is an equation of the form:

    a * x^2 + b * x + c = 0, where a, b, c are numbers and x is a variable

The program uses following algorithm to solve the equation:

- If there are no coefficients or coefficient a is equal to zero, the program will not count roots as the equation will not be quadratic
- If there is coefficient, the problem counts discriminant **D = b^2 - 4 \* a \* c**

  - If _D < 0_, returns null as there are no roots to such equations
  - If _D = 0_, there is single root

          x = -b / (2 * a)

  - If _D > 0_, there are two roots:

           x1 = (-b + sqrt(D)) / (2 * a),
           x2 = (-b - sqrt(D)) / (2 * a)

## Installation and Usage

You must install .Net framework to run the program (_the program is written in version 6.0.2_).

To run the program, clone the repository from github:

    git clone https://github.com/IvanOmelchenkoIP/MTD-Lab1.git

You can run the program directly from the _src_ directory of the project using

    dotnet run

You can also launch the project by its path (_path to .csproj file_):

    dotnet run --project yourPathToProject

For example:

    dotnet run --project D:\MTD-Lab1\src\MTD-Lab1.csproj

You can also write a path to file for the program to work in file input mode using commands

    dotnet run yourPathToTextFile
    dotnet run --project yourPathToProject yourpathToTextFile

Examples:

    dotnet run D:\MTD-Lab1\testFiles\01.txt
    dotnet run --project D:\MTD-Lab1\src\MTD-Lab1.csproj D:\MTD-Lab1\testFiles\01.txt

For direct launch from folder _src_ and for launch with project path respectively

## Work Modes

There are two work modes of the program:

- File mode
- Interactive mode

### File Mode

File mode occurs when the path to a file is written when calling the program. To extract data correctly, a text file with the content of following format is required

    a\sb\sc\n, where \s is space symbol, \n a symbol of transition to a new string, a, b, c are coefficients that must be real numbers with '.' as a floating sign

Possible errors during file input:

- File can not be found by given path. The program will log an error and will not count the roots of equation
- Amount of coefficients in file is not equal to that of a standart quadratic equation (does not equal to three). The program will log an error and will not counnt the roots of equation
- Coefficient _a_ is input as zero The program will log an error and will not count the roots
- Coefficient (any) is not a real number. The program wil log an error and will not count the roots

### Interractive Mode

Interractive mode occurs when no file path is written when calling the program. It requires users to manually input coefficients. The coefficients must be real numbers with '.' as a floating sign.

Possible errors during interractive input:

- Coefficient _a_ is input as 0. The program will ask to re-enter the coefficient
- Coefficient (any) is not a real number. The program will ask to re-enter the number

## Revert Commit

[Link to Revert Commit](https://github.com/IvanOmelchenkoIP/MTD-Lab1/commit/b0b7c5814b79991bb2bb00f656763aa1ed7c96f4)
[Link to Commit it reverts](https://github.com/IvanOmelchenkoIP/MTD-Lab1/commit/7ee2f49c64260cfa71569e1159153e8b34e021af)
