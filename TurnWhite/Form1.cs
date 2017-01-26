using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnWhite
{
    public partial class Form1 : Form
    {
        bool condition = false;
        

        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartB_Click(object sender, EventArgs e)
        {
            StartBox.Visible = false;
            GameBox.Visible = true;
        }

        private void exB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK) Application.Exit();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            if ( button1.BackColor.Equals(Color.White))
            button1.BackColor = System.Drawing.Color.Black;
            else if (button1.BackColor.Equals(Color.Black))
                button1.BackColor = System.Drawing.Color.White;
            if (button2.BackColor.Equals(Color.White))
                button2.BackColor = System.Drawing.Color.Black;
            else if (button2.BackColor.Equals(Color.Black))
                button2.BackColor = System.Drawing.Color.White;
            if (button5.BackColor.Equals(Color.White))
                button5.BackColor = System.Drawing.Color.Black;
            else if (button5.BackColor.Equals(Color.Black))
                button5.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
             && (button2.BackColor.Equals(Color.Black))
             && (button3.BackColor.Equals(Color.Black))
             && (button3.BackColor.Equals(Color.Black))
             && (button4.BackColor.Equals(Color.Black))
             && (button5.BackColor.Equals(Color.Black))
             && (button6.BackColor.Equals(Color.Black))
             && (button7.BackColor.Equals(Color.Black))
             && (button8.BackColor.Equals(Color.Black))
             && (button9.BackColor.Equals(Color.Black))
             && (button10.BackColor.Equals(Color.Black))
             && (button11.BackColor.Equals(Color.Black))
             && (button12.BackColor.Equals(Color.Black))
             && (button13.BackColor.Equals(Color.Black))
             && (button14.BackColor.Equals(Color.Black))
             && (button15.BackColor.Equals(Color.Black))
             && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.BackColor.Equals(Color.White))
                button1.BackColor = System.Drawing.Color.Black;
            else if (button1.BackColor.Equals(Color.Black))
                button1.BackColor = System.Drawing.Color.White;
            if (button2.BackColor.Equals(Color.White))
                button2.BackColor = System.Drawing.Color.Black;
            else if (button2.BackColor.Equals(Color.Black))
                button2.BackColor = System.Drawing.Color.White;
            if (button3.BackColor.Equals(Color.White))
                button3.BackColor = System.Drawing.Color.Black;
            else if (button3.BackColor.Equals(Color.Black))
                button3.BackColor = System.Drawing.Color.White;
            if (button6.BackColor.Equals(Color.White))
                button6.BackColor = System.Drawing.Color.Black;
            else if (button6.BackColor.Equals(Color.Black))
                button6.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.BackColor.Equals(Color.White))
                button2.BackColor = System.Drawing.Color.Black;
            else if (button2.BackColor.Equals(Color.Black))
                button2.BackColor = System.Drawing.Color.White;
            if (button3.BackColor.Equals(Color.White))
                button3.BackColor = System.Drawing.Color.Black;
            else if (button3.BackColor.Equals(Color.Black))
                button3.BackColor = System.Drawing.Color.White;
            if (button4.BackColor.Equals(Color.White))
                button4.BackColor = System.Drawing.Color.Black;
            else if (button4.BackColor.Equals(Color.Black))
                button4.BackColor = System.Drawing.Color.White;
            if (button7.BackColor.Equals(Color.White))
                button7.BackColor = System.Drawing.Color.Black;
            else if (button7.BackColor.Equals(Color.Black))
                button7.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (button3.BackColor.Equals(Color.White))
                button3.BackColor = System.Drawing.Color.Black;
            else if (button3.BackColor.Equals(Color.Black))
                button3.BackColor = System.Drawing.Color.White;
            if (button4.BackColor.Equals(Color.White))
                button4.BackColor = System.Drawing.Color.Black;
            else if (button4.BackColor.Equals(Color.Black))
                button4.BackColor = System.Drawing.Color.White;
            if (button8.BackColor.Equals(Color.White))
                button8.BackColor = System.Drawing.Color.Black;
            else if (button8.BackColor.Equals(Color.Black))
                button8.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            if (button5.BackColor.Equals(Color.White))
                button5.BackColor = System.Drawing.Color.Black;
            else if (button5.BackColor.Equals(Color.Black))
                button5.BackColor = System.Drawing.Color.White;
            if (button1.BackColor.Equals(Color.White))
                button1.BackColor = System.Drawing.Color.Black;
            else if (button1.BackColor.Equals(Color.Black))
                button1.BackColor = System.Drawing.Color.White;
            if (button6.BackColor.Equals(Color.White))
                button6.BackColor = System.Drawing.Color.Black;
            else if (button6.BackColor.Equals(Color.Black))
                button6.BackColor = System.Drawing.Color.White;
            if (button9.BackColor.Equals(Color.White))
                button9.BackColor = System.Drawing.Color.Black;
            else if (button9.BackColor.Equals(Color.Black))
                button9.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.BackColor.Equals(Color.White))
                button2.BackColor = System.Drawing.Color.Black;
            else if (button2.BackColor.Equals(Color.Black))
                button2.BackColor = System.Drawing.Color.White;
            if (button5.BackColor.Equals(Color.White))
                button5.BackColor = System.Drawing.Color.Black;
            else if (button5.BackColor.Equals(Color.Black))
                button5.BackColor = System.Drawing.Color.White;
            if (button6.BackColor.Equals(Color.White))
                button6.BackColor = System.Drawing.Color.Black;
            else if (button6.BackColor.Equals(Color.Black))
                button6.BackColor = System.Drawing.Color.White;
            if (button7.BackColor.Equals(Color.White))
                button7.BackColor = System.Drawing.Color.Black;
            else if (button7.BackColor.Equals(Color.Black))
                button7.BackColor = System.Drawing.Color.White;
            if (button10.BackColor.Equals(Color.White))
                button10.BackColor = System.Drawing.Color.Black;
            else if (button10.BackColor.Equals(Color.Black))
                button10.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.BackColor.Equals(Color.White))
                button3.BackColor = System.Drawing.Color.Black;
            else if (button3.BackColor.Equals(Color.Black))
                button3.BackColor = System.Drawing.Color.White;
            if (button6.BackColor.Equals(Color.White))
                button6.BackColor = System.Drawing.Color.Black;
            else if (button6.BackColor.Equals(Color.Black))
                button6.BackColor = System.Drawing.Color.White;
            if (button7.BackColor.Equals(Color.White))
                button7.BackColor = System.Drawing.Color.Black;
            else if (button7.BackColor.Equals(Color.Black))
                button7.BackColor = System.Drawing.Color.White;
            if (button8.BackColor.Equals(Color.White))
                button8.BackColor = System.Drawing.Color.Black;
            else if (button8.BackColor.Equals(Color.Black))
                button8.BackColor = System.Drawing.Color.White;
            if (button11.BackColor.Equals(Color.White))
                button11.BackColor = System.Drawing.Color.Black;
            else if (button11.BackColor.Equals(Color.Black))
                button11.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button4.BackColor.Equals(Color.White))
                button4.BackColor = System.Drawing.Color.Black;
            else if (button4.BackColor.Equals(Color.Black))
                button4.BackColor = System.Drawing.Color.White;
            if (button7.BackColor.Equals(Color.White))
                button7.BackColor = System.Drawing.Color.Black;
            else if (button7.BackColor.Equals(Color.Black))
                button7.BackColor = System.Drawing.Color.White;
            if (button8.BackColor.Equals(Color.White))
                button8.BackColor = System.Drawing.Color.Black;
            else if (button8.BackColor.Equals(Color.Black))
                button8.BackColor = System.Drawing.Color.White;
            if (button12.BackColor.Equals(Color.White))
                button12.BackColor = System.Drawing.Color.Black;
            else if (button12.BackColor.Equals(Color.Black))
                button12.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button5.BackColor.Equals(Color.White))
                button5.BackColor = System.Drawing.Color.Black;
            else if (button5.BackColor.Equals(Color.Black))
                button5.BackColor = System.Drawing.Color.White;
            if (button9.BackColor.Equals(Color.White))
                button9.BackColor = System.Drawing.Color.Black;
            else if (button9.BackColor.Equals(Color.Black))
                button9.BackColor = System.Drawing.Color.White;
            if (button10.BackColor.Equals(Color.White))
                button10.BackColor = System.Drawing.Color.Black;
            else if (button10.BackColor.Equals(Color.Black))
                button10.BackColor = System.Drawing.Color.White;
            if (button13.BackColor.Equals(Color.White))
                button13.BackColor = System.Drawing.Color.Black;
            else if (button13.BackColor.Equals(Color.Black))
                button13.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button6.BackColor.Equals(Color.White))
                button6.BackColor = System.Drawing.Color.Black;
            else if (button6.BackColor.Equals(Color.Black))
                button6.BackColor = System.Drawing.Color.White;
            if (button9.BackColor.Equals(Color.White))
                button9.BackColor = System.Drawing.Color.Black;
            else if (button9.BackColor.Equals(Color.Black))
                button9.BackColor = System.Drawing.Color.White;
            if (button10.BackColor.Equals(Color.White))
                button10.BackColor = System.Drawing.Color.Black;
            else if (button10.BackColor.Equals(Color.Black))
                button10.BackColor = System.Drawing.Color.White;
            if (button11.BackColor.Equals(Color.White))
                button11.BackColor = System.Drawing.Color.Black;
            else if (button11.BackColor.Equals(Color.Black))
                button11.BackColor = System.Drawing.Color.White;
            if (button14.BackColor.Equals(Color.White))
                button14.BackColor = System.Drawing.Color.Black;
            else if (button14.BackColor.Equals(Color.Black))
                button14.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button7.BackColor.Equals(Color.White))
                button7.BackColor = System.Drawing.Color.Black;
            else if (button7.BackColor.Equals(Color.Black))
                button7.BackColor = System.Drawing.Color.White;
            if (button10.BackColor.Equals(Color.White))
                button10.BackColor = System.Drawing.Color.Black;
            else if (button10.BackColor.Equals(Color.Black))
                button10.BackColor = System.Drawing.Color.White;
            if (button11.BackColor.Equals(Color.White))
                button11.BackColor = System.Drawing.Color.Black;
            else if (button11.BackColor.Equals(Color.Black))
                button11.BackColor = System.Drawing.Color.White;
            if (button12.BackColor.Equals(Color.White))
                button12.BackColor = System.Drawing.Color.Black;
            else if (button12.BackColor.Equals(Color.Black))
                button12.BackColor = System.Drawing.Color.White;
            if (button15.BackColor.Equals(Color.White))
                button15.BackColor = System.Drawing.Color.Black;
            else if (button15.BackColor.Equals(Color.Black))
                button15.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button8.BackColor.Equals(Color.White))
                button8.BackColor = System.Drawing.Color.Black;
            else if (button8.BackColor.Equals(Color.Black))
                button8.BackColor = System.Drawing.Color.White;
            if (button11.BackColor.Equals(Color.White))
                button11.BackColor = System.Drawing.Color.Black;
            else if (button11.BackColor.Equals(Color.Black))
                button11.BackColor = System.Drawing.Color.White;
            if (button12.BackColor.Equals(Color.White))
                button12.BackColor = System.Drawing.Color.Black;
            else if (button12.BackColor.Equals(Color.Black))
                button12.BackColor = System.Drawing.Color.White;
            if (button16.BackColor.Equals(Color.White))
                button16.BackColor = System.Drawing.Color.Black;
            else if (button16.BackColor.Equals(Color.Black))
                button16.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button9.BackColor.Equals(Color.White))
                button9.BackColor = System.Drawing.Color.Black;
            else if (button9.BackColor.Equals(Color.Black))
                button9.BackColor = System.Drawing.Color.White;
            if (button13.BackColor.Equals(Color.White))
                button13.BackColor = System.Drawing.Color.Black;
            else if (button13.BackColor.Equals(Color.Black))
                button13.BackColor = System.Drawing.Color.White;
            if (button14.BackColor.Equals(Color.White))
                button14.BackColor = System.Drawing.Color.Black;
            else if (button14.BackColor.Equals(Color.Black))
                button14.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button10.BackColor.Equals(Color.White))
                button10.BackColor = System.Drawing.Color.Black;
            else if (button10.BackColor.Equals(Color.Black))
                button10.BackColor = System.Drawing.Color.White;
            if (button13.BackColor.Equals(Color.White))
                button13.BackColor = System.Drawing.Color.Black;
            else if (button13.BackColor.Equals(Color.Black))
                button13.BackColor = System.Drawing.Color.White;
            if (button14.BackColor.Equals(Color.White))
                button14.BackColor = System.Drawing.Color.Black;
            else if (button14.BackColor.Equals(Color.Black))
                button14.BackColor = System.Drawing.Color.White;
            if (button15.BackColor.Equals(Color.White))
                button15.BackColor = System.Drawing.Color.Black;
            else if (button15.BackColor.Equals(Color.Black))
                button15.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button11.BackColor.Equals(Color.White))
                button11.BackColor = System.Drawing.Color.Black;
            else if (button11.BackColor.Equals(Color.Black))
                button11.BackColor = System.Drawing.Color.White;
            if (button14.BackColor.Equals(Color.White))
                button14.BackColor = System.Drawing.Color.Black;
            else if (button14.BackColor.Equals(Color.Black))
                button14.BackColor = System.Drawing.Color.White;
            if (button15.BackColor.Equals(Color.White))
                button15.BackColor = System.Drawing.Color.Black;
            else if (button15.BackColor.Equals(Color.Black))
                button15.BackColor = System.Drawing.Color.White;
            if (button16.BackColor.Equals(Color.White))
                button16.BackColor = System.Drawing.Color.Black;
            else if (button16.BackColor.Equals(Color.Black))
                button16.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button12.BackColor.Equals(Color.White))
                button12.BackColor = System.Drawing.Color.Black;
            else if (button12.BackColor.Equals(Color.Black))
                button12.BackColor = System.Drawing.Color.White;
            if (button15.BackColor.Equals(Color.White))
                button15.BackColor = System.Drawing.Color.Black;
            else if (button15.BackColor.Equals(Color.Black))
                button15.BackColor = System.Drawing.Color.White;
            if (button16.BackColor.Equals(Color.White))
                button16.BackColor = System.Drawing.Color.Black;
            else if (button16.BackColor.Equals(Color.Black))
                button16.BackColor = System.Drawing.Color.White;
            counter++;
            label1.Text = counter.ToString();
            if ((button1.BackColor.Equals(Color.Black))
            && (button2.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button3.BackColor.Equals(Color.Black))
            && (button4.BackColor.Equals(Color.Black))
            && (button5.BackColor.Equals(Color.Black))
            && (button6.BackColor.Equals(Color.Black))
            && (button7.BackColor.Equals(Color.Black))
            && (button8.BackColor.Equals(Color.Black))
            && (button9.BackColor.Equals(Color.Black))
            && (button10.BackColor.Equals(Color.Black))
            && (button11.BackColor.Equals(Color.Black))
            && (button12.BackColor.Equals(Color.Black))
            && (button13.BackColor.Equals(Color.Black))
            && (button14.BackColor.Equals(Color.Black))
            && (button15.BackColor.Equals(Color.Black))
            && (button16.BackColor.Equals(Color.Black))) condition = true;
            if (condition == true)
            {
                MessageBox.Show("Congratulations!\n You've won!", "You win!", MessageBoxButtons.OK);
                condition = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;
            }
        }
    

        private void menRet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to end game and return to main menu?", "End game", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                StartBox.Visible = true;
                //GameBox.Visible = false;
                counter = 0;
                label1.Text = counter.ToString();
                button1.BackColor = System.Drawing.Color.White;
                button2.BackColor = System.Drawing.Color.White;
                button3.BackColor = System.Drawing.Color.White;
                button4.BackColor = System.Drawing.Color.White;
                button5.BackColor = System.Drawing.Color.White;
                button6.BackColor = System.Drawing.Color.White;
                button7.BackColor = System.Drawing.Color.White;
                button8.BackColor = System.Drawing.Color.White;
                button9.BackColor = System.Drawing.Color.White;
                button10.BackColor = System.Drawing.Color.White;
                button11.BackColor = System.Drawing.Color.White;
                button12.BackColor = System.Drawing.Color.White;
                button13.BackColor = System.Drawing.Color.White;
                button14.BackColor = System.Drawing.Color.White;
                button15.BackColor = System.Drawing.Color.White;
                button16.BackColor = System.Drawing.Color.White;

            }
        }

        private void topTen_Click(object sender, EventArgs e)
        {
            TopForm _topForm = new TopForm();
            _topForm.Show();
        }

        private void StartBox_Enter(object sender, EventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
            counter = 0;
            label1.Text = counter.ToString();
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            button10.BackColor = System.Drawing.Color.White;
            button11.BackColor = System.Drawing.Color.White;
            button12.BackColor = System.Drawing.Color.White;
            button13.BackColor = System.Drawing.Color.White;
            button14.BackColor = System.Drawing.Color.White;
            button15.BackColor = System.Drawing.Color.White;
            button16.BackColor = System.Drawing.Color.White;
        }

        private void instrB_Click(object sender, EventArgs e)
        {
            Instructions _instrForm = new Instructions();
            _instrForm.Show();
        }
    }
}
