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
    public partial class nouveau_formateur : Form
    {
        public nouveau_formateur()
        {
            InitializeComponent();
        }

        private void nouveau_formateur_Load(object sender, EventArgs e)
        {
            pass.PasswordChar = '*';
            pass_confirme.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN_FORMATEUR f = new LOGIN_FORMATEUR();
            f.Show();
        }

        private void create_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            if(nom.Text != "" && matri.Text != "" && cin.Text != "" && etab.Text != "" && user.Text != "" && pass.Text != "" && pass_confirme.Text != "")
            {
                if(pass.Text == pass_confirme.Text)
                {
                    string req = "insert into formateur values('" + nom.Text + "','" + matri.Text + "','" + cin.Text + "','" + etab.Text + "','" + user.Text + "','" + pass.Text + "')";
                    connection.cmd = new SqlCommand(req, connection.con);
                    int i = connection.cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("** Bien Ajouter **");
                    }
                    else
                    {
                        MessageBox.Show("Erreur !! Non Ajouter!!");
                    }
                }
                else
                {
                    MessageBox.Show("Verifier la confirmation de mot de pass");
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
            nom.Text = "";
            matri.Text = "";
            cin.Text = "";
            etab.Text = "";
            user.Text = "";
            pass.Text = "";
            pass_confirme.Text = "";

        }
    }
}
