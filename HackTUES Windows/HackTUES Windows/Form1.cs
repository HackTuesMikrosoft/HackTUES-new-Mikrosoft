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
    public partial class Form1 : Form
    {
        int klas;
        string type;
        string site = "http://localhost:12345/";
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Hide();
            button19.Hide();
            button20.Hide();
            textBox1.Hide();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser2.ScriptErrorsSuppressed = true;
            webBrowser2.Navigate(site + "News/index.html");
            /*switch (Globals.permission)
            {
                case 0: label9.Text = "Ученик";
                case 1: label9.Text = "Учител";
                case 2: label9.Text = "Администратор";
                default: label9.Text = "Неизвестно";
            }
            if (Globals.permission == 2)
            {
                button21.Show();
                button21.Enable();
            }
            else
            {
                button21.Hide();
                button21.Disable();
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/math.html");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/en.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/programing.html");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/bg.html");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/Logic.html");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/el_measurements.html");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/el_elements.html");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/el_circuits.html");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/history.html");

        }

        private void button10_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/chemistry.html");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/physics.html");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/info_tech.html");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/tech_drawing.html");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/informatic.html");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/sports.html");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/geo.html");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            hid();
            webBrowser1.Navigate(site + "Materials/bio.html");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        public void hid()
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Show();
            //button20.Show();
            //textBox1.Show();
            webBrowser1.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            webBrowser1.Hide();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
            button17.Show();
            button18.Show();
            button19.Hide();
            //button20.Hide();
            //textBox1.Hide();

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoSearch();
        }

        private void button21_Click(object sender, EventArgs e)
        {

            Form2 frm2 = new Form2();
            frm2.Show();
            if (Globals.permission < 1) MessageBox.Show("You don't have the permissions to do this.");


        }

        private void Class8_Click(object sender, EventArgs e)
        {
            klas = 8;
            Class12.Hide();
            Class10.Hide();
            Class11.Hide();
            Class9.Hide();
            button22.Show();
            BClass.Show();
            DClass.Show();
            CClass.Show();
            button23.Show();
            button23.Enabled = true;
            button22.Enabled = true;
            BClass.Enabled = true;
            CClass.Enabled = true;
            DClass.Enabled = true;
        
        }

        private void Class10_Click(object sender, EventArgs e)
        {
            klas = 10;
            Class12.Hide();
            Class8.Hide();
            Class11.Hide();
            Class9.Hide();
            button22.Show();
            BClass.Show();
            DClass.Show();
            CClass.Show();
            button23.Show();
            button23.Enabled = true;
            button22.Enabled = true;
            BClass.Enabled = true;
            CClass.Enabled = true;
            DClass.Enabled = true;
        }

        private void CClass_Click(object sender, EventArgs e)
        {
            type = "В";
            //if(Globals.permission>0) Update.Show();
            dataGridView1.Show();
            MessageBox.Show(klas + type);
        }

        private void DClass_Click(object sender, EventArgs e)
        {
            type = "Г";
            //if(Globals.permission>0) Update.Show();
            dataGridView1.Show();
            MessageBox.Show(klas + type);
        }

        private void Class11_Click(object sender, EventArgs e)
        {
            klas = 11;
            button23.Show();
            button23.Enabled = true;
            Class8.Hide();
            Class10.Hide();
            Class12.Hide();
            Class9.Hide();
            button22.Show();
            BClass.Show();
            DClass.Show();
            CClass.Show();
            button22.Enabled = true;
            BClass.Enabled = true;
            CClass.Enabled = true;
            DClass.Enabled = true;
        
        }

        private void BClass_Click(object sender, EventArgs e)
        {
            type = "Б";
            //if(Globals.permission>0) Update.Show();
            MessageBox.Show(klas+type);
            dataGridView1.Show();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            type = "А";
            //if (Globals.permission > 0) Update.Show();
            dataGridView1.Show();
            MessageBox.Show(klas + type);
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

/*12*/  private void Class12_Click(object sender, EventArgs e)
        {
            klas = 12;
            button23.Show();
            button23.Enabled = true;
            Class8.Hide();
            Class10.Hide();
            Class11.Hide();
            Class9.Hide();
            button22.Show();
            BClass.Show();
            DClass.Show();
            CClass.Show();
            button22.Enabled = true;
            BClass.Enabled = true;
            CClass.Enabled = true;
            DClass.Enabled = true;
        }

/*9*/   private void Class9_Click(object sender, EventArgs e)
        {
            klas = 9;
            button23.Show();
            button23.Enabled = true;
            Class8.Hide();
            Class10.Hide();
            Class11.Hide();
            Class12.Hide();
            button22.Show();
            BClass.Show();
            DClass.Show();
            CClass.Show();
            button22.Enabled = true;
            BClass.Enabled = true;
            CClass.Enabled = true;
            DClass.Enabled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Class8.Show();
            Class9.Show();
            Class10.Show();
            Class11.Show();
            Class12.Show();
            button22.Hide();
            BClass.Hide();
            CClass.Hide();
            DClass.Hide();
            dataGridView1.Hide();
            Update.Hide();

        }
    }
}
