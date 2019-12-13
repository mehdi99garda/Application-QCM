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
    public partial class creer_qcm : Form
    {
        public creer_qcm()
        {
            InitializeComponent();
        }

        private void creer_qcm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static int id;
        private void button1_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            if(comboBox1.Text != "" && textBox1.Text != "")
            {
                string req = "insert into filiere_module values ('" + comboBox1.Text + "','" + textBox1.Text + "')";
                connection.cmd = new SqlCommand(req , connection.con);
                int i = connection.cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    string re = "select id from filiere_module where filiere='" + comboBox1.Text + "' and module='" + textBox1.Text + "'";
                    SqlCommand cmb = new SqlCommand(re, connection.con);
                    SqlDataReader dr = cmb.ExecuteReader();
                    dr.Read();
                    id = Convert.ToInt16(dr[0].ToString());
                    
                    connection.con.Close();
                    this.Hide();
                    ajouter_question f = new ajouter_question();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Erreur !! Non Ajouter!!");
                    connection.con.Close();
                }
            }
            else
            {
                MessageBox.Show("Remplir tous les champs !!");
                connection.con.Close();
            }
            connection.con.Close();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            connection.con.Close();
            this.Hide();
            formateur f = new formateur();
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.con.Open();
            string req = "select module from filiere_module where filiere='" + comboBox1.SelectedItem + "'";
            connection.cmd = new SqlCommand(req, connection.con);
            connection.dr = connection.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(connection.dr);
            dataGridView1.DataSource = dt;
            connection.con.Close();
        }
    }
}
