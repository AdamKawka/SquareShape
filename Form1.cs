using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareShape { 

    public partial class Form1 : Form
    {
        //initial (d) movement
        int movement = 10;

        public Form1()
        {
            InitializeComponent();
            heightText.Text = panel1.Height.ToString() + "px";
            widthText.Text = panel1.Width.ToString() + "px";
            YLocationText.Text = panel1.Top.ToString() + "px";
            XLocationText.Text = panel1.Left.ToString() + "px";
            groupBoxHeightText.Text = groupBox1.Height.ToString() + "px";
            groupBoxWidthText.Text = groupBox1.Width.ToString() + "px";
            movementText.Text = movement.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //y+
            if (panel1.Height + panel1.Top < groupBox1.Height)
            {
                if(movement < groupBox1.Height-(panel1.Height + panel1.Top))
                {
                    panel1.Height += movement;
                    heightText.Text = panel1.Height.ToString() + "px";
                }
                else
                {
                    MessageBox.Show("too much movement");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //y-
            if (panel1.Height > 10)
            {
                if (movement > 0)
                {
                    panel1.Height -= movement;
                    heightText.Text = panel1.Height.ToString() + "px";
                }
                else
                {
                    MessageBox.Show("not negative plese");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //x-
            if(panel1.Width>10)
            {
                if (movement > 0)
                {
                    panel1.Width -= movement;
                    widthText.Text = panel1.Width.ToString() + "px";
                }
                else
                {
                    MessageBox.Show("not negative please");
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //x+
            if (panel1.Width + panel1.Left < groupBox1.Width )
            {
                if (movement < groupBox1.Width - (panel1.Width + panel1.Left))
                {
                    panel1.Width += movement;
                    widthText.Text = panel1.Width.ToString() + "px";
                }
                else
                {
                    MessageBox.Show("too much movement");
                }
            }  
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            //move up y- !!
            if(panel1.Top > movement)
            {
                panel1.Top -= movement;
                YLocationText.Text = panel1.Top.ToString() + "px";  
            }
            else
            {
                MessageBox.Show("too much movement");
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            //move down y+ !!
            if(panel1.Top + panel1.Height < groupBox1.Height)
            {
                if (movement < groupBox1.Height - (panel1.Height + panel1.Top))
                {
                    panel1.Top += movement;
                    YLocationText.Text = panel1.Top.ToString() + "px";
                }
                else
                {
                    MessageBox.Show("too much movement");
                }
            }
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            //move right x+
            if(panel1.Left + panel1.Width < groupBox1.Width)
            {
                if (movement < groupBox1.Width - (panel1.Width + panel1.Left))
                {
                    panel1.Left += movement;
                    XLocationText.Text = panel1.Left.ToString() + "px";
                }
                else
                {
                    MessageBox.Show("too much movement");
                }
            }
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            //move left x-
            if (panel1.Left >= movement)
            {
                panel1.Left -= movement;
                XLocationText.Text = panel1.Left.ToString() + "px";
            }
            else
            {
                MessageBox.Show("too much movement");
            }
        }

        private void movementText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                movement = int.Parse(movementText.Text);
                MessageBox.Show("movement is equal to: "+movement.ToString()+" px");
                movementText.Text = movement.ToString();
            }
        }
    }
}
