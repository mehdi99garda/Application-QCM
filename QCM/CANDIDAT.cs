using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM
{
    public partial class CANDIDAT : Form
    {
        public CANDIDAT()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string nom;
        public static string cin;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                nom = textBox1.Text;
                cin = textBox2.Text;
                this.Hide();
                menu_candidat m = new menu_candidat();
                m.Show();
            }
            else
            {
                MessageBox.Show("Remplir les champs !!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu f = new menu();
            f.Show();
        }
    }
}
