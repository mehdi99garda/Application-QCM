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
    public partial class MODULES_PERIODE : Form
    {
        public MODULES_PERIODE()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPG Files(*.jpg|*.jpg|PNG Files(*.png|*.png|all Files(*.*)|*.*]";
            if(fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string img = fd.FileName;
                pictureBox4.ImageLocation = img;
            }
            //fd.ShowDialog();
            //pictureBox4.ImageLocation = fd.FileNames.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public static string img1 = "";
        public static string img2 = "";
        public static string img3 = "";
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPG Files(*.jpg|*.jpg|PNG Files(*.png|*.png|all Files(*.*)|*.*]";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 img1 = fd.FileName;
                pictureBox4.ImageLocation = img1;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            formateur f = new formateur();
            f.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPG Files(*.jpg|*.jpg|PNG Files(*.png|*.png|all Files(*.*)|*.*]";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 img2 = fd.FileName;
                pictureBox3.ImageLocation = img2;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPG Files(*.jpg|*.jpg|PNG Files(*.png|*.png|all Files(*.*)|*.*]";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 img3 = fd.FileName;
                pictureBox6.ImageLocation = img3;
            }
        }

        private void confirmer_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            string req = "insert into sessione values('" + filiere.Text + "','" + img1 + "','" + mod1.Text + "','" + img2 + "','" + mod2.Text + "','" + img3 + "','" + mod3.Text + "')";
            try
            {
                connection.cmd = new SqlCommand(req , connection.con);
                connection.cmd.ExecuteNonQuery();
                MessageBox.Show("Bien Ajouter");
            }
            catch
            {
                req = "update sessione set img1='" + img1 + "',modul1='" + mod1.Text + "',img2='" + img2 + "',modul2='" + mod2.Text + "',img3='" + img3 + "',modul3='" + mod3.Text + "' where filiere='" + filiere.Text + "'";
                connection.cmd = new SqlCommand(req, connection.con);
                connection.cmd.ExecuteNonQuery();
                MessageBox.Show("Bien Modifier");
            }

            connection.con.Close();
        }

        private void filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.con.Open();
            string req = "select module from filiere_module where filiere='" + filiere.SelectedItem + "'";
            connection.cmd = new SqlCommand(req, connection.con);
            connection.dr = connection.cmd.ExecuteReader();
            while(connection.dr.Read())
            {
                mod1.Items.Add(connection.dr[0].ToString());
                mod2.Items.Add(connection.dr[0].ToString());
                mod3.Items.Add(connection.dr[0].ToString());
            }
            connection.con.Close();

            //charger les photos
            req = "select * from sessione where filiere='" + filiere.SelectedItem + "'";
            connection.con.Open();
            SqlCommand cmd = new SqlCommand(req, connection.con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                DataTable d = new DataTable();
                d.Load(dr);

                mod1.Text = d.Rows[0][2].ToString();
                mod2.Text = d.Rows[0][4].ToString();
                mod3.Text = d.Rows[0][6].ToString();

                pictureBox4.ImageLocation = d.Rows[0][1].ToString();
                pictureBox3.ImageLocation = d.Rows[0][3].ToString();
                pictureBox6.ImageLocation = d.Rows[0][5].ToString();
            }
            catch
            {
                //MessageBox.Show("");
            }
            connection.con.Close();
        }

        private void MODULES_PERIODE_Load(object sender, EventArgs e)
        {

        }
    }
}
