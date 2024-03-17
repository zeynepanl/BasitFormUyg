using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = textBox1.Text;
            Form2 form2 = new Form2(mesaj);
            form2.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox) sender;
            T1.Text=string.Empty;

        }
    }
}
