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
    public partial class mise_a_jours_question : Form
    {
        public mise_a_jours_question()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            formateur L = new formateur();
            L.Show();
        }

        private void mise_a_jours_question_Load(object sender, EventArgs e)
        {
            
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            string req = "select num as numero , question , rep as reponse , choix1 , choix2 , choix3 , id from question_qcm where id in(select id from filiere_module where filiere='" + filiere.Text + "' and module='" + module.Text + "')";
            connection.cmd = new SqlCommand(req, connection.con);
            connection.dr = connection.cmd.ExecuteReader();
            connection.dt.Clear();
            connection.dt.Load(connection.dr);
            dataGridView1.DataSource = connection.dt;
            connection.con.Close();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            string req = "update question_qcm set question='" + question.Text + "',rep='" + reponse.Text + "',choix1='" + ch1.Text + "', choix2='" + ch2.Text + "',choix3='" + ch3.Text + "' ";
            req += " where id=" + id + " and num=" + Convert.ToInt16(nume.Text);
            connection.cmd = new SqlCommand(req, connection.con);
            int i = connection.cmd.ExecuteNonQuery();
            if(i == 1)
            {
                MessageBox.Show("Bien Modifier");
                connection.con.Close();
                rechercher_Click(sender, e);
            }
            
            connection.con.Close();
        }

        private void filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.con.Open();
            module.Items.Clear();
            string req = "select module from filiere_module where filiere='" + filiere.SelectedItem + "'";
            connection.cmd = new SqlCommand(req, connection.con);
            connection.dr = connection.cmd.ExecuteReader();
            while (connection.dr.Read())
            {
                module.Items.Add(connection.dr[0].ToString());
            }
            connection.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            question.Text = "";
            reponse.Text = "";
            ch1.Text = "";
            ch2.Text = "";
            ch3.Text = "";
        }
        public int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                nume.Text = row.Cells[0].Value.ToString();
                question.Text = row.Cells[1].Value.ToString();
                reponse.Text = row.Cells[2].Value.ToString(); 
                ch1.Text = row.Cells[3].Value.ToString(); 
                ch2.Text = row.Cells[4].Value.ToString();
                ch3.Text = row.Cells[5].Value.ToString();
                id = Convert.ToInt16(row.Cells[6].Value.ToString());
            }

        }
    }
}
