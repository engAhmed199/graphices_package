using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;
namespace PROJECT
{
    public partial class Form1 : Form
    {
        double preang=0;
       
        ArrayList row;
        string rep;
        bool cor=true;
        bool strat;
        void cors()
        {
            corx1.X = 0;
            corx1.Y = 675 / 2;
            corx2.X = 771;
            corx2.Y = 675 / 2;

            cory1.X = 771 / 2;
            cory1.Y = 0;
            cory2.X = 771 / 2;
            cory2.Y = 675;
            DDA(corx1, corx2);
            DDA(cory1, cory2);
        }
        Point corx1, corx2, cory1, cory2, newcen,trycen,temp1,temp2,Pp1;
        Point pa;
        Point pb;
        List<core> cores = new List<core>();
        List<points> pos = new List<points>();
        int con ;
        Point max, min,temp;
        int d = 0;
        int tx, ty;
        float sx, sy;
        double sin ,cos,ang;
        int num,x;
        char s ;
        Bitmap p=null;
        Point locxy;
        Point locx1y1;
        bool click1 = true, click2 = false,dir=false,rot=true,abxy=false;
        Rectangle rect;
        public Form1()
        {
            
            InitializeComponent();
            p = new Bitmap(pp.Width, pp.Height);
            cors();
            row = null;
            newcen.X=771 / 2;
            newcen.Y = 675 / 2;
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s='1';
        }

        private void bRESENHAMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = '2';
        }

        private void p1_MouseClick(object sender, MouseEventArgs e)
        {
            if (s == '8')
            {
                con++;
                if (con == 1)
                {
                    min = e.Location;
                }
                else if (con == 2)
                {
                    max.X = e.Location.X;
                    temp.X = max.X;
                    temp.Y = min.Y;
                    cores.Add(new core(min, temp));
                    DDA(min, temp);
                }
                else if (con == 3)
                {
                    max.Y = e.Location.Y;
                    cores.Add(new core(temp, max));
                    DDA(temp, max);
                }
                else if (con == 4)
                {
                    temp.X = min.X;
                    temp.Y = max.Y;
                    cores.Add(new core(max, temp));
                    DDA(max, temp);
                }
                else
                {
                    cores.Add(new core(temp, min));
                    DDA(temp, min);

                }
            }

            else if (s == '7')
            {
                // polygon-------------------------------------------------------
                if (click1)
                {
                    if (x == num)
                    {
                        locxy =Pp1= e.Location;

                    }
                    else
                    {
                        if (num > 0)
                        {
                            locxy = e.Location;
                            cores.Add(new core(locx1y1, locxy));
                            DDA(locx1y1, locxy);
                            num--;
                            if (num == 1)
                            {
                                cores.Add(new core(Pp1, locxy));
                                DDA(Pp1, locxy);
                                s = '0';
                            }
                            
                        }
                    }
                    click2 = true;
                    click1 = false;

                }
                else if (click2)
                {
                    locx1y1 = e.Location;
                    click1 = true;
                    click2 = false;
                    if (num > 0)
                    {
                        cores.Add(new core(locx1y1, locxy));
                        DDA(locxy, locx1y1);
                        num--;
                        if (num == 1)
                        {
                            cores.Add(new core(Pp1, locx1y1));
                            DDA(Pp1, locx1y1);
                            s = '0';
                        }
                    }
                }
            }//------------------------------------------------------
            else
            {// rest of shaps----------------------------------------------------------
                if (click1)
                {
                    locxy = e.Location;
                    click2 = true;
                    click1 = false;
                    if (s == '5' && !abxy)
                    {
                        click1 = true;
                        click2 = false;
                        ellipse();

                    }
                }
                else if (click2)
                {
                    locx1y1 = e.Location;
                    click1 = true;
                    click2 = false;
                    //------------------------

                    switch (s)
                    {
                        case '1':
                            cores.Add(new core(locx1y1, locxy));
                            DDA(locxy, locx1y1);
                            break;
                        case '2':
                            Bresenham(locxy, locx1y1);
                            break;
                        case '3':
                            MidCircle(locxy, calradius(locxy, locx1y1));
                            cores.Add(new core(locxy, locx1y1));
                            break;
                        case '4':
                            MidCircle(getmidpoint(locxy, locx1y1), calradius(getmidpoint(locxy, locx1y1), locx1y1));
                            cores.Add(new core(locxy, locx1y1));
                            break;
                    }

                }
            }
        }
        private void circleStripMenuItem1_Click(object sender, EventArgs e)
        {
            s = '3';
        }

