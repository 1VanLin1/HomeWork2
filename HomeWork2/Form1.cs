using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void num_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (this.output.Text == "0")
                this.output.Text = button.Text;
            else
                this.output.Text += button.Text;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            math_action('-');
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            math_action('+');
        }

        private void btn_divison_Click(object sender, EventArgs e)
        {
            math_action('/');
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            math_action('*');
        }

        private void math_action(char action)
        {
            this.first_num = (float)System.Convert.ToDouble(this.output.Text);
            this.user_action = action;
            this.output.Text = "0";
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            if (user_action == ' ')
                return;

            float second = (float)System.Convert.ToDouble(this.output.Text);
            float res = 0;

            switch (this.user_action)
            {
                case '+': res = this.first_num + second; break;
                case '-': res = this.first_num - second; break;
                case '*': res = this.first_num * second; break;
                case '/': 
                    if (second != 0)
                        res = this.first_num / second;
                    else MessageBox.Show(this, "На 0 делить нельзя!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    break;
            }

            this.output.Text = System.Convert.ToString(res);
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            this.output.Text = "0";

            this.first_num = 0;
            this.user_action = ' ';
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            string text = this.output.Text;

            if (!text.Contains(","))
                this.output.Text = text + ",";
        }

        private void btn_precent_Click(object sender, EventArgs e)
        {
            first_num = (float)System.Convert.ToDouble(output.Text);
            first_num /= 100;

            this.output.Text = System.Convert.ToString(first_num);
        }
    }
}
