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

 File name: drawCircleFrame.cs
 File Description: This file simply calls Drawcircleframe Form class 
 Progress: COMPLETE

 How to run:
 In the terminal, past this command: 'sh build.sh'
 */

using System;
using System.Windows.Forms;
public class DrawCircleMain
{
    public static void Main()
    {
        System.Console.WriteLine("The graphics program will begin now.");
        Drawcircleframe application = new Drawcircleframe();
        Application.Run(application);
        System.Console.WriteLine("This graphics program has ended.  Bye.");
    }//End of Main function
}//End of Drawrectanglemain
