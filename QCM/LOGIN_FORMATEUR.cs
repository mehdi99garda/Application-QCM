using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM
{
    public partial class LOGIN_FORMATEUR : Form
    {
        public LOGIN_FORMATEUR()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                string req = "select count(*) from formateur where users='" + textBox1.Text + "' and pass='" + textBox2.Text + "'";
                connection.cmd = new SqlCommand(req , connection.con);
                connection.dr = connection.cmd.ExecuteReader();
                connection.dr.Read();
                if (connection.dr[0].ToString() == "1")
                {
                    connection.con.Close();
                    this.Hide();
                    formateur m = new formateur();
                    m.Show();
                }else
                {
                    MessageBox.Show("Mot de passe ou username est incorrect");
                }
            }
            else
            {
                MessageBox.Show("Remplir tous les champs !!");
            }
            connection.con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            nouveau_formateur m = new nouveau_formateur();
            m.Show();
        }

        private void LOGIN_FORMATEUR_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            //textBox1.Text = "";
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            //textBox2.Text = "";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            //textBox1.Text = "USER";
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            //textBox2.Text = "password";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f = new menu();
            f.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "user")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;


            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "user";
                textBox1.ForeColor = Color.Silver;


            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "password")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
                textBox2.UseSystemPasswordChar = false;
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "password";
                textBox2.UseSystemPasswordChar = true;
                textBox2.ForeColor = Color.Silver;


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
