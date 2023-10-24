using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Form1 : Form
    {
        Automobile auto;
    AutomobileCambioM auto2;
        public Form1()
        {
            InitializeComponent();
            auto = new Automobile();
            auto2 = new AutomobileCambioM();
      
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            string output = auto.AccendiSpegni();
           
            if (auto.Accensione)
            {
                listView1.Items.Add(output);
                button1.BackColor = Color.Green;
            }
            else 
            {

                listView1.Items.Add(output);
                button1.BackColor = Color.Red;
                
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            string output = auto.Accellera();
            if (auto.Accensione)
            {
                listView1.Items.Add(output);
            }
            else
            {
                listView1.Items.Add(output);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string output = auto.Frena();
            if (auto.Accensione)
            {
                listView1.Items.Add(output);
                button3.BackColor = Color.Red;
            }
            else
            {
                listView1.Items.Add(output);
            }
        
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string output = auto.MarciaSu();
            if (auto.Accensione && auto.Velocita == auto.Velcambio)
            {
                listView1.Items.Add(output);
            }
            else
            {
                listView1.Items.Add(output);
            }
        }

		private void button5_Click(object sender, EventArgs e)
		{
      string output = auto.MarciaGiu();
      if(auto.Accensione && auto.Velocita > 0)
      {
        listView1.Items.Add(output);
      }
      else
      {
        listView1.Items.Add(output);
      }
		}

		private void button6_Click(object sender, EventArgs e)
		{
      string output = auto2.AccendiSpegni();
			if (auto.Accensione)
			{
				listView2.Items.Add(output);
			}
			else
			{
				listView2.Items.Add(output);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
      string output = auto2.Acc();
			if (auto.Accensione)
			{
				listView2.Items.Add(output);
			}
			else
			{
				listView2.Items.Add(output);
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
      string output = auto2.F();
      if (auto.Accensione)
			{
				listView2.Items.Add(output);
				button3.BackColor = Color.Red;
			}
			else
			{
				listView2.Items.Add(output);
			}
		}
	}
}
