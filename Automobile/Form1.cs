using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Form1 : Form
    {
        Automobile auto;
        public Form1()
        {
            InitializeComponent();
            auto = new Automobile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           if(checkBox1.Checked == true)
            {
                MessageBox.Show("La macchina è accesa");
            }
            else
            {
                checkBox1.Checked = false;
                MessageBox.Show("La macchina è spenta");
                
            }
          
          
        }
    }
}
