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
    public partial class formateur : Form
    {
        public formateur()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MODULES_PERIODE mm = new MODULES_PERIODE();
            mm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            creer_qcm b = new creer_qcm();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mise_a_jours_question m = new mise_a_jours_question();
            m.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN_FORMATEUR m = new LOGIN_FORMATEUR();
            m.Show();
        }

        private void cherche_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            connection.dt.Clear();
            dataGridView1.DataSource = connection.dt;
            string req = "select nom , cin , note , datt as DATE from certif where  filiere='" + cmb_filiere.Text + "' and module='" + cmb_module.Text + "'";
            connection.cmd = new SqlCommand(req, connection.con);
            connection.dr = connection.cmd.ExecuteReader();
            connection.dt.Clear();
            DataTable dt = new DataTable();
            dt.Load(connection.dr);
            dataGridView1.DataSource = dt;
            connection.con.Close();
        }

        private void formateur_Load(object sender, EventArgs e)
        {
            connection.con.Open();
            connection.cmd = new SqlCommand("select nom , cin , note , datt as DATE from certif", connection.con);
            connection.dr = connection.cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(connection.dr);
            dataGridView1.DataSource = dt;
            connection.con.Close();
        }

        private void cmb_filiere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_filiere_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            connection.con.Open();
            cmb_module.Items.Clear();
            string req = "select module from filiere_module where filiere='" + cmb_filiere.SelectedItem + "'";
            connection.cmd = new SqlCommand(req, connection.con);
            connection.dr = connection.cmd.ExecuteReader();
            while (connection.dr.Read())
            {
                cmb_module.Items.Add(connection.dr[0].ToString());
            }
            connection.con.Close();
        }

        private void down_Click(object sender, EventArgs e)
        {
            if(deco.Visible == true)
            {
                deco.Visible = false;
            }
            else
            {
                deco.Visible = true;
            }

        }

        private void deco_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu m = new menu();
            m.Show();
        }
    }
}
