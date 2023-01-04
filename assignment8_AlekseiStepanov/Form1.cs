using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8_AlekseiStepanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List <string> name = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile1, inputFile2;
            inputFile1 = File.OpenText("Cars.txt");
            inputFile2 = File.OpenText("Carsslow.txt");
            while (!inputFile1.EndOfStream)
            {
                name.Add(inputFile1.ReadLine().Trim());
            }
            while (!inputFile2.EndOfStream)
            {
                name.Add(inputFile2.ReadLine().Trim());
            }
            inputFile1.Close();
            inputFile2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                foreach (string name in name)
                {
                    if (textBox1.Text == name)
                    {
                        label3.Text = "Object is in the list.";
                        break;
                    }
                    else
                    {
                        label3.Text = "Object is not in the list.";
                    }
                    
                }
            }
            if (!String.IsNullOrWhiteSpace(textBox2.Text))
            {
                foreach (string name in name)
                {
                    if (textBox2.Text == name)
                    {
                        label4.Text = "Object is in the list.";
                        break;
                    }
                    else
                    {
                        label4.Text = "Object is not in the list.";
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            label4.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
