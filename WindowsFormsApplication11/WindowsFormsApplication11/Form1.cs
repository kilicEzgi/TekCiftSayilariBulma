using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox1.Text);
            int tek = Convert.ToInt32(textBox1.Text);
            int cift = Convert.ToInt32(textBox1.Text);
            
            for (int i = sayi1; i < sayi2; i++)
            {
                if (i % 2 == 0)
                {
                    listBox2.Items.Add(i);
                    cift++;
                }
                else
                {
                    listBox3.Items.Add(i);
                    tek++;
                }

                    
                   
                   
                
                    
            }
        }
    }
        }
    