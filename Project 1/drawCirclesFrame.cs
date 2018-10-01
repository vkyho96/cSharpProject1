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

 File Name: drawCircleFrame.cs
 File Discription: This file builds the graphical interface of the program
 Issue: NONE
 Progress: COMPLETE
 Comment: might remove button hover

 How to run:
 In the terminal, past this command: 'sh build.sh'
 */


using System;
using System.Drawing;
using System.Windows.Forms;

public class Drawcircleframe : Form
{   
    //application size
    private const int formwidth = 1600;
    private const int formheight = 900;

    //string labels
    private Label label_color = new Label();
    private Label label_radius = new Label();
    private Label label_action = new Label();
    
    private Label title = new Label();

    private int radius = 0;
    private int radius_1 = 0;
    private int radius_2 = 0;
    private int radius_3 = 0;


    private Color current_color = Color.Yellow;
    private Color color_200 = Color.Yellow;
    private Color color_400 = Color.Yellow;
    private Color color_600 = Color.Yellow;

    private Color myBlue = Color.FromArgb(0, 191, 255);
    private Color mygreen = Color.FromArgb(153, 204, 51);
    private Color backgroundColor = Color.FromArgb(57, 96, 115);

    private Color backgroundColor_btn = Color.FromArgb(64, 107, 128);

    //utility 
    Pen my_Pen = new Pen(Color.White, 3);
    private Font font_large = new Font("Comic Sans MS", 36, FontStyle.Regular);
    private Font font_medium = new Font("Comic Sans MS", 24, FontStyle.Regular);
    private Font font_small = new Font("Comic Sans MS", 16, FontStyle.Regular);


    // Create rectangle for ellipse.
    Rectangle rect = new Rectangle(500, 0, 200, 200);



    //Buttons
    private Button draw_btn = new Button();
    private Button erase_btn = new Button();
    private Button quit_btn = new Button();

    private Button red_btn = new Button();
    private Button blue_btn = new Button();
    private Button green_btn = new Button();

    private Button radius_btn_s = new Button();
    private Button radius_btn_m = new Button();
    private Button radius_btn_l = new Button();


    //helpers
    private bool graphicShow = false;
    //private Label label1 = new Label();



    //Locations
    private Point location_of_title = new Point(500, 80);

    private Point location_of_label_color = new Point(550, 650);
    private Point location_of_red_button = new Point(550, 700);
    private Point location_of_green_button = new Point(550, 750);
    private Point location_of_blue_button = new Point(550, 800);

    private Point location_of_label_radius = new Point(750, 650);
    private Point location_of_radius_button_s = new Point(750, 700);
    private Point location_of_radius_button_m = new Point(750, 750);
    private Point location_of_radius_button_l = new Point(750, 800);

    private Point location_of_label_action = new Point(950, 650);
    private Point location_of_draw_button = new Point(950, 700);
    private Point location_of_erase_button = new Point(950, 750);
    private Point location_of_quit_button = new Point(950, 800);






