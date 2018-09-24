using System;
using System.Drawing;
using System.Windows.Forms;

public class Drawcircleframe : Form
{
    private const int formwidth = 1920; 
    private const int formheight = 1200; 
                                         

    private const int upper_left_corner_x_coordinate = 100;
    private const int upper_left_corner_y_coordinate = 80;
    private const int rectangle_width = 1050;
    private const int rectangle_height = 460;
    private const int lower_right_corner_x_coordinate = upper_left_corner_x_coordinate + rectangle_width;
    private const int lower_right_corner_y_coordinate = upper_left_corner_y_coordinate + rectangle_height;

    
    private Color current_color = Color.Yellow;
    private Color color_200 = Color.Yellow;
    private Color color_400 = Color.Yellow;
    private Color color_600 = Color.Yellow;

    private int radius = 0;


    Pen my_Pen = new Pen(Color.White, 3);
    
    

    private Label title = new Label();
    private Font myFont = new Font("Comic Sans MS", 24, FontStyle.Regular);





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


 
    private bool graphicShow = false;

    private Label label1 = new Label();

    

    //Locations
    private Point location_of_title = new Point(800, 50);


    
   

    private Point location_of_red_button = new Point(650, 950);
    private Point location_of_green_button = new Point(650, 1000);
    private Point location_of_blue_button = new Point(650, 1050);

    private Point location_of_radius_button_s = new Point(850, 950);
    private Point location_of_radius_button_m = new Point(850, 1000);
    private Point location_of_radius_button_l = new Point(850, 1050);

    private Point location_of_draw_button = new Point(1050, 950);
    private Point location_of_erase_button = new Point(1050, 1000);
    private Point location_of_quit_button = new Point(1050, 1050);

    //hex color
    //Color mygreen = ColorTranslator.FromHtml("#44FFBF"); 

    private Color myBlue = Color.FromArgb(0, 191, 255);
    private Color mygreen = Color.FromArgb(153, 204, 51);
    //Color backgroundColor = Color.FromArgb(16, 16, 16);
    //private Color backgroundColor = Color.FromArgb(14, 47, 68);
    private Color backgroundColor = Color.FromArgb(17,1,26);
    //(153,204,51)





    public void make_btn()
    {
        //color buttons
        red_btn.Text = "Red";
        red_btn.Size = new Size(150, 50);
        red_btn.Location = location_of_red_button;
        red_btn.Font = myFont;
        red_btn.BackColor = Color.Red;
        red_btn.ForeColor = Color.White;

        blue_btn.Text = "Blue";
        blue_btn.Size = new Size(150, 50);
        blue_btn.Location = location_of_blue_button;
        blue_btn.Font = myFont;
        blue_btn.BackColor = myBlue;
        blue_btn.ForeColor = Color.White;

        green_btn.Text = "Green";
        green_btn.Size = new Size(150, 50);
        green_btn.Location = location_of_green_button;
        green_btn.Font = myFont;
        green_btn.BackColor = mygreen;
        green_btn.ForeColor = Color.White;


        //radius buttons
        radius_btn_s.Text = "200";
        radius_btn_s.Size = new Size(150, 50);
        radius_btn_s.Location = location_of_radius_button_s;
        radius_btn_s.Font = myFont;
        radius_btn_s.BackColor = Color.Red;
        radius_btn_s.ForeColor = Color.White;

        radius_btn_m.Text = "400";
        radius_btn_m.Size = new Size(150, 50);
        radius_btn_m.Location = location_of_radius_button_m;
        radius_btn_m.Font = myFont;
        radius_btn_m.BackColor = myBlue;
        radius_btn_m.ForeColor = Color.White;

        radius_btn_l.Text = "600";
        radius_btn_l.Size = new Size(150, 50);
        radius_btn_l.Location = location_of_radius_button_l;
        radius_btn_l.Font = myFont;
        radius_btn_l.BackColor = mygreen;
        radius_btn_l.ForeColor = Color.White;

        //Utility buttons
        draw_btn.Text = "Draw";
        draw_btn.Size = new Size(150, 50);
        draw_btn.Location = location_of_draw_button;
        draw_btn.Font = myFont;
        draw_btn.BackColor = Color.DodgerBlue;
        draw_btn.ForeColor = Color.White;

        erase_btn.Text = "Erase";
        erase_btn.Size = new Size(150, 50);
        erase_btn.Location = location_of_erase_button;
        erase_btn.Font = myFont;
        erase_btn.BackColor = Color.Orange;
        erase_btn.ForeColor = Color.White;

        quit_btn.Text = "Exit";
        quit_btn.Size = new Size(150, 50);
        quit_btn.Location = location_of_quit_button;
        quit_btn.Font = myFont;
        quit_btn.BackColor = Color.Purple;
        erase_btn.ForeColor = Color.White;

    }



