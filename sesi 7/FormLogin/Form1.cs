using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM user_info WHERE username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'");
            if (db.count() == 1)
            {
                MessageBox.Show("Login Success! You logged in as " + db.Results(0, "name"));
            }
            else
            {
                MessageBox.Show("Wrong username or password combination!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
