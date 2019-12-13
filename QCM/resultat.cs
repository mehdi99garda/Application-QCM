using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM
{
    public partial class resultat : Form
    {
        public resultat()
        {
            InitializeComponent();
        }

        private void resultat_Load(object sender, EventArgs e)
        {
            label7.Text += menu_candidat.mod;
            label8.Text = DateTime.Now.ToString();
            nom.Text = CANDIDAT.nom;
            cin.Text = CANDIDAT.cin;
            if(exam.note >14)
            {
                note.Text = "Assez Bien";
            }
            else
            {
                if(exam.note > 16)
                {
                    note.Text = "Bien ";
                }
                else
                {
                    note.Text = "Très Bien";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Print(panel1);
        }
        Bitmap bmp;
        PrintPreviewDialog ppd = new PrintPreviewDialog();
        PrintDocument pd = new PrintDocument();
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(pnl);
            ppd.Document = pd;
            pd.PrintPage += new PrintPageEventHandler(pd_pp);
            ppd.ShowDialog();
        }
        public void pd_pp(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bmp, (pagearea.Width / 4) - (this.panel1.Width / 4), this.Location.Y);
        }
        public void getprintarea(Panel pnl)
        {
            bmp = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bmp, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_candidat m = new menu_candidat();
            m.Show();
        }
    }
}