    public Drawcircleframe()   //The constructor of this class
    {  //Set the title of this form.
        Text = "How to draw a rectangle.  But how do you draw a circle?";
        System.Console.WriteLine("formwidth = {0}. formheight = {1}.", formwidth, formheight);
        //Set the initial size of this form
        Size = new Size(formwidth, formheight);
        //Set the background color of this form
        BackColor = backgroundColor;


        title.Text = "Drawing Circles";
        title.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        title.Font = new System.Drawing.Font("Arial", 24, FontStyle.Bold);
        title.Size = new Size(300, 60);
        title.Location = location_of_title;
        //title.BackColor = Color.Cyan;



        make_btn();


        my_Pen.Color = Color.Green;



        Controls.Add(title);
        Controls.Add(red_btn);
        Controls.Add(blue_btn);
        Controls.Add(green_btn);

        Controls.Add(radius_btn_s);
        Controls.Add(radius_btn_m);
        Controls.Add(radius_btn_l);
    
        Controls.Add(draw_btn);
        Controls.Add(erase_btn);
        Controls.Add(quit_btn);

   

        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
        ToolTip1.SetToolTip(this.quit_btn, "Quit Program");


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

        //erasebutton.Font = new Font(" ", 12, FontStyle.Underline);
        
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
    }
    protected void radius_btn_m_clicked(Object sender, EventArgs events)
    {
        radius = 400;
    }
    protected void radius_btn_l_clicked(Object sender, EventArgs events)
    {
        radius = 600;
    }




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
        Console.WriteLine("200: " + color_200 + "400: " + color_400  + "600: " + color_600);
    }



    /*

    protected void showrectangle(Object sender, EventArgs events)
    {
        Drawfunction();
        rectanglevisible = true;
        Invalidate();
        System.Console.WriteLine("You clicked on the Draw button.");
    }
    */

    protected void eraseCircles(Object sender, EventArgs events)
    {
        graphicShow = false;
        Invalidate();
        System.Console.WriteLine("You clicked on the Erase button.");

        //MessageBox.Show("Version 1.0.0");


    }//End of method eraserectangle

    protected void exitfromthisprogram(Object sender, EventArgs events)
    {
        System.Console.WriteLine("This program will end execution.");
        Close();
    }





    protected override void OnPaint(PaintEventArgs e)
    {
        
        Graphics graph = e.Graphics;

        if (graphicShow)
        {

            if (radius == 200)
            {
                Rectangle rect_info = Circle_algorithms.getcircleinfo(formwidth, formheight, radius);
                my_Pen.Color = color_200;
                graph.DrawEllipse(my_Pen, rect_info);
            }

            if (radius == 400)
            {
                Rectangle rect_info2 = Circle_algorithms.getcircleinfo(formwidth, formheight, radius);
                my_Pen.Color = color_400;
                graph.DrawEllipse(my_Pen, rect_info2);
            }

            if (radius == 600)
            {
                Rectangle rect_info3 = Circle_algorithms.getcircleinfo(formwidth, formheight, radius);
                my_Pen.Color = color_600;
                graph.DrawEllipse(my_Pen, rect_info3);
            }
        }
      
        base.OnPaint(e);
    }







}//End of class Drawrectangleframe