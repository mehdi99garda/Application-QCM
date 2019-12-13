namespace QCM
{
    partial class exam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exam));
            this.panel1 = new System.Windows.Forms.Panel();
            this.question = new System.Windows.Forms.Label();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.suivant = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmer = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.question);
            this.panel1.Location = new System.Drawing.Point(62, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 69);
            this.panel1.TabIndex = 0;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question.ForeColor = System.Drawing.Color.Snow;
            this.question.Location = new System.Drawing.Point(19, 24);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(51, 16);
            this.question.TabIndex = 0;
            this.question.Text = "label1";
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Checked = true;
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1.ForeColor = System.Drawing.Color.Snow;
            this.r1.Location = new System.Drawing.Point(207, 205);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(122, 22);
            this.r1.TabIndex = 1;
            this.r1.TabStop = true;
            this.r1.Text = "radioButton1";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.ForeColor = System.Drawing.Color.Snow;
            this.r2.Location = new System.Drawing.Point(207, 263);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(122, 22);
            this.r2.TabIndex = 2;
            this.r2.Text = "radioButton2";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r3.ForeColor = System.Drawing.Color.Snow;
            this.r3.Location = new System.Drawing.Point(207, 321);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(122, 22);
            this.r3.TabIndex = 3;
            this.r3.Text = "radioButton3";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(651, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // suivant
            // 
            this.suivant.BackColor = System.Drawing.Color.Teal;
            this.suivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suivant.ForeColor = System.Drawing.Color.White;
            this.suivant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.suivant.Location = new System.Drawing.Point(290, 400);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(137, 44);
            this.suivant.TabIndex = 32;
            this.suivant.Text = "Suivant";
            this.suivant.UseVisualStyleBackColor = false;
            this.suivant.Click += new System.EventHandler(this.suivant_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 50);
            this.label3.TabIndex = 35;
            this.label3.Text = "/20";
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(340, 34);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(29, 50);
            this.num.TabIndex = 34;
            this.num.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 50);
            this.label4.TabIndex = 33;
            this.label4.Text = "Question";
            // 
            // confirmer
            // 
            this.confirmer.BackColor = System.Drawing.Color.Teal;
            this.confirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmer.ForeColor = System.Drawing.Color.White;
            this.confirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmer.Location = new System.Drawing.Point(275, 400);
            this.confirmer.Name = "confirmer";
            this.confirmer.Size = new System.Drawing.Size(137, 44);
            this.confirmer.TabIndex = 36;
            this.confirmer.Text = "Confirmer";
            this.confirmer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmer.UseVisualStyleBackColor = false;
            this.confirmer.Click += new System.EventHandler(this.confirmer_Click);
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Teal;
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(288, 410);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(24, 22);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 37;
            this.pic1.TabStop = false;
            // 
            // exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(697, 475);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.confirmer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.r3);
            this.Controls.Add(this.r2);
            this.Controls.Add(this.r1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exam";
            this.Text = "exam";
            this.Load += new System.EventHandler(this.exam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirmer;
        private System.Windows.Forms.PictureBox pic1;
    }
}