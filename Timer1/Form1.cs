using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer1
{
    public partial class Form1 : Form
    {
        int h;
        int m;
        int s;
        int h1;
        int m1;
        int s1;
        int h2;
        int m2;
        int s2;
        int h3;
        int m3;
        int s3;
        int h4;
        int m4;
        int s4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }

            h1 = Convert.ToInt32(textBox1.Text);
            m1 = Convert.ToInt32(textBox2.Text);
            s1 = Convert.ToInt32(textBox3.Text);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (h1 == 0 && m1 == 0 && s1 == 0)
            {
                
                timer1.Stop();
                MessageBox.Show("Time is up!!");
            }
            else { s1 = s1 - 1; }

            if (s1 == -1)
            {
                m1 = m1 - 1;
                s1 = 59;
            }

            if (m1 == -1)
            {
                h1 = h1 - 1;
                m1 = 59;
                
            }

            if (h1 == -1)
            {
                label1.Text = "0";
            }
            //s1 = s1 - 1;

            string hh = Convert.ToString(h1);
            string ss = Convert.ToString(s1);
            string mm = Convert.ToString(m1);

            label1.Text = hh;
            label3.Text = mm;
            label5.Text = ss;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int a = 7 - (Convert.ToInt32(label3.Text) + 1);
            int b = 60 - (Convert.ToInt32(label5.Text));
            if (b == 60)
            {
                a = a + 1;
                b = 00;
            }
            label12.Text = Convert.ToString(a) + "minutes";
            label15.Text = Convert.ToString(b) + "seconds";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }

            h2 = Convert.ToInt32(textBox4.Text);
            m2 = Convert.ToInt32(textBox5.Text);
            s2= Convert.ToInt32(textBox6.Text);

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //s2 = s2 - 1;
            if (h2 == 0 && m2 == 0 && s2 == 0)
            {
                timer2.Stop();
                MessageBox.Show("Time is up!!");
            }
            else { s2 = s2 - 1; }

            if (s2 == -1)
            {
                m2 = m2 - 1;
                s2 = 59;
            }

            if (m2 == -1)
            {
                h2 = h2 - 1;
                m2 = 59;

            }

            if (h2 == -1)
            {
                label6.Text = "0";
            }

            string hh = Convert.ToString(h2);
            string ss = Convert.ToString(s2);
            string mm = Convert.ToString(m2);

            label6.Text = hh;
            label8.Text = mm;
            label10.Text = ss;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            int a = 7 - (Convert.ToInt32(label8.Text) + 1);
            int b = 60 - (Convert.ToInt32(label10.Text));
            if (b == 60)
            {
                a = a + 1;
                b = 00;
            }
            label31.Text = Convert.ToString(a) + "minutes";
            label32.Text = Convert.ToString(b) + "seconds";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }

            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }

            h3 = Convert.ToInt32(textBox7.Text);
            m3 = Convert.ToInt32(textBox8.Text);
            s3 = Convert.ToInt32(textBox9.Text);

            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //s3 = s3 - 1;
            if (h3 == 0 && m3 == 0 && s3 == 0)
            {
                timer3.Stop();
                MessageBox.Show("Time is up!!");
            }
            else { s3 = s3 - 1; }

            if (s3 == -1)
            {
                m3 = m3 - 1;
                s3 = 59;
            }

            if (m3 == -1)
            {
                h3 = h3 - 1;
                m3 = 59;

            }

            if (h3 == -1)
            {
                label16.Text = "0";
            }

            string hh = Convert.ToString(h3);
            string ss = Convert.ToString(s3);
            string mm = Convert.ToString(m3);

            label16.Text = hh;
            label18.Text = mm;
            label20.Text = ss;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            int a = 7 - (Convert.ToInt32(label18.Text) + 1);
            int b = 60 - (Convert.ToInt32(label20.Text));
            if (b == 60)
            {
                a = a + 1;
                b = 00;
            }
            label33.Text = Convert.ToString(a) + "minutes";
            label34.Text = Convert.ToString(b) + "seconds";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //int s = Convert.ToInt32(textBox12.Text);
            if (textBox10.Text == "")
            {
                textBox10.Text = "0";
            }

            if (textBox11.Text == "")
            {
                textBox11.Text = "0";
            }

            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }

            h4 = Convert.ToInt32(textBox10.Text);
            m4 = Convert.ToInt32(textBox11.Text);
            s4 = Convert.ToInt32(textBox12.Text);

            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //s4 = s4 - 1;
            if (h4 == 0 && m4 == 0 && s4 == 0)
            {
                timer4.Stop();
                MessageBox.Show("Time is up!!");
            }
            else { s4 = s4 - 1; }

            if (s4 == -1)
            {
                m4 = m4 - 1;
                s4 = 59;
            }

            if (m4 == -1)
            {
                h4 = h4 - 1;
                m4 = 59;

            }

            if (h4 == -1)
            {
                label23.Text = "0";
            }

            string hh = Convert.ToString(h4);
            string ss = Convert.ToString(s4);
            string mm = Convert.ToString(m4);

            label23.Text = hh;
            label25.Text = mm;
            label27.Text = ss;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer4.Stop();
            int a = 7 - (Convert.ToInt32(label25.Text) + 1);
            int b = 60 - (Convert.ToInt32(label27.Text));
            if (b == 60)
            {
                a = a + 1;
                b = 00;
            }
            label35.Text = Convert.ToString(a) + "minutes";
            label36.Text = Convert.ToString(b) + "seconds";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = SystemColors.Control;
            button3.Enabled = false;
            button3.BackColor = SystemColors.Control;
            button5.Enabled = false;
            button5.BackColor = SystemColors.Control;
            button7.Enabled = false;
            button7.BackColor = SystemColors.Control;
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }

            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }

            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }

            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }

            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }

            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }

            if (textBox10.Text == "")
            {
                textBox10.Text = "0";
            }

            if (textBox11.Text == "")
            {
                textBox11.Text = "0";
            }

            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }


            h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);

            /*timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();*/
            //timer5.Start();
            button1_Click(button9, null);
            button3_Click(button9, null);
            button5_Click(button9, null);
            button7_Click(button9, null);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();*/
            //timer5.Stop();
            //timer4_Tick(button10, null);
            button2_Click(button10, null);
            button4_Click(button10, null);
            button6_Click(button10, null);
            button8_Click(button10, null);
            button1.Enabled = true;
            button1.BackColor = Color.Lime;
            button3.Enabled = true;
            button3.BackColor = Color.Lime;
            button5.Enabled = true;
            button5.BackColor = Color.Lime;
            button7.Enabled = true;
            button7.BackColor = Color.Lime;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (h == 0 && m == 0 && s == 0)
            {
                timer5.Stop();
                MessageBox.Show("Time is up!!");
            }
            else { s = s - 1; }

            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if (m == -1)
            {
                h = h - 1;
                m = 59;

            }

            if (h == -1)
            {
                label1.Text = "0";
                label3.Text = "0";
                label5.Text = "0";
                label6.Text = "0";
                label8.Text = "0";
                label10.Text = "0";
                label16.Text = "0";
                label18.Text = "0";
                label20.Text = "0";
                label23.Text = "0";
                label25.Text = "0";
                label27.Text = "0";

            }

            string hh = Convert.ToString(h);
            string ss = Convert.ToString(s);
            string mm = Convert.ToString(m);

            label23.Text = hh;
            label25.Text = mm;
            label27.Text = ss;
            label1.Text = hh;
            label3.Text = mm;
            label5.Text = ss;
            label6.Text = hh;
            label8.Text = mm;
            label10.Text = ss;
            label16.Text = hh;
            label18.Text = mm;
            label20.Text = ss;
            label23.Text = hh;
            label25.Text = mm;
            label27.Text = ss;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
