
# 0x00. C# - Hello, World

## Learning Objectives

### General

* What is the meaning behind the name C#?
* Who is the lead architect of the development team of C#?
* What is .NET?
* What is the difference between C# and .NET?
* How to use VSCode and the integrated terminal to initialize, build, and run C# projects
* How to print text and variables using Console.Write

## Requirements

### Shell Scripts
* Allowed editors: vi, vim, emacs
* All your scripts will be tested on Ubuntu 14.04 LTS
* All your files should end with a new line
* The first line of all your files should be exactly #!/usr/bin/env bash
* All your files must be executable

### C# Tasks

* Allowed editors: Visual Studio Code
* All files will be compiled on Ubuntu 14.04 LTS using dotnet
* A README.md file, at the root of the folder of the project, is mandatory
* All default C# files named Program.cs should be renamed to the name given in each task
* You do not need to know about namespaces and classes yet. Namespaces should be omitted in this project. The default names generated in Program.cs for class are okay
* Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task names on the folders are correct
* You do not need to push your obj/ or bin/ folders

## Tasks

0. [Initialize new project](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/0-initialize_new_project.sh) : Write a Bash script that initializes a new C# project inside a folder titled 0-new_project. Use the command dotnet.
1. [Build new project](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/1-build_new_project.sh) : Write a Bash script that initializes and builds a new C# project inside a folder titled 1-new_project. Use the command dotnet.
2. [Run new project](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/2-run_new_project.sh) : Write a Bash script that initializes, builds, and runs a new C# project from a folder titled 2-new_project. Use the command dotnet.
3. [Hello, WriteLine](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/3-writeline/3-writeline.cs) : Write a C# script that prints exactly "Programming is like building a multilingual puzzle followed by a new line. Use the method Console.WriteLine.
4. [Print integer](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/4-print_integer/4-print_integer.cs) : Complete [this source code](https://intranet.hbtn.io/rltoken/euxMhFdEF0-XZCLtdqne4Q) in order to print the integer stored in the variable number, followed by Mission Street followed by a new line.
  - Your code should be exactly 10 lines long
  - The output of the script should be:
     - the number, followed by Mission Street
     - followed by a new line
5. [Print float](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/5-print_float/5-print_float.cs) : Complete [this source code](https://intranet.hbtn.io/rltoken/kuytn76s-qptXICqj2Vmmg) in order to print the float stored in the variable number with a precision of 2 digits.

  - Your script should be exactly 10 lines long
  - The output of the script should be:
     - Float: followed by the number with only 2 digits
     - followed by a new line
6. [Print string](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/6-print_string/6-print_string.cs) : Complete [this source code](https://intranet.hbtn.io/rltoken/BsLlMCzRgrGoeGqCGX3LWw) in order to print a string stored in the variable str 3 times, followed by its first 9 characters.

  - The output of the script should be:
     - the value of str 3 times
     - followed by a new line
     - followed by the first 9 characters of str
     - followed by a new line
  - You are not allowed to use any loops or conditional statement
7. [Play with strings](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/7-concat/7-concat.cs) : Complete [this source code](https://github.com/holbertonschool/0x00.cs/blob/master/7-concat.cs) to print Welcome to Holberton School!
  - Your code should be exactly 12 lines long
  - You are not allowed to use any loops or conditional statement
  - You have to use the variables str1 and str2 in your new line of code
8. [Print variables](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/8-print_variables/8-print_variables.cs) : Complete [this source code](https://intranet.hbtn.io/rltoken/c5U7giCio60Do2H4XU5YMg) in order to print the given variables as 972 Mission Street.

  - Your code should be exactly 12 lines long
  - You are not allowed to create new variables
  - You are not allowed to edit existing variables
  - The output of the script should be:
     - 972 Mission Street
     - followed by a new line
9. [Print specifiers](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/9-print_specifiers/9-print_specifiers.cs) : Complete [this source code](https://github.com/holbertonschool/0x00.cs/blob/master/9-print_specifiers.cs) in order to print the given variables as in the result shown.

  - Your code should be no more than 12 lines long
  - You are not allowed to create new variables
  - The target locale is en-US.utf-8
  - The output of the script should be:
     - Percent: 75.53% tip
     - followed by a new line
     - followed by Currency: $98,765.43
     - followed by a new line
10. [Copy - Cut - Paste](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/10-copy_cut_paste/10-copy_cut_paste.cs) : Complete [this source code](https://intranet.hbtn.io/rltoken/WOeBK1z0kP2-UUYhVmVEhQ).

  - Your code should be exactly 15 lines long
  - You are not allowed to use any loops or conditional statements
  - word_first_3 should contain the first 3 letters of the variable word
  - word_last_2 should contain the last 2 letters of the variable word
  - middle_word should contain the value of the variable word without the first and last letters
11. [Create a new sentence](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/11-concat_edges/11-concat_edges.cs) : Complete [this source code](https://github.com/holbertonschool/0x00.cs/blob/master/11-concat_edges.cs) to print object-oriented programming in C# followed by a new line.

  - Your code should be exactly 11 lines long
  - You are not allowed to use any loops or conditional statements
  - You are not allowed to create new variables
  - You are not allowed to use string literals

### ADVANCED TASK

12. [Hello, Error](https://github.com/JennyHadir/holbertonschool-csharp/blob/main/0x00-csharp-hello_world/100-hello_error/100-hello_error.cs) : Write a C# script that prints exactly [and that piece of art is useful - Dora Korpar, 2015-10-19]() followed by a new line.

  - Your script should print to stderr
  - Your script should exit with the status code 1
