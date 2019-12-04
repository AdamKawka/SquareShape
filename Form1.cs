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
            //fill textboxes at the beginning
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
            // y+ add more height 
            //
            // we cannot make our square bigger than groupbox
            //
            // if square's height + its space between 0 and actual position 
            // is smaller than whole groupbox's height....
            if (panel1.Height + panel1.Top < groupBox1.Height)
            {
                // ....AND if the movement value is smaller than actual free space
                if(movement < groupBox1.Height-(panel1.Height + panel1.Top))
                {
                    // we can add more height 
                    panel1.Height += movement;
                    // and display it on 
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
            // y- adjust some height
            //
            // it's simple, we cannot go less than 0
            if (panel1.Height > 0)
            {
                // and we don't wanna movement with negative values, because why
                if (movement > 0)
                {
                    //let's adjust
                    panel1.Height -= movement;
                    //and display
                    heightText.Text = panel1.Height.ToString() + "px";
                }
                else
                {
                    MessageBox.Show("not negative please");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // x-
            // the same as Y schema
            if(panel1.Width>0)
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
            //
            // if we want to go up, we need to adjust the top value
            // so, IF the top position is bigger than movement value
            // (we prevent goin out of the groupbox)
            if(panel1.Top > movement)
            {
                // we are adjustin
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
            // move down y+ !!
            //
            // going down is a bit complicated, top position of square + its height had to be..
            // ..less than groupbox's height, Why?
            // we need free space to move down
            if(panel1.Top + panel1.Height < groupBox1.Height)
            {
                // we checked if there's free space, so now we have to check our movement value
                // it cannot exceed this free space
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
            //same schema
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
            //again
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
            // after push and release of ENTER key..
            if (e.KeyChar == (char)Keys.Enter)
            {
                // we change initial movement value to value given
                movement = int.Parse(movementText.Text);
                // let's show some message
                MessageBox.Show("movement is equal to: "+movement.ToString()+" px");
                // and display it
                movementText.Text = movement.ToString();
            }
        }
    }
}