        private void tWOPOINTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = '4';
        }
        
        private void eLLIPSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = '5';
        }
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            s = '6';
            this.Refresh();
            pp.Visible = false;
            click1 = true; click2 = false;
            locxy.X = 0;
            cores.Clear();
            d = 0;
        }
        private void lINEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pp.Visible)
                pp.Visible = true;
            click1 = true;
            click2 = false;
            cores.Clear();
            d = 0;
            dir = false; rot = true; abxy = false;
        }
        private void mIDPOINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pp.Visible)
                pp.Visible = true;
            click1 = true;
            click2 = false;
            cores.Clear();
            d = 0;
            dir = false; rot = true; abxy = false;
        }
        private void pOLYGONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d = 0;
            cores.Clear();
            if (!pp.Visible)
                pp.Visible = true;
            click1 = true;
            click2 = false;
            s = '7';
            dir = false; rot = true; abxy = false;
            while((num=x=int.Parse(Interaction.InputBox("","","",-1,-1)))<4)
            {
                MessageBox.Show("min value is 4","warning");
            }
            

        }

        
        // bresenham---------------------------------------------------------------------------------------------
        private void Bresenham(Point p1, Point p2)
        {
            double od;
            if(p==null)
            p = new Bitmap(pp.Width, pp.Height);
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;

            int swaps = 0;
            if (dy > dx)
            {
                Swap(ref dx, ref dy);
                swaps = 1;
            }
            int a = Math.Abs(dy);
            int b = -Math.Abs(dx);

            double d = 2 * a + b;
            int x = p1.X;
            int y = p1.Y;
            p.SetPixel(Math.Abs(x),Math.Abs(y),Color.Black) ;

            int s = 1;
            int q = 1;
            if (p1.X > p2.X) q = -1;
            if (p1.Y > p2.Y) s = -1;
            od=d;
            for (int k = 0; k < dx; k++)
            {
                if (d >= 0)
                {
                    d = 2 * (a + b) + d;
                    y = y + s;
                    x = x + q;
                }
                else
                {
                    if (swaps == 1) y = y + s;
                    else x = x + q;
                    d = 2 * a + d;
                }
                try
                {
                    p.SetPixel(x, y, Color.Black);
                   row = new ArrayList();
                    row.Add(k.ToString());
                    row.Add(od.ToString());
                    row.Add(d.ToString());
                    row.Add(x.ToString());
                    row.Add(y.ToString());
                    od = d;
                }
                catch
                {

                }
            }

            if (dy < 0 && dx < 0)
                revber(p1, p2);
            cores.Add(new core(p1, p2));
            row = new ArrayList();
            row.Add((cores.Count() + 1).ToString());
            row.Add("///////////////////");
            row.Add("///////////////////");
            row.Add("///////////////////");
            pp.Image=p;
        }
        private void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        private void Swapi(ref Point x, ref Point y)
        {
            Point temp = x;
            x = y;
            y = temp;
        }
        private void revber(Point p1 , Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            Swapi(ref p1,ref p2);
            double derr = Math.Abs(dy/dx);
            double err = derr - .5;
            int y = p1.Y;
            for(int x=p1.X;x<=p2.X;x++)
            {
                p.SetPixel(x, y, Color.Black);
                err += derr;
                if(err>=0)
                {
                    y += 1;
                    err -= 1.0;
                }

            }

        }
        
        //-------------------------------------------------------------------------------------------------------
        //DDA----------------------------------------------------------------------------------------------------
        private void DDA(Point p1,Point p2)
        {
            
           
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double step, xinc, yinc, x = p1.X, y = p1.Y;
            if(Math.Abs(dx)>Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
            {
                step = Math.Abs(dy);
            }

            xinc = dx / step;
            yinc = dy / step;
            for(int i=1;i<=step;i++)
            {
                    row = new ArrayList();
                    row.Add(x.ToString());
                    row.Add(y.ToString());
                    row.Add(Math.Round(x).ToString());
                    row.Add(Math.Round(y).ToString());
                try
                {
                    p.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Black);
                    x = x + xinc;
                    y = y + yinc;
                }
                catch { }
            }
               row = new ArrayList();
                row.Add((cores.Count() + 1).ToString());
                row.Add("///////////////////");
                row.Add("///////////////////");
                row.Add("///////////////////");
            pp.Image = p;
        }
       //-------------------------------------------------------------------------------------------------------
       //circile------------------------------------------------------------------------------------------------
       private  void MidCircle(Point CEN,int radius)
        {
            int k=0, oe;
           // ArrayList row;
            int x=radius;
            int y = 0;
            int err = 0;
            oe = err;
            while (x >= y)
            {
                try
                {
                    p.SetPixel(CEN.X + x, CEN.Y + y, Color.Black);
                    p.SetPixel(CEN.X + y, CEN.Y + x, Color.Black);
                    p.SetPixel(CEN.X - y, CEN.Y + x, Color.Black);
                    p.SetPixel(CEN.X - x, CEN.Y + y, Color.Black);
                    p.SetPixel(CEN.X - x, CEN.Y - y, Color.Black);
                    p.SetPixel(CEN.X - y, CEN.Y - x, Color.Black);
                    p.SetPixel(CEN.X + y, CEN.Y - x, Color.Black);
                    p.SetPixel(CEN.X + x, CEN.Y - y, Color.Black);
                }
                catch { }
                if (err <= 0)
                {
                    y += 1;
                    err += 2 * y + 1;
                }

                if (err > 0)
                {
                    x -= 1;
                    err -= 2 * x + 1;
                }
                row = new ArrayList();
                row.Add((k++).ToString());
                row.Add(oe.ToString());
                row.Add(err.ToString());
                row.Add(x.ToString());
                row.Add(y.ToString());
                oe = err;
            }
            pp.Image = p;
            row = new ArrayList();
            row.Add((cores.Count()+1).ToString());
            row.Add("////////////////////");
            row.Add("////////////////////");
            row.Add("////////////////////");
            row.Add("////////////////////");
        }
       private int calradius(Point CEN, Point p2)
       {
           int x;
           double dx = p2.X - CEN.X;
           double dy = p2.Y - CEN.Y;
           if (Math.Abs(dx) > Math.Abs(dy))
               x = (int)Math.Abs(dx);
           else
               x = (int)Math.Abs(dy);
           return x;
       }
       private Point getmidpoint(Point CEN, Point p2)
       {
           double dx = p2.X + CEN.X;
           double dy = p2.Y + CEN.Y;

           CEN.X =(int) Math.Round(dx / 2);
           CEN.Y = (int) Math.Round(dy / 2);

           return CEN;
       }
       //--------------------------------------------------------------------------------------------------------
       //ellipse-------------------------------------------------------------------------------------------------
       public void ellipse(int Xc=0,int Yc=0 , int Rx=0,int Ry=0)
       {
           int k = 0;
          //ArrayList row;
           Point p1;
           int rx ;
           int ry ;
           int xc ;
           int yc ;
           if ((TX.Text == "X" && TY.Text == "Y")&&rot)
           {
               rx = int.Parse(Interaction.InputBox("x radius", "Input", "", -1, -1));
               ry = int.Parse(Interaction.InputBox("y radius", "Input", "", -1, -1));
              xc = locxy.X; ;
              yc = locxy.Y;
              p1 = locxy;
              p1.X  = rx;
              p1.Y = ry;
              cores.Add(new core(locxy, p1));
           }
           else
           {
                rx = Rx;
                ry = Ry;
                xc = Xc;
                yc = Yc;
           }

           
           int rx2 = rx * rx;
           int ry2 = ry * ry;
           int tworx2 = 2 * rx2;
           int twory2 = 2 * ry2;
           int pe;
           int x = 0, y = ry, px = 0;
           int py = tworx2 * y;
           plot(xc, yc, x, y);
           /*region 1*/
           row = new ArrayList();
           row.Add("region 1");
           row.Add("region 1");
           row.Add("region 1");
           row.Add("region 1");
           row.Add("region 1");
           pe =  Convert.ToInt32( Math.Round(ry2 - (rx2 * ry) + (.25 * rx2)));
           while (px < py)
           {
               x++;
               px += twory2;
               if (pe < 0)
                   pe += ry2 + px;
               else
               {
                   y--;
                   py -= tworx2;
                   pe += ry2 + px - py;
               }
               plot(xc, yc, x, y);
               row = new ArrayList();
               row.Add((k++).ToString());
               row.Add(pe.ToString());
               row.Add("( " + x+ " "+y+ " )");
               row.Add((twory2*x).ToString());
               row.Add((tworx2*y).ToString());
           }
           /*region 2*/
           pe = Convert.ToInt32(Math.Round(ry2 * (x + .5) * (x + .5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2));
           row = new ArrayList();
           row.Add("region 2");
           row.Add("region 2");
           row.Add("region 2");
           row.Add("region 2");
           row.Add("region 2");
           while (y > 0)
           {
               y--;
               py -= tworx2;
               if (pe > 0)
                   pe += rx2 - py;
               else
               {
                   x++;
                   px += twory2;
                   pe += rx2 - py + px;
               }
               plot(xc, yc, x, y);
               row = new ArrayList();
               row.Add((k++).ToString());
               row.Add(pe.ToString());
               row.Add("( " + x + " " + y + " )");
               row.Add((twory2 * x).ToString());
               row.Add((tworx2 * y).ToString());
           }
           pp.Image = p;
           row = new ArrayList();
           row.Add((cores.Count() + 1).ToString());
           row.Add("///////////////////");
           row.Add("///////////////////");
           row.Add("///////////////////");
           row.Add("///////////////////");
       }
       private void plot(int xcen, int ycen, int x, int y)
       {
           try
           {
               p.SetPixel(xcen + x, ycen + y, Color.Black);
               p.SetPixel(Math.Abs(xcen - x), ycen + y, Color.Black);
               p.SetPixel(xcen + x,Math.Abs( ycen - y), Color.Black);
               p.SetPixel(Math.Abs(xcen - x), Math.Abs(ycen - y), Color.Black);
           }
           catch { }
       }
       //---------------------------------------------------------------------------------------------------
       //Rectangle-----------------------------------------------------------------------------------------
       private void Form1_MouseClick(object sender, MouseEventArgs e)
       {
           if (s == '6')
           {
               if (click1)
               {
                   this.Refresh();
                   locxy = e.Location;
                   click2 = true;
                   click1 = false;
               }
               else if (click2)
               {
                   locx1y1 = e.Location;
                   locxy = e.Location;
                   click1 = true;
                   click2 = false;
               }
           }
       }
       private void Form1_MouseMove(object sender, MouseEventArgs e)
       {
           if (click1 && s == '6')
           {
               locx1y1 = e.Location;
               this.Refresh();
           }
       }
       private void Form1_Paint(object sender, PaintEventArgs e)
       {
           if (s == '6' && locxy.X != 0)
           {
               e.Graphics.DrawRectangle(Pens.Black, GetReact());
           }
       }

        private void pp_Click(object sender, EventArgs e)
        {

        }


        private Rectangle GetReact()
       {
           rect = new Rectangle();
           rect.X = Math.Min(locxy.X, locx1y1.X);
           rect.Y = Math.Min(locxy.Y, locx1y1.Y);
           rect.Width = Math.Abs(locxy.X - locx1y1.X);
           rect.Height = Math.Abs(locxy.Y - locx1y1.Y);
           return rect;
       }
       //---------------------------------------------------------------------------------------------------
      
        //translation-------------------------------------------------------------------------------------
        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
       {

           rot = false;
           if(TX.Text!="X"||TY.Text!="Y")
           {
               tx = int.Parse(TX.Text);
               ty = int.Parse(TY.Text)*-1;
               
               p = null;
               p = new Bitmap(pp.Width, pp.Height);
           }

           d = cores.Count();
           for (int i = 0; i < d;i++ )
           {
               cores[i].p1.X =Math.Abs(cores[i].p1.X + tx);
                cores[i].p1.Y = Math.Abs(cores[i].p1.Y + ty);
               if(s!='5')
               { 
               cores[i].p2.X = Math.Abs(cores[i].p2.X + tx);
               cores[i].p2.Y = Math.Abs(cores[i].p2.Y + ty);
               }
               switch (s)
               {
                   case '1':
                   case '0':
                   case '8':
                       DDA(cores[i].p1, cores[i].p2);
                       break;
                   case '2':
                       Bresenham(cores[i].p1, cores[i].p2);
                       break;
                   case '3':
                       MidCircle(cores[i].p1, calradius(cores[i].p1, cores[i].p2));
                       break;
                   case '4':
                       MidCircle(getmidpoint(cores[i].p1, cores[i].p2), calradius(getmidpoint(cores[i].p1, cores[i].p2), cores[i].p2));
                       break;
                   case '5':
                       ellipse(cores[i].p1.X, cores[i].p1.Y, cores[i].p2.X,cores[i].p2.Y);
                       break;
                       
               }
               rot = true;
           }
           TX.Text = "X"; TY.Text = "Y";
           cors();
       }
        //------------------------------------------------------------------------------------------------ 
        //rotation about (0,0)----------------------------------------------------------------------------
        private void sTARTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (angle.Text != "ANGLE")
            {
                
                if(s=='5')
                {
                    ang = double.Parse(angle.Text);
                    ang += preang;
                    preang = ang;
                    sin = Math.Sin((ang * Math.PI) / 180);
                    cos = Math.Cos((ang * Math.PI) / 180);
                    p = new Bitmap(pp.Width, pp.Height);
                }else
                {
                    ang = double.Parse(angle.Text);
                    sin = Math.Sin((ang * Math.PI) / 180);
                    cos = Math.Cos((ang * Math.PI) / 180);
                    p = new Bitmap(pp.Width, pp.Height);
                }

            }
            int x1, x2, y1, y2;
            d = cores.Count();
            for (int i = 0; i < d; i++)
            {
                
                    if (s != '5')
                    {
                        x1 = cores[i].p1.X - newcen.X;
                        y1 = cores[i].p1.Y - newcen.Y;

                        cores[i].p1.X = (int)Math.Round((x1 * cos) + (y1 * sin));
                        cores[i].p1.Y = (int)Math.Round((y1 * cos) - (x1 * sin));
                        x2 = cores[i].p2.X - newcen.X;
                        y2 = cores[i].p2.Y - newcen.Y;
                        cores[i].p2.X = (int)Math.Round((x2 * cos) + (y2 * sin));
                        cores[i].p2.Y = (int)Math.Round((y2 * cos) - (x2 * sin));
                        cores[i].p2.X += newcen.X;
                        cores[i].p2.Y += newcen.Y;
                        cores[i].p1.X += newcen.X;
                        cores[i].p1.Y += newcen.Y;
                    }
                     
                switch (s)
                {
                    case '1':
                    case '8':
                        DDA(cores[i].p1, cores[i].p2);
                        break;
                    case '2':
                        Bresenham(cores[i].p1, cores[i].p2);
                        break;
                    case '3':
                        MidCircle(cores[i].p1, calradius(cores[i].p1, cores[i].p2));
                        break;
                    case '4':
                        MidCircle(getmidpoint(cores[i].p1, cores[i].p2), calradius(getmidpoint(cores[i].p1, cores[i].p2), cores[i].p2));
                        break;
                    case '5':
                        rot = false;
                        ellipserot(cores[i].p1.X, cores[i].p1.Y, cores[i].p2.X, cores[i].p2.Y);
                        break;

                }
                if(s=='0')
                {
                    DDA(cores[i].p1, cores[i].p2);
                }
            }
            dir = false;
            rot = true;
            cors();
        }

        // elipse rotation-------------------------------------------------
        public void ellipserot(int Xc = 0, int Yc = 0, int Rx = 0, int Ry = 0)
        {
            int k = 0;
            //ArrayList row;
            Point p1;
            int rx;
            int ry;
            int xc;
            int yc;
            if ((TX.Text == "X" && TY.Text == "Y") && rot)
            {
                rx = int.Parse(Interaction.InputBox("x radius", "Input", "", -1, -1));
                ry = int.Parse(Interaction.InputBox("y radius", "Input", "", -1, -1));
                xc = locxy.X; ;
                yc = locxy.Y;
                p1 = locxy;
                p1.X = rx;
                p1.Y = ry;
                cores.Add(new core(locxy, p1));
            }
            else
            {
                rx = Rx;
                ry = Ry;
                xc = Xc;
                yc = Yc;
            }


            int rx2 = rx * rx;
            int ry2 = ry * ry;
            int tworx2 = 2 * rx2;
            int twory2 = 2 * ry2;
            int pe;
            int x = 0, y = ry, px = 0;
            int py = tworx2 * y;
            plotrot(xc, yc, x, y);
            /*region 1*/
            row = new ArrayList();
            row.Add("region 1");
            row.Add("region 1");
            row.Add("region 1");
            row.Add("region 1");
            row.Add("region 1");
            pe = Convert.ToInt32(Math.Round(ry2 - (rx2 * ry) + (.25 * rx2)));
            while (px < py)
            {
                x++;
                px += twory2;
                if (pe < 0)
                    pe += ry2 + px;
                else
                {
                    y--;
                    py -= tworx2;
                    pe += ry2 + px - py;
                }
                plotrot(xc, yc, x, y);
                row = new ArrayList();
                row.Add((k++).ToString());
                row.Add(pe.ToString());
                row.Add("( " + x + " " + y + " )");
                row.Add((twory2 * x).ToString());
                row.Add((tworx2 * y).ToString());
            }
            /*region 2*/
            pe = Convert.ToInt32(Math.Round(ry2 * (x + .5) * (x + .5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2));
            row = new ArrayList();
            row.Add("region 2");
            row.Add("region 2");
            row.Add("region 2");
            row.Add("region 2");
            row.Add("region 2");
            while (y > 0)
            {
                y--;
                py -= tworx2;
                if (pe > 0)
                    pe += rx2 - py;
                else
                {
                    x++;
                    px += twory2;
                    pe += rx2 - py + px;
                }
                plotrot(xc, yc, x, y);
                row = new ArrayList();
                row.Add((k++).ToString());
                row.Add(pe.ToString());
                row.Add("( " + x + " " + y + " )");
                row.Add((twory2 * x).ToString());
                row.Add((tworx2 * y).ToString());
            }
            pp.Image = p;
            row = new ArrayList();
            row.Add((cores.Count() + 1).ToString());
            row.Add("///////////////////");
            row.Add("///////////////////");
            row.Add("///////////////////");
            row.Add("///////////////////");
        }
        private void plotrot(int xcen, int ycen, int x, int y)
        {
            int xr, yr;
            try
            {

                xr = xcen + x;
                yr = ycen + y;
                rotate(ref xr, ref yr);
                p.SetPixel(xr, yr, Color.Black);



                xr = Math.Abs(xcen - x);
                yr = ycen + y;
                rotate(ref xr, ref yr);
                p.SetPixel(xr, yr, Color.Black);


                xr = xcen + x;
                yr = Math.Abs(ycen - y);
                rotate(ref xr, ref yr);
                p.SetPixel(xr, yr, Color.Black);


                xr = Math.Abs(xcen - x);
                yr = Math.Abs(ycen - y);
                rotate(ref xr, ref yr);
                p.SetPixel(xr, yr, Color.Black);
            }
            catch { }
        }
        void rotate(ref int x , ref int y)
        {
            int xo, yo, xn, yn;
            xo = x - newcen.X;
            yo = y- newcen.Y;
            xn = (int)Math.Round((xo * cos) + (yo * sin));
            yn = (int)Math.Round((yo * cos) - (xo * sin));
            x =xn+ newcen.X;
            y = yn+newcen.Y;
        }
        //------------------------------------------------------------------------------------------------
        //scaling-----------------------------------------------------------------------------------------
        private void sATRTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rot = false;
            if (SX.Text != "X" || SY.Text != "Y")
            {
                sx = float.Parse(SX.Text);
                sy = float.Parse(SY.Text);
                p = null;
                p = new Bitmap(pp.Width, pp.Height);
            }

            d = cores.Count();
            for (int i = 0; i < d; i++)
            {
                if (s != '5')
                {
                    cores[i].p1.X = (int)Math.Round(cores[i].p1.X * sx);
                    cores[i].p1.Y = (int)Math.Round(cores[i].p1.Y * sy);
                }
               
                    cores[i].p2.X = (int)Math.Round(cores[i].p2.X * sx);
                    cores[i].p2.Y = (int)Math.Round(cores[i].p2.Y * sy);
                switch (s)
                {
                    case '1':
                    case '0':
                    case '8':
                        DDA(cores[i].p1, cores[i].p2);
                        break;
                    case '2':
                        Bresenham(cores[i].p1, cores[i].p2);
                        break;
                    case '3':
                        MidCircle(cores[i].p1, calradius(cores[i].p1, cores[i].p2));
                        break;
                    case '4':
                        MidCircle(getmidpoint(cores[i].p1, cores[i].p2), calradius(getmidpoint(cores[i].p1, cores[i].p2), cores[i].p2));
                        break;
                    case '5':
                        ellipse(cores[i].p1.X, cores[i].p1.Y, cores[i].p2.X, cores[i].p2.Y);
                        break;

                }
                SX.Text = "X"; SY.Text = "Y";
                rot = true;
                cors();
            }
           
        }
        
        private points setcode(Point p1 , Point p2, Point max ,Point min)	//for setting the 4 bit code
        {
            points ptemp =new points();

            if (p1.Y < min.Y)
                ptemp.p1.code[0] = '1';	//Top
            else
                ptemp.p1.code[0] = '0';

            if (p1.Y > max.Y)
                ptemp.p1.code[1] = '1';	//Bottom
            else
                ptemp.p1.code[1] = '0';

            if (p1.X > max.X)
                ptemp.p1.code[2] = '1';	//Right
            else
                ptemp.p1.code[2] = '0';

            if (p1.X < min.X)
                ptemp.p1.code[3] = '1';	//Left
            else
                ptemp.p1.code[3] = '0';

            ptemp.p1.x = p1.X;
            ptemp.p1.y = p1.Y;



            if (p2.Y < min.Y)
                ptemp.p2.code[0] = '1';	//Top
            else
                ptemp.p2.code[0] = '0';

            if (p2.Y > max.Y)
                ptemp.p2.code[1] = '1';	//Bottom
            else
                ptemp.p2.code[1] = '0';

            if (p2.X > max.X)
                ptemp.p2.code[2] = '1';	//Right
            else
                ptemp.p2.code[2] = '0';

            if (p2.X < min.X)
                ptemp.p2.code[3] = '1';	//Left
            else
                ptemp.p2.code[3] = '0';

            ptemp.p2.x = p2.X;
            ptemp.p2.y = p2.Y;
            return (ptemp);
        }
        private int visibility(pointcode p1, pointcode p2)
        {
            int i, flag = 0;

            for (i = 0; i < 4; i++)
            {
                if ((p1.code[i] != '0') || (p2.code[i] != '0'))
                    flag = 1;
            }

            if (flag == 0)
                return (0);

            for (i = 0; i < 4; i++)
            {
                if ((p1.code[i] == p2.code[i]) && (p1.code[i] == '1'))
                    flag = 0;
            }

            if (flag == 0)
                return (1);

            return (2);
        }
        private  pointcode resetendpt(pointcode p1, pointcode p2,Point max , Point min)
        {
            pointcode temp=new pointcode();
            int x=0, y=0, i=0;
            float m=0, k=0;

            if (p1.code[3] == '1')
                x = min.X;

            if (p1.code[2] == '1')
                x = max.X;

            if ((p1.code[3] == '1') || (p1.code[2] == '1'))
            {
                m = (float)(p2.y - p1.y) / (p2.x - p1.x);
                k = (p1.y + (m * (x - p1.x)));
                temp.y = Convert.ToInt32(k);
                temp.x = x;

                for (i = 0; i < 4; i++)
                    temp.code[i] = p1.code[i];

                if (temp.y <= max.Y && temp.y >= min.Y)
                    return (temp);
            }

            if (p1.code[0] == '1')
                y = min.Y;

            if (p1.code[1] == '1')
                y = max.Y;

            if ((p1.code[0] == '1') || (p1.code[1] == '1'))
            {
                m = (float)(p2.y - p1.y) / (p2.x - p1.x);
                k = (float)p1.x + (float)(y - p1.y) / m;
                temp.x = Convert.ToInt32(k);
                temp.y = y;

                for (i = 0; i < 4; i++)
                    temp.code[i] = p1.code[i];

                return (temp);
            }
            else
                return (p1);
        }

      
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = new Bitmap(pp.Width, pp.Height);
            cores.Clear();
            cors();
            row = null;
        }


        private void lINEToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            row=null;
        }

        private void mIDPOINTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            row = null;
        }

        private void tRANSLATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            row = null;
        }

        private void rOTATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            row = null;
        }

        private void sCALINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            row = null;
        }

        private void cENTERPOINTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            s = '3';
        }

        //-----------------------------------------------------------------------------------------------

    }

}