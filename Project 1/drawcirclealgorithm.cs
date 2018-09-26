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
