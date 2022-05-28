using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusSchool
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            foreach (Control x in Controls)
            {
                
                if ((string)x.Tag == "Buttom")
                {
                    x.BackColor = Color.Transparent;
                }
                if ((string)x.Tag == "Top")
                {
                    x.BackColor = Color.Transparent;
                }
                if ((string)x.Tag == "Right")
                {
                    x.BackColor = Color.Transparent;
                }
                if ((string)x.Tag == "Left")
                {
                    x.BackColor = Color.Transparent;
                }
            }
            Bus.BackColor = Color.Transparent;
            School.BackColor = Color.Transparent;
            Rocks.BackColor = Color.Transparent;

            int[] xsRocks = { 264, 190, 430, 370 };
            int[] ysRocks = { 6, 360, 391, 2 } ;
            Random randRocks = new Random();
            int idxRocks = randRocks.Next(4);
            Rocks.Left = xsRocks[idxRocks];
            Rocks.Top = ysRocks[idxRocks];

            int[] xsBus = { 920, 920, 920, 920 };
            int[] ysBus = { 15, 212, 303, 433 };
            Random randBus = new Random();
            int idxBus = randBus.Next(4);
            Bus.Left = xsBus[idxBus];
            Bus.Top = ysBus[idxBus];

            int[] xsSchool = { -3, -3, -3, 300 };
            int[] ysSchool = { 96, 285, 460, 505 };
            Random randSchool = new Random();
            int idxSchool = randSchool.Next(4);
            School.Left = xsSchool[idxSchool];
            School.Top = ysSchool[idxSchool];


        }
        bool MoveRight, MoveLeft, MoveUp, MoveDown;
        int Side = 1;//left=1,right=2,up=3,down=4;
        int Dir = 0;
        int speed = 15;

        private void RotateUp(PictureBox Bus)
        {

            if (Side == 1)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 2)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 4)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Width, Bus.Height);
                Flip.RotateFlip(RotateFlipType.Rotate180FlipNone);
                Bus.Image = Flip;
            }
        }
        private void RotateDown(PictureBox Bus)
        {
            if (Side == 1)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 2)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 3)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Width, Bus.Height);
                Flip.RotateFlip(RotateFlipType.Rotate180FlipNone);
                Bus.Image = Flip;
            }
        }
        private void RotateLeft(PictureBox Bus)
        {
            if (Side == 2)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Width, Bus.Height);
                Flip.RotateFlip(RotateFlipType.Rotate180FlipXY);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipX);
                Bus.Image = Flip;
            }
            if (Side == 3)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                Bus.Image = Flip;
            }
            if (Side == 4)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                Bus.Image = Flip;
            }
        }
        private void RotateRight(PictureBox Bus)
        {
            if (Side == 1)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Width, Bus.Height);
                Flip.RotateFlip(RotateFlipType.Rotate180FlipNone);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Bus.Image = Flip;
            }
            if (Side == 3)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate270FlipXY);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);

                Bus.Image = Flip;
            }
            if (Side == 4)
            {
                Image Flip = Bus.Image;
                Bus.Size = new Size(Bus.Height, Bus.Width);
                Flip.RotateFlip(RotateFlipType.Rotate90FlipXY);
                Flip.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Bus.Image = Flip;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                RotateLeft(Bus);
                Side = 1;
                MoveLeft = true;
                Dir = 1;
            }
            if (e.KeyCode == Keys.Right)
            {
                RotateRight(Bus);
                Side = 2;
                MoveRight = true;
                Dir = 2;
            }
            if (e.KeyCode == Keys.Up)
            {
                RotateUp(Bus);
                Side = 3;
                MoveUp = true;
                Dir = 3;
            }
            if (e.KeyCode == Keys.Down)
            {
                RotateDown(Bus);
                Side = 4;
                MoveDown = true;
                Dir = 4;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Dir = 0;
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MoveRight == true)
            {
                Bus.Left += speed;
            }
            if (MoveLeft == true)
            {
                Bus.Left -= speed;
            }
            if (MoveUp == true)
            {
                Bus.Top -= speed;
            }
            if (MoveDown == true)
            {
                Bus.Top += speed;
            }
            foreach (Control x in Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "Buttom")
                    {
                        if (x.Bounds.IntersectsWith(Bus.Bounds))
                        {
                            Bus.Top = x.Top + x.Height;
                        }
                    }
                    if ((string)x.Tag == "Top")
                    {
                        if (x.Bounds.IntersectsWith(Bus.Bounds))
                        {
                            Bus.Top = x.Top - Bus.Height;
                        }
                    }
                    if ((string)x.Tag == "Right")
                    {
                        if (x.Bounds.IntersectsWith(Bus.Bounds))
                        {
                            Bus.Left = x.Left + x.Width;
                        }
                    }
                    if ((string)x.Tag == "Left")
                    {
                        if (x.Bounds.IntersectsWith(Bus.Bounds))
                        {
                            Bus.Left = x.Left - Bus.Width;
                        }
                    }
                }
            }

            foreach (Control x in this.Controls)
            {

                if ((string)x.Tag == "Rocks")
                {
                    if (x.Bounds.IntersectsWith(Bus.Bounds))
                    {
                        timer1.Stop();
                        PictureBox p = new PictureBox();

                        MessageBox.Show("Game Over");
                        Form2 f = new Form2();
                        this.Hide();
                        f.ShowDialog();
                        this.Close();

                    }
                }
            
            }
        }

        
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_COMPOSITED = 0x02000000;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }

    }
}
