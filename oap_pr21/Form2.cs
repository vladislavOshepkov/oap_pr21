using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oap_pr21
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddd_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 af = new Form1();
            af.Owner = this;
            af.Show();
        }

        public void a_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listbox1.Items.Count > 0)
            {
                listbox2.Items.Add(listbox1.Items[listbox1.Items.Count - 1]);
                listbox1.Items.Remove(listbox1.Items[listbox1.Items.Count - 1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listbox2.Items.Count > 0)
            {
                listbox1.Items.Add(listbox2.Items[listbox2.Items.Count - 1]);
                listbox2.Items.Remove(listbox2.Items[listbox2.Items.Count - 1]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listbox1.Items.Count; i++)
            {
                listbox2.Items.Add(listbox1.Items[i]);
            }
            listbox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listbox2.Items.Count; i++)
            {
                listbox1.Items.Add(listbox2.Items[i]);
            }
            listbox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            for (int i = 0; i < listbox1.Items.Count; i++)
            {
                a.Add(listbox1.Items[i].ToString());
            }
            a.Sort();
            listbox1.Items.Clear();
            for (int i = 0; i < a.Count; i++)
            {
                listbox1.Items.Add(a[i]);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            for (int i = 0; i < listbox2.Items.Count; i++)
            {
                a.Add(listbox2.Items[i].ToString());
            }
            a.Sort();
            listbox2.Items.Clear();
            for (int i = 0; i < a.Count; i++)
            {
                listbox2.Items.Add(a[i]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listbox1.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listbox2.Items.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listbox1.Items.Clear();
            listbox2.Items.Clear();
            listbox3.Items.Clear();
            listbox4.Items.Clear();
            textBox1.Text = string.Empty;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            button9.Visible = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            listbox3.Items.Clear();
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < listbox1.Items.Count; i++)
                {
                    if (listbox1.Items[i].ToString().Contains(textBox1.Text.ToString()))
                    {
                        listbox3.Items.Add(listbox1.Items[i]);
                    }
                }
            }
            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < listbox2.Items.Count; i++)
                {
                    if (listbox2.Items[i].ToString().Contains(textBox1.Text.ToString()))
                    {
                        listbox3.Items.Add(listbox2.Items[i]);
                    }
                }
            }
            textBox1.Text = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                for (int i = 0; i < listbox1.Items.Count; i++)
                {
                    listbox4.Items.Add(listbox1.Items[i]);
                }
                for (int i = 0; i < listbox2.Items.Count; i++)
                {
                    listbox4.Items.Add(listbox2.Items[i]);
                }
            }
            if (radioButton2.Checked == true)
            {
                //Regex regex = new Regex(@"\D+{?}\d+\D+{?}");
                string a = @"\d";
                for (int i = 0; i < listbox1.Items.Count; i++)
                {
                    if (Regex.IsMatch(listbox1.Items[i].ToString(), a))
                    {
                        listbox4.Items.Add(listbox1.Items[i]);
                    }
                }
                for (int i = 0; i < listbox2.Items.Count; i++)
                {
                    if (Regex.IsMatch(listbox2.Items[i].ToString(), a))
                    {
                        listbox4.Items.Add(listbox2.Items[i]);
                    }
                }
            }
            if (radioButton3.Checked == true)
            {
                //Regex regex = new Regex(@"\D+{?}\d+\D+{?}");
                string a = @"^[0-9]+\w+@(mail|gmail|internet|yahoo|bk|yandex|inbox)\.(ru|com)";
                for (int i = 0; i < listbox1.Items.Count; i++)
                {
                    if (Regex.IsMatch(listbox1.Items[i].ToString(), a))
                    {
                        listbox4.Items.Add(listbox1.Items[i]);
                    }
                }
                for (int i = 0; i < listbox2.Items.Count; i++)
                {
                    if (Regex.IsMatch(listbox2.Items[i].ToString(), a))
                    {
                        listbox4.Items.Add(listbox2.Items[i]);
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
        }
    }
}