    public void make_btn()
    {
        /* CUSTOMIZATION*/

        //color buttons 
        red_btn.Text = "Red";
        red_btn.Size = new Size(150, 50);
        red_btn.Location = location_of_red_button;
        red_btn.Font = font_medium;
        red_btn.BackColor = Color.Red;
        red_btn.ForeColor = Color.White;

        blue_btn.Text = "Blue";
        blue_btn.Size = new Size(150, 50);
        blue_btn.Location = location_of_blue_button;
        blue_btn.Font = font_medium;
        blue_btn.BackColor = myBlue;
        blue_btn.ForeColor = Color.White;

        green_btn.Text = "Green";
        green_btn.Size = new Size(150, 50);
        green_btn.Location = location_of_green_button;
        green_btn.Font = font_medium;
        green_btn.BackColor = mygreen;
        green_btn.ForeColor = Color.White;


        //radius buttons
        radius_btn_s.Text = "200";
        radius_btn_s.Size = new Size(150, 50);
        radius_btn_s.Location = location_of_radius_button_s;
        radius_btn_s.Font = font_medium;
        radius_btn_s.BackColor = Color.Red;
        radius_btn_s.ForeColor = Color.White;

        radius_btn_m.Text = "400";
        radius_btn_m.Size = new Size(150, 50);
        radius_btn_m.Location = location_of_radius_button_m;
        radius_btn_m.Font = font_medium;
        radius_btn_m.BackColor = myBlue;
        radius_btn_m.ForeColor = Color.White;

        radius_btn_l.Text = "600";
        radius_btn_l.Size = new Size(150, 50);
        radius_btn_l.Location = location_of_radius_button_l;
        radius_btn_l.Font = font_medium;
        radius_btn_l.BackColor = mygreen;
        radius_btn_l.ForeColor = Color.White;

        //Action buttons
        draw_btn.Text = "Draw";
        draw_btn.Size = new Size(150, 50);
        draw_btn.Location = location_of_draw_button;
        draw_btn.Font = font_medium;
        draw_btn.BackColor = Color.DodgerBlue;
        draw_btn.ForeColor = Color.White;

        erase_btn.Text = "Erase";
        erase_btn.Size = new Size(150, 50);
        erase_btn.Location = location_of_erase_button;
        erase_btn.Font = font_medium;
        erase_btn.BackColor = Color.Orange;
        erase_btn.ForeColor = Color.White;

        quit_btn.Text = "Exit";
        quit_btn.Size = new Size(150, 50);
        quit_btn.Location = location_of_quit_button;
        quit_btn.Font = font_medium;
        quit_btn.BackColor = Color.Purple;
        erase_btn.ForeColor = Color.White;

        label_color.Text = "Select Color";
        label_color.Size = new Size(150, 50);
        label_color.Location = location_of_label_color;
        label_color.Font = font_small;
        label_color.BackColor = backgroundColor_btn;
        label_color.ForeColor = Color.White;

        label_radius.Text = "Select Radius";
        label_radius.Size = new Size(150, 50);
        label_radius.Location = location_of_label_radius;
        label_radius.Font = font_small;
        label_radius.BackColor = backgroundColor_btn;
        label_radius.ForeColor = Color.White;

        label_action.Text = "Select Action";
        label_action.Size = new Size(150, 50);
        label_action.Location = location_of_label_action;
        label_action.Font = font_small;
        label_action.BackColor = backgroundColor_btn;
        label_action.ForeColor = Color.White;

    }



    public Drawcircleframe()   //The constructor of this class
    {  //Set the title of this form.
        Text = "Draw circles";
        //Set the initial size of this form
        Size = new Size(formwidth, formheight);
        //Set the background color of this form
        BackColor = backgroundColor;


        title.Text = "Drawing Circles by Van Ho";
        title.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        title.Font = font_large;
        title.Size = new Size(700, 80);
        title.Location = location_of_title;
    
        make_btn();

        my_Pen.Color = Color.Green;

        // display
        Controls.Add(title);

        Controls.Add(label_color);
        Controls.Add(red_btn);
        Controls.Add(blue_btn);
        Controls.Add(green_btn);

        Controls.Add(label_radius);
        Controls.Add(radius_btn_s);
        Controls.Add(radius_btn_m);
        Controls.Add(radius_btn_l);

        Controls.Add(label_action);
        Controls.Add(draw_btn);
        Controls.Add(erase_btn);
        Controls.Add(quit_btn);


        //  BUTTON HANGLERS DECLARATION
        red_btn.MouseEnter += new EventHandler(red_btn_onMouseEnter);
        red_btn.MouseLeave += new EventHandler(red_btn_onMouseLeave);
        blue_btn.MouseEnter += new EventHandler(blue_btn_onMouseEnter);
        blue_btn.MouseLeave += new EventHandler(blue_btn_onMouseLeave);
        green_btn.MouseEnter += new EventHandler(green_btn_onMouseEnter);
        green_btn.MouseLeave += new EventHandler(green_btn_onMouseLeave);
        erase_btn.MouseEnter += new EventHandler(erase_btn_onMouseEnter);
        erase_btn.MouseLeave += new EventHandler(erase_btn_onMouseLeave);

        draw_btn.Click += new EventHandler(Drawfunction);
        erase_btn.Click += new EventHandler(eraseCircles);
        quit_btn.Click += new EventHandler(exitfromthisprogram);
        red_btn.Click += new EventHandler(red_btn_clicked);
        blue_btn.Click += new EventHandler(blue_btn_clicked);
        green_btn.Click += new EventHandler(green_btn_clicked);
        radius_btn_l.Click += new EventHandler(radius_btn_l_clicked);
        radius_btn_m.Click += new EventHandler(radius_btn_m_clicked);
        radius_btn_s.Click += new EventHandler(radius_btn_s_clicked);



    }//End of constructor





