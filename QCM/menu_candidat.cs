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
    public partial class menu_candidat : Form
    {
        public menu_candidat()
        {
            InitializeComponent();
        }
        private SqlCommand cmd = new SqlCommand();
        private DataTable dt = new DataTable();
        private SqlDataReader dr;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mm = new menu();
            mm.Show();
        }

        private void menu_candidat_Load(object sender, EventArgs e)
        {
            //img1.ImageLocation = @"C:\Users\Mehdi\Desktop\IMG-20190429-WA0044.jpg";
            panel2.Visible = false;
            label1.Visible = true;
            label4.Visible = true;
        }
        public static string fil;
        public static string mod;
        private void tdi_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label1.Visible = false;
            label4.Visible = false;
            fil = "TDI";
            string req = "select * from sessione where filiere='TDI'";
            connection.con.Open();
            cmd = new SqlCommand(req, connection.con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            try
            {
                dt.Load(dr);

                mod1.Text = dt.Rows[0][2].ToString();
                mod2.Text = dt.Rows[0][4].ToString();
                mod3.Text = dt.Rows[0][6].ToString();

                img1.ImageLocation = dt.Rows[0][1].ToString();
                img2.ImageLocation = dt.Rows[0][3].ToString();
                img3.ImageLocation = dt.Rows[0][5].ToString();
                dr.Close();
            }
            catch
            {

            }
            connection.con.Close();
        }

        private void tri_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label1.Visible = false;
            label4.Visible = false;
            fil = "TRI";
            string req = "select * from sessione where filiere='TRI'";
            connection.con.Open();
            cmd = new SqlCommand(req, connection.con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            try
            {
                dt.Load(dr);

                mod1.Text = dt.Rows[0][2].ToString();
                mod2.Text = dt.Rows[0][4].ToString();
                mod3.Text = dt.Rows[0][6].ToString();

                img1.ImageLocation = dt.Rows[0][1].ToString();
                img2.ImageLocation = dt.Rows[0][3].ToString();
                img3.ImageLocation = dt.Rows[0][5].ToString();

                dr.Close();
            }
            catch
            {
                
            }
            connection.con.Close();
        }

        private void tdm_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label1.Visible = false;
            label4.Visible = false;
            fil = "TDM";
            string req = "select * from sessione where filiere='TDM'";
            connection.con.Open();
            cmd = new SqlCommand(req, connection.con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            try
            {
                dt.Load(dr);

                mod1.Text = dt.Rows[0][2].ToString();
                mod2.Text = dt.Rows[0][4].ToString();
                mod3.Text = dt.Rows[0][6].ToString();

                img1.ImageLocation = dt.Rows[0][1].ToString();
                img2.ImageLocation = dt.Rows[0][3].ToString();
                img3.ImageLocation = dt.Rows[0][5].ToString();

                dr.Close();
            }
            catch
            {

            }
            connection.con.Close();
        }

        private void tmsir_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label1.Visible = false;
            label4.Visible = false;
            fil = "TMSIR";
            string req = "select * from sessione where filiere='TMSIR'";
            connection.con.Open();
            cmd = new SqlCommand(req, connection.con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            try
            {
                dt.Load(dr);

                mod1.Text = dt.Rows[0][2].ToString();
                mod2.Text = dt.Rows[0][4].ToString();
                mod3.Text = dt.Rows[0][6].ToString();

                img1.ImageLocation = dt.Rows[0][1].ToString();
                img2.ImageLocation = dt.Rows[0][3].ToString();
                img3.ImageLocation = dt.Rows[0][5].ToString();

                dr.Close();
            }
            catch
            {

            }
            connection.con.Close();
        }
        public static DataTable dtt = new DataTable();
        private void btn_mod1_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            mod = mod1.Text;
            string req = "select * from question_qcm where id in(select id from filiere_module where filiere='" + fil + "' and module='" + mod1.Text + "')";
            cmd = new SqlCommand(req, connection.con);
            dr = cmd.ExecuteReader();
            

            string r1;
            try
            {
                dtt.Load(connection.dr);
                connection.con.Close();
                r1 = dtt.Rows[0][1].ToString();
                this.Hide();
                exam ex = new exam();
                ex.Show();
            }
            catch
            {
                MessageBox.Show("Module n'existe pas !! ");
            }
            dr.Close();
        }

        private void btn_mod2_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            mod = mod2.Text;
            string req = "select * from question_qcm where id in(select id from filiere_module where filiere='" + fil + "' and module='" + mod2.Text + "')";
            cmd = new SqlCommand(req, connection.con);
            dr = cmd.ExecuteReader();
           


            string r1;
            try
            {
                dtt.Load(dr);
                connection.con.Close();
                r1 = menu_candidat.dtt.Rows[0][1].ToString();
                this.Hide();
                exam ex = new exam();
                ex.Show();
            }
            catch
            {
                MessageBox.Show("Module n'existe pas !! ");
            }
        }

        private void btn_mod3_Click(object sender, EventArgs e)
        {
            connection.con.Open();
            mod = mod3.Text;
            string req = "select * from question_qcm where id in(select id from filiere_module where filiere='" + fil + "' and module='" + mod3.Text + "')";
            cmd = new SqlCommand(req, connection.con);
            dr = cmd.ExecuteReader();
            



            string r1;
            try
            {
                dtt.Load(dr);
                connection.con.Close();
                r1 = menu_candidat.dtt.Rows[0][1].ToString();
                this.Hide();
                exam ex = new exam();
                ex.Show();
            }
            catch
            {
                MessageBox.Show("Module n'existe pas !! ");
            }
            dr.Close();
        }

        private void mod1_Click(object sender, EventArgs e)
        {

        }
    }
}
