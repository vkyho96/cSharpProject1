#!/bin/bash
#In the official documemtation the line above always has to be the first line of any script file.

#Author: Van Ho
#Language: Bash

#Program name: Draw Circles

#This is a bash shell script to be used for compiling, linking, and executing the C sharp files of this assignment.
#Execute this file by navigating the terminal window to the folder where this file resides, and then enter either of the commands below:
#  sh run.sh   OR   ./build.sh   OR    bash run.sh

#System requirements:
#  A Linux system with BASH shell (in a terminal window).
#  The mono compiler must be installed.  If not installed run the command "sudo apt install mono-complete" without quotes.
#  The source files and this script file must be in the same folder.
#  This file, run.sh, must have execute permission.  Go to the properties window of build.sh and put a check in the
#  permission to execute box.


echo First remove old binary files
rm *.dll
rm *.exe

echo View the list of source files
ls -l

echo "Compile circlealgorithm.cs to create the file: circlealgorithm.dll"
mcs -target:library -r:System.Drawing.dll -out:drawcirclealgorithm.dll drawcirclealgorithm.cs

echo "Compile drawCirclesFrame.cs and link the previously created dll file(s)."
mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:drawcirclealgorithm.dll -out:drawCirclesFrame.dll drawCirclesFrame.cs

echo "Compile drawCircleMain.cs and link the previously created dll file(s) to create an executable file."
mcs -r:System.Windows.Forms.dll -r:System.Drawing.dll -r:drawcirclealgorithm.dll -r:drawCirclesFrame.dll -out:drawCircle.exe drawCircleMain.cs

echo "View the list of files in the current folder"
ls -l

echo "Run program."
./drawCircle.exe

echo "The script has terminated."
