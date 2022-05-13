namespace ToolBox
{
    partial class FrmAboutMe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAboutMe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lineSeparator2 = new ToolBox.CustomLineSeparator();
            this.clsCircularPictureBox1 = new ToolBox.CircularPictureBox();
            this.lineSeparator1 = new ToolBox.CustomLineSeparator();
            this.linkEdin = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clsCircularPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 150);
            this.panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(312, 8);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 30);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(134, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unquillo - Córdoba - Argentina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Stack Developer Jr.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hugo Antonio Segura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(35, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sobre mi";
            // 
            // lblAboutMe
            // 
            this.lblAboutMe.ForeColor = System.Drawing.Color.DimGray;
            this.lblAboutMe.Location = new System.Drawing.Point(35, 207);
            this.lblAboutMe.Name = "lblAboutMe";
            this.lblAboutMe.Size = new System.Drawing.Size(280, 129);
            this.lblAboutMe.TabIndex = 7;
            this.lblAboutMe.Text = "Soy un antiguo programador, empecé con dbase, Clipper, FoxPro for D.O.S., Visual " +
    "FoxPro, basic, visual basic...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(35, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contacto";
            // 
            // lineSeparator2
            // 
            this.lineSeparator2.BorderSize = 2;
            this.lineSeparator2.ForeColor = System.Drawing.Color.DimGray;
            this.lineSeparator2.IsVertical = false;
            this.lineSeparator2.Location = new System.Drawing.Point(35, 369);
            this.lineSeparator2.Margin = new System.Windows.Forms.Padding(0);
            this.lineSeparator2.Name = "lineSeparator2";
            this.lineSeparator2.Size = new System.Drawing.Size(277, 4);
            this.lineSeparator2.TabIndex = 10;
            this.lineSeparator2.Text = "lineSeparator2";
            // 
            // clsCircularPictureBox1
            // 
            this.clsCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.clsCircularPictureBox1.BorderColor = System.Drawing.Color.White;
            this.clsCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.clsCircularPictureBox1.BorderSize = 3;
            this.clsCircularPictureBox1.BorderStyle1 = System.Drawing.Drawing2D.DashStyle.Solid;
            this.clsCircularPictureBox1.GradientAngle = 50F;
            this.clsCircularPictureBox1.Image = global::ToolBox.Properties.Resources.profile;
            this.clsCircularPictureBox1.Location = new System.Drawing.Point(28, 52);
            this.clsCircularPictureBox1.Name = "clsCircularPictureBox1";
            this.clsCircularPictureBox1.Size = new System.Drawing.Size(80, 80);
            this.clsCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clsCircularPictureBox1.TabIndex = 1;
            this.clsCircularPictureBox1.TabStop = false;
            // 
            // lineSeparator1
            // 
            this.lineSeparator1.BorderSize = 2;
            this.lineSeparator1.ForeColor = System.Drawing.Color.DimGray;
            this.lineSeparator1.IsVertical = false;
            this.lineSeparator1.Location = new System.Drawing.Point(35, 198);
            this.lineSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.lineSeparator1.Name = "lineSeparator1";
            this.lineSeparator1.Size = new System.Drawing.Size(277, 3);
            this.lineSeparator1.TabIndex = 8;
            this.lineSeparator1.Text = "lineSeparator1";
            // 
            // linkEdin
            // 
            this.linkEdin.FlatAppearance.BorderSize = 0;
            this.linkEdin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.linkEdin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEdin.ForeColor = System.Drawing.Color.DimGray;
            this.linkEdin.IconChar = FontAwesome.Sharp.IconChar.Linkedin;
            this.linkEdin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(102)))), ((int)(((byte)(194)))));
            this.linkEdin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.linkEdin.IconSize = 30;
            this.linkEdin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkEdin.Location = new System.Drawing.Point(31, 382);
            this.linkEdin.Margin = new System.Windows.Forms.Padding(0);
            this.linkEdin.Name = "linkEdin";
            this.linkEdin.Size = new System.Drawing.Size(143, 26);
            this.linkEdin.TabIndex = 12;
            this.linkEdin.Text = "LinkEdin";
            this.linkEdin.UseVisualStyleBackColor = true;
            this.linkEdin.Click += new System.EventHandler(this.linkEdin_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(168, 382);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(143, 26);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.Text = "GitHub";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FrmAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 425);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.linkEdin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lineSeparator2);
            this.Controls.Add(this.lblAboutMe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lineSeparator1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAboutMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAboutMe";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CircularPictureBox clsCircularPictureBox1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAboutMe;
        private CustomLineSeparator lineSeparator1;
        private System.Windows.Forms.Label label5;
        private CustomLineSeparator lineSeparator2;
        private FontAwesome.Sharp.IconButton linkEdin;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}