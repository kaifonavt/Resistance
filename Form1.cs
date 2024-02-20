using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resistance
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { float r3;
            if ((textBox1.Text == null) ^ (textBox2.Text == null)) { MessageBox.Show("Error", "Enter all data"); } else 
            { 
                float r1 = Convert.ToInt32(textBox2.Text);
                float r2 = Convert.ToInt32(textBox3.Text);
                if (radioButton1.Checked) { r3 = r1 + r2; }
                else { r3 = (r1*r2)/(r1+r2); }
                textBox4.Text = r3.ToString();
                textBox2.Text = "";
                textBox3.Text = "";
            }
            
        }
    }
}
