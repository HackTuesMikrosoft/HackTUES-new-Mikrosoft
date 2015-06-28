using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackTUES_Windows
{
    public partial class Form2 : Form
    {
        string usr1 = "";
        int prm;

        public Form2()
        {
            InitializeComponent();
            usr1 = textBox50.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: prm = 0; break;
                case 1: prm = 1; break;
                case 2: prm = 2; break;
            }
            MessageBox.Show(textBox50.Text, prm.ToString());
            MySQLFunctions.ChangePerms(textBox50.Text, prm);
            this.Hide();
        }
    }
}