    protected void red_btn_onMouseEnter(object sender, EventArgs events)
    {
        base.OnMouseEnter(events);
        red_btn.BackColor = Color.White;
        red_btn.ForeColor = Color.Red;
    }

    protected void red_btn_onMouseLeave(object sender, EventArgs events)
    {
        base.OnMouseEnter(events);
        red_btn.BackColor = Color.Red;
        red_btn.ForeColor = Color.White;
    }

    protected void blue_btn_onMouseEnter(object sender, EventArgs events)
    {
        base.OnMouseEnter(events);
        blue_btn.BackColor = Color.White;
        blue_btn.ForeColor = myBlue;
    }

    protected void blue_btn_onMouseLeave(object sender, EventArgs events)
    {
        base.OnMouseEnter(events);
        blue_btn.BackColor = myBlue;
        blue_btn.ForeColor = Color.White;
    }


    protected void green_btn_onMouseEnter(object sender, EventArgs events)
    {
        base.OnMouseEnter(events);
        green_btn.BackColor = Color.White;
        green_btn.ForeColor = mygreen;
    }

    protected void green_btn_onMouseLeave(object sender, EventArgs events)
    {
        base.OnMouseEnter(events);
        green_btn.BackColor = mygreen;
        green_btn.ForeColor = Color.White;
    }


    protected void erase_btn_onMouseEnter(object sender, EventArgs events)
    {
        base.OnMouseEnter(events);
        erase_btn.BackColor = Color.White;
        erase_btn.ForeColor = Color.Orange;
    }

    protected void erase_btn_onMouseLeave(object sender, EventArgs events)
    {
        base.OnMouseEnter(events);
        erase_btn.BackColor = Color.Orange;
        erase_btn.ForeColor = Color.White;
    }





    //boolean Color Switch
    protected void red_btn_clicked(Object sender, EventArgs events)
    {
        current_color = Color.Red;
    }
    protected void blue_btn_clicked(Object sender, EventArgs events)
    {
        current_color = Color.Blue;
    }
    protected void green_btn_clicked(Object sender, EventArgs events)
    {
        current_color = Color.Green;
    }



    //boolean radius Switch
    protected void radius_btn_s_clicked(Object sender, EventArgs events)
    {
        radius = 200;
        radius_1 = 200;
    }
    protected void radius_btn_m_clicked(Object sender, EventArgs events)
    {
        radius = 400;
        radius_2 = 400;
    }
    protected void radius_btn_l_clicked(Object sender, EventArgs events)
    {
        radius = 600;
        radius_3 = 600;
    }



    // assign selected color to color varible corresonding to a specific radius
    protected void Drawfunction(object sender, EventArgs param)
    {
        switch (radius)
        {
            case 200:
                color_200 = current_color;
                break;
            case 400:
                color_400 = current_color;
                break;
            case 600:
                color_600 = current_color;
                break;
            default:
                Console.WriteLine("Err, switch statement");
                break;
        }
        graphicShow = true;
        Invalidate();

    }


    protected void eraseCircles(Object sender, EventArgs events)
    {
        graphicShow = false;
        Invalidate();
    }

    protected void exitfromthisprogram(Object sender, EventArgs events)
    {
        System.Console.WriteLine("Program ended.");
        Close();
    }


    protected override void OnPaint(PaintEventArgs e)
    {

        Graphics graph = e.Graphics;
        SolidBrush myBrush = new SolidBrush(backgroundColor_btn);

        graph.FillRectangle(myBrush, 450, 625, 750, 350);

        if (graphicShow)
        {
                Rectangle rect_1 = new Rectangle();
                rect_1 = Circle_algorithms.getcircleinfo(formwidth, formheight, radius_1);
                my_Pen.Color = color_200;
                graph.DrawEllipse(my_Pen, rect_1);


                Rectangle rect_2 = new Rectangle();
                rect_2 = Circle_algorithms.getcircleinfo(formwidth, formheight, radius_2);
                my_Pen.Color = color_400;
                graph.DrawEllipse(my_Pen, rect_2);


                Rectangle rect_3 = new Rectangle();
                rect_3 = Circle_algorithms.getcircleinfo(formwidth, formheight, radius_3);
                my_Pen.Color = color_600;
                graph.DrawEllipse(my_Pen, rect_3);

        }
        base.OnPaint(e);
    }
}//End of class 
