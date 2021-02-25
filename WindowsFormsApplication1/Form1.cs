using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;




namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {

       // Graphics g;
        Pen p = new Pen(Color.Black, 90);
       // Point sp = new Point(0, 0);
       // Point ep = new Point(0, 0);
       // int k = 0;
        //Color tia;
        //bool choose = false;
        bool draw = false;
        int x, y, lx, ly = 0;
        Item curritem;


        public Form1()
        {
            InitializeComponent();
        }
        public enum Item
        {
            Rectangle, Ellipse, Line, Text, Brush, Pencil, Eraser, Colerpicker
        }

        
 

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] family = FontFamily.Families;
            foreach (FontFamily font in family)
            {
                toolStripComboBox1.Items.Add(font.GetName(1).ToString());

            }
        }
         
        private void dimgray_Click(object sender, EventArgs e)
        {
            p.Color = dimgray.BackColor;
            black.BackColor = dimgray.BackColor;
        }
         
        private void form1_mousedown(object sender, MouseEventArgs e)
        {
            /*sp = e.Location;
            if (e.Button == MouseButtons.Left)
                k = 1;*/
        }

        private void form1_mousemove(object sender, MouseEventArgs e)
        {
           /* if (k == 1)
            {
                ep = e.Location;
                g = this.CreateGraphics();
                g.DrawLine(p, sp, ep);
            }
            1sp = ep;*/
        }

        private void form1_mouseup(object sender, MouseEventArgs e)
        {
          //  k = 0;

        }

        private void lightcoral_Click(object sender, EventArgs e)
        {
            p.Color = lightcoral.BackColor;
            btnchoise.BackColor = lightcoral.BackColor;

        }

        private void black_Click(object sender, EventArgs e)
        {
            p.Color = black.BackColor;
            btnchoise.BackColor = black.BackColor;

        }

        private void gray_Click(object sender, EventArgs e)
        {
            p.Color = gray.BackColor;
            btnchoise.BackColor = gray.BackColor;
        }

        private void brown_Click(object sender, EventArgs e)
        {
            p.Color = brown.BackColor;
            btnchoise.BackColor = black.BackColor;
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            p.Color = yellow.BackColor;
            btnchoise.BackColor = yellow.BackColor;
            

        }

        private void lightyellow_Click(object sender, EventArgs e)
        {
            p.Color = lightyellow.BackColor;
            btnchoise.BackColor = black.BackColor;

        }

        private void green_Click(object sender, EventArgs e)
        {
            p.Color = green.BackColor;
        }

        private void darkblue_Click(object sender, EventArgs e)
        {
            p.Color = darkblue.BackColor;
            btnchoise.BackColor = darkblue.BackColor;

        }

        private void skyblue_Click(object sender, EventArgs e)
        {
            p.Color = skyblue.BackColor;
            btnchoise.BackColor = skyblue.BackColor;

        }

        private void white_Click(object sender, EventArgs e)
        {
            p.Color = white.BackColor;
            btnchoise.BackColor = white.BackColor;
        }

        private void silver_Click(object sender, EventArgs e)
        {
            p.Color = silver.BackColor;
            btnchoise.BackColor = silver.BackColor;
        }

        private void maroon_Click(object sender, EventArgs e)
        {
            p.Color = maroon.BackColor;
            btnchoise.BackColor = maroon.BackColor;

        }

        private void red_Click(object sender, EventArgs e)
        {
            p.Color = red.BackColor;
            btnchoise.BackColor = red.BackColor;

        }

        private void orange_Click(object sender, EventArgs e)
        {
            p.Color = orange.BackColor;
            btnchoise.BackColor = orange.BackColor;
        }

        private void lightorange_Click(object sender, EventArgs e)
        {
            p.Color = lightorange.BackColor;
            btnchoise.BackColor = lightorange.BackColor;
        }

        private void lightpink_Click(object sender, EventArgs e)
        {
            p.Color = lightpink.BackColor;
            btnchoise.BackColor = lightpink.BackColor;
        }

        private void lightgreen_Click(object sender, EventArgs e)
        {
            p.Color = lightgreen.BackColor;
            btnchoise.BackColor = lightgreen.BackColor;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            p.Color = blue.BackColor;
            btnchoise.BackColor = blue.BackColor;
        }

        private void purple_Click(object sender, EventArgs e)
        {
            p.Color = purple.BackColor;
            btnchoise.BackColor = purple.BackColor;
        }

        private void pink_Click(object sender, EventArgs e)
        {
            p.Color = pink.BackColor;
            btnchoise.BackColor = pink.BackColor;
        }

        private void lightblue_Click(object sender, EventArgs e)
        {
            p.Color = lightblue.BackColor;
        }

        private void lightpurple_Click(object sender, EventArgs e)
        {
            p.Color = lightpurple.BackColor;
            btnchoise.BackColor = lightpurple.BackColor;
        }

        private void parrot_Click(object sender, EventArgs e)
        {
            p.Color = parrot.BackColor;
            btnchoise.BackColor = parrot.BackColor;
        }

        private void mahendi_Click(object sender, EventArgs e)
        {
            p.Color = mahendi.BackColor;
            btnchoise.BackColor = mahendi.BackColor;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            p.Color = firebrick.BackColor;
            btnchoise.BackColor = firebrick.BackColor;
           
        }

        private void slategray_Click(object sender, EventArgs e)
        {
            p.Color = slategray.BackColor;
            btnchoise.BackColor = slategray.BackColor;
        }

        private void indianred_Click(object sender, EventArgs e)
        {
            p.Color = indianred.BackColor;
            btnchoise.BackColor = indianred.BackColor;
        }

        private void rosybrown_Click(object sender, EventArgs e)
        {
            p.Color = rosybrown.BackColor;
            btnchoise.BackColor = rosybrown.BackColor;
        }

        private void saddlebrown_Click(object sender, EventArgs e)
        {
            p.Color = saddlebrown.BackColor;
            btnchoise.BackColor = saddlebrown.BackColor;
        }

         

       

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // Form2 new1 = new Form2();
           // new1.Show();
            pictureBox1.Refresh();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter="Png files|*.png|jpeg files|*.jpg|bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }

                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
             
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Png files|*.png|jpeg files|*.jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = (Image)Image.FromFile(o.FileName).Clone();
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* Graphics g1 = pictureBox1.CreateGraphics();
            g1.Clear(pictureBox1.BackColor);*/
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            curritem = Item.Line;
        }

        private void picturebox1_mousemove(object sender, MouseEventArgs e)
        {
           

            if (draw)
            {
                Graphics g = pictureBox1.CreateGraphics();
                switch (curritem)
                {
                    case Item.Rectangle:
                        g.FillRectangle(new SolidBrush(btnchoise.BackColor), x, y, e.X - x, e.Y - y);
                        break;
                    case Item.Ellipse:
                        g.FillEllipse(new SolidBrush(btnchoise.BackColor), x, y, e.X - x, e.Y - y);
                        break;
                    case Item.Brush:
                        g.FillEllipse(new SolidBrush(btnchoise.BackColor), e.X - x+x, e.Y - y+y,Convert.ToInt32(toolStripTextBox1.Text),Convert.ToInt32(toolStripTextBox1.Text));
                        break;
                    case Item.Pencil:
                        g.FillEllipse(new SolidBrush(btnchoise.BackColor), e.X - x+x, e.Y - y+y,5,5);
                        break;
                    case Item.Eraser:
                        g.FillEllipse(new SolidBrush(pictureBox1.BackColor), e.X - x + x, e.Y - y + y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                        break;


               } 
                g.Dispose();
            }
        }

        private void picturebox1_mousedown(object sender, MouseEventArgs e)
        {
            draw = false;
            lx = e.X;
            ly = e.Y;
        }

        private void picturebox1_mouseup(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
            if (curritem == Item.Line)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(new Pen(new SolidBrush(btnchoise.BackColor)), new Point(x, y), new Point(lx, ly));
                g.Dispose();
            }

        }
         

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            curritem = Item.Rectangle;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            curritem = Item.Ellipse;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            curritem = Item.Brush;
        }

         
        private void ovalShape3_Click(object sender, EventArgs e)
        {
            curritem = Item.Ellipse;
        }

         

        
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            curritem = Item.Pencil;
           
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            curritem = Item.Eraser;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            curritem = Item.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
      
    }
}
