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
    public partial class exam : Form
    {
        public exam()
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
            menu_candidat m = new menu_candidat();
            m.Show();
        }

        private void exam_Load(object sender, EventArgs e)
        {
            num.Text = menu_candidat.dtt.Rows[0][1].ToString();
            question.Text = menu_candidat.dtt.Rows[0][2].ToString();
            r1.Text = menu_candidat.dtt.Rows[0][4].ToString();
            r2.Text = menu_candidat.dtt.Rows[0][5].ToString();
            r3.Text = menu_candidat.dtt.Rows[0][6].ToString();
            confirmer.Visible = false;
            pic1.Visible = false;
        }
        public static int note = 0;
        int count = 1;
        private void suivant_Click(object sender, EventArgs e)
        {
            if(count >= 20)
            {
                confirmer.Visible = true;
                pic1.Visible = true;
                suivant.Visible = false;
            }
            else
            {
                if (r1.Checked == true)
                {
                    if (r1.Text == menu_candidat.dtt.Rows[count - 1][3].ToString())
                    {
                        note = note + 1;
                    }
                }

                if (r2.Checked == true)
                {
                    if (r2.Text == menu_candidat.dtt.Rows[count - 1][3].ToString())
                    {
                        note = note + 1;
                    }
                }

                if (r3.Checked == true)
                {
                    if (r3.Text == menu_candidat.dtt.Rows[count - 1][3].ToString())
                    {
                        note = note + 1;
                    }
                }

                question.Text = menu_candidat.dtt.Rows[count][2].ToString();
                r1.Text = menu_candidat.dtt.Rows[count][4].ToString();
                r2.Text = menu_candidat.dtt.Rows[count][5].ToString();
                r3.Text = menu_candidat.dtt.Rows[count][6].ToString();

                count++;
                num.Text = count.ToString();
                r1.Checked = true;
            }
        }

        private void confirmer_Click(object sender, EventArgs e)
        {
            
            connection.con.Open();
            string req = "insert into certif values('" + menu_candidat.fil + "','" + menu_candidat.mod + "','" + CANDIDAT.nom + "','" + CANDIDAT.cin + "'," + note + ",'" + DateTime.Now.ToString() + "')";
            connection.cmd = new SqlCommand(req, connection.con);
            connection.cmd.ExecuteNonQuery();
            connection.con.Close();
            if (note >= 12)
            {
                this.Hide();
                resultat rr = new resultat();
                rr.Show();
            }
            else
            {
                MessageBox.Show("A la prochaine Inchallah");
                this.Hide();
                menu_candidat m = new menu_candidat();
                m.Show();
            }
        }
    }
}
