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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Globals.loginuser = textBox1.Text;
            Globals.permission = MySQLFunctions.FindUser(textBox1.Text,maskedTextBox1.Text);
            if (Globals.permission == -1)
            {
                MessageBox.Show("User name or password do not match", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Globals.permission == 0)
            {
                MessageBox.Show(this,"Logging as user!","Logging in!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else if (Globals.permission == 1)
            {
                MessageBox.Show(this, "Logging as teacher!", "Logging in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else if (Globals.permission == 2)
            {
                MessageBox.Show(this, "Logging as Administrator!", "Logging in!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void maskedTextBox1_TextChanged(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }
    }
}
