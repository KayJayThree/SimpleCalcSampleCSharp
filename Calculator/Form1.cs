using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultval = 0 ;
        string opt = "";
        bool optperformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        public void disable()
        {
            textBox1.Enabled = false;
            textBox1.Clear();
            label1.Text = "";
            resultval = 0;
            button21.Hide();
            button20.Show();
            button19.Enabled = false;
           
            button18.Enabled = false;
            button17.Enabled = false;
            button16.Enabled = false;
            button15.Enabled = false;
            button14.Enabled = false;
            button13.Enabled = false;
            button12.Enabled = false;
            button11.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
            
        }
        public void enable()
        {
            textBox1.Enabled = true;
            textBox1.Text = "0";
            
            button21.Show();
            button20.Hide();
            button19.Enabled = true;
            button18.Enabled = true;
            button17.Enabled = true;
            button16.Enabled = true;
            button15.Enabled = true;
            button14.Enabled = true;
            button13.Enabled = true;
            button12.Enabled = true;
            button11.Enabled = true;
            button10.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
        }
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.RoyalBlue;
          
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = button4.BackColor;
           
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            button21.BackColor = Color.Red;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button21.BackColor = Color.Teal;
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button20.BackColor = Color.Green;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button20.BackColor = Color.Teal;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(optperformed))
                textBox1.Clear();
            optperformed = false;
            Button button = (Button)sender;
           // textBox1.Text = textBox1.Text + button.Text;
            if (button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else 
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultval != 0)
            {
                button2.PerformClick();
                opt = button.Text;
                label1.Text = resultval + " " + opt;
                optperformed = true;
            }
            else
            {
                opt = button.Text;
                resultval = Double.Parse(textBox1.Text);
                label1.Text = resultval + " " + opt;
                optperformed = true;
            }
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultval = 0;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (opt)
            {
                case "+":
                    textBox1.Text = (resultval +  Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultval -  Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultval *  Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultval /  Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }optperformed = true;
            resultval = Double.Parse(textBox1.Text);
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
               textBox1.Text =textBox1.Text + text[i];
        }
    }
}
