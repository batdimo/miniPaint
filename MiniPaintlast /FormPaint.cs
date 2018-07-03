using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class FormPaint : Form
    {
        bool startPaint;
        Graphics g, hn;
        private int initX;
        private int initY;
        bool drawSquare;
        bool drawRectangle;
        bool drawCircle;
        Bitmap bmap;
        public FormPaint()
        {
            InitializeComponent();
            bmap = new Bitmap(pnl_Draw.ClientSize.Width, pnl_Draw.ClientSize.Height);
            g = Graphics.FromImage(bmap);
            //g = pnl_Draw.CreateGraphics();
            pnl_Draw.Invalidate();
        }
        
        
        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;

            if (drawRectangle)
            {
                int x = Math.Min(initX, e.X);
                int y = Math.Min(initY, e.Y);
                int width = Math.Max(initX, e.X) - Math.Min(initX, e.X);
                int height = Math.Max(initY, e.Y) - Math.Min(initY, e.Y);
                Pen dpen = new Pen(btn_PenColor.BackColor, float.Parse(cmb_PenSize.Text));
                pnl_Draw.DrawToBitmap(bmap, new Rectangle(x, y, width, height));
                g.DrawRectangle(dpen, x, y, width, height);
                startPaint = false;
                drawRectangle = false;
            }
            else if (drawSquare)
            {
                int x = Math.Min(initX, e.X);
                int y = Math.Min(initY, e.Y);
                int width =
                    (Math.Max(initX, e.X) - Math.Min(initX, e.X) + Math.Max(initY, e.Y) - Math.Min(initY, e.Y)) / 2;

                Pen dpen = new Pen(btn_PenColor.BackColor, float.Parse(cmb_PenSize.Text));
                pnl_Draw.DrawToBitmap(bmap, new Rectangle(x, y, width, width));
                g.DrawRectangle(dpen, x, y, width, width);
                startPaint = false;
                drawSquare = false;
            }
            else if (drawCircle)
            {
                int x = Math.Min(initX, e.X);
                int y = Math.Min(initY, e.Y);
                int width = Math.Max(initX, e.X) - Math.Min(initX, e.X);
                int height = Math.Max(initY, e.Y) - Math.Min(initY, e.Y);
                Pen dpen = new Pen(btn_PenColor.BackColor, float.Parse(cmb_PenSize.Text));
                g.DrawEllipse(dpen, x, y, width, height);
                startPaint = false;
                drawCircle = false;
            }
        }


        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            initX = e.X;
            initY = e.Y;
        }

        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawRectangle || drawCircle || drawSquare)
            {
                startPaint = false;
            }

            else if (MouseButtons != MouseButtons.None)
            {
                startPaint = true;
                Pen p = new Pen(btn_PenColor.BackColor, float.Parse(cmb_PenSize.Text));
                g.DrawLine(p, new Point(initX, initY), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of btn_PenColor if user click on OK
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btn_PenColor.BackColor = c.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clearing the graphics from the Panel(pnl_Draw)
            g.Clear(pnl_Draw.BackColor);
            //Setting the BackColor of pnl_draw and btn_CanvasColor to White on Clicking New under File Menu
            pnl_Draw.BackColor = Color.White;
            btn_CanvasColor.BackColor = Color.White;
        }

//        private void pnl_Draw_Paint(object sender, PaintEventArgs e)
//        {
//            e.Graphics.DrawImage(bmap, Point.Empty);
//        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new SaveFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                bmap.Save(f.FileName, ImageFormat.Bmp);
            }
        }

        private void btn_CanvasColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pnl_Draw.BackColor = c.Color;
                btn_CanvasColor.BackColor = c.Color;
            }
        }

        private void btn_Square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        //Exit under File Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //About under Help Menu
        private void aboutMiniPaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }
    }
}