/*
 Program name: Draw Circle (assignment 1)
 Author: Van Ho
 Email: thefirstgoldenage@csu.fullerton.edu
 Language: C#
 Date of Development: 09-10-2018  -  09-30-2018

 Purpose of program: draw circle with selected radius.
 Features: 3 colors: Red, Green, Blue
           3 radius: 200, 400, 600
           Actions: Draw, Erase, Quit

 File name: circlealgorithm.cs
 File Discription: this file provide imformation to draw the circles. 
 Issue: NONE
 Progress: COMPLETE

 How to run:
 In the terminal, past this command: 'sh build.sh'
 */


using System;
using System.Drawing;

public class Circle_algorithms
{

    public static Rectangle getcircleinfo(int graphareawidth, int graphareaheight, int radius)
    {
        Point corner = new Point((graphareawidth / 2) - radius, (graphareaheight / 2) - radius);

        //size obj has x distance and y distance
        Size lenwide = new Size(2 * radius, 2 * radius);
        Rectangle rect = new Rectangle(corner, lenwide);

        return rect;
    }//end of function

}//end of class

