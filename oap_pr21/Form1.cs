using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oap_pr21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            Form2 Main = this.Owner as Form2;
            if (textBox1.Text != "")

            {
                if (this.radioButton1.Checked == true)
                {
                    Main.listbox1.Items.Add(this.textBox1.Text);
                }

                else Main.listbox2.Items.Add(this.textBox1.Text);

                this.Close();

            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
