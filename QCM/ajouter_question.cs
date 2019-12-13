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
    public partial class ajouter_question : Form
    {
        public ajouter_question()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int x;
        private void ajouter_question_Load(object sender, EventArgs e)
        {
            confirmer.Visible = false;
            connection.con.Close();
            connection.con.Open();
            string req = "select count(*) from filiere_module";
            connection.cmd = new SqlCommand(req , connection.con);
            connection.dr = connection.cmd.ExecuteReader();
            connection.dr.Read();
            x = Convert.ToInt16(connection.dr[0].ToString());
            connection.con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            creer_qcm f = new creer_qcm();
            f.Show();
        }
        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (count >= 20)
            {
                confirmer.Visible = true;
                valider.Visible = false;
                button2.Visible = false;
                
            }
            else
            {
                if (question.Text != "" && reponse.Text != "" && chois1.Text != "" && chois2.Text != "" && chois3.Text != "")
                {
                    connection.con.Open();
                    string req = "insert into question_qcm values(" + creer_qcm.id + "," + Convert.ToInt16(num.Text) + ",'" + question.Text + "','" + reponse.Text + "','" + chois1.Text + "','" + chois2.Text + "','" + chois3.Text + "')";
                    connection.cmd = new SqlCommand(req, connection.con);
                    connection.cmd.ExecuteNonQuery();
                    connection.con.Close();
                    //vider les champs
                    question.Text = "";
                    reponse.Text = "";
                    chois1.Text = "";
                    chois2.Text = "";
                    chois3.Text = "";

                    count++;
                    num.Text = count.ToString();
                }
                else
                {
                    MessageBox.Show("Remplir tous les champs !!");
                }
            }
        }

        private void confirmer_Click(object sender, EventArgs e)
        {
            if (question.Text != "" && reponse.Text != "" && chois1.Text != "" && chois2.Text != "" && chois3.Text != "")
            {
                connection.con.Open();
                string req = "insert into question_qcm values(" + creer_qcm.id + "," + Convert.ToInt16(num.Text) + ",'" + question.Text + "','" + reponse.Text + "','" + chois1.Text + "','" + chois2.Text + "','" + chois3.Text + "')";
                connection.cmd = new SqlCommand(req, connection.con);
                connection.cmd.ExecuteNonQuery();
                connection.con.Close();
                //vider les champs
                question.Text = "";
                reponse.Text = "";
                chois1.Text = "";
                chois2.Text = "";
                chois3.Text = "";
                
                MessageBox.Show("** Module Bien Ajouter **");
                this.Hide();
                formateur ff = new formateur();
                ff.Show();


            }
            else
            {
                MessageBox.Show("Remplir tous les champs !!");
            }

        }
    }
}
