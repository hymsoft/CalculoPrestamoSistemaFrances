namespace ToolBox
{
    partial class FrmFechaHora
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
            this.components = new System.ComponentModel.Container();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblFecha.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.White;
            this.LblFecha.Location = new System.Drawing.Point(5, 102);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(470, 32);
            this.LblFecha.TabIndex = 2;
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHora
            // 
            this.LblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblHora.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.White;
            this.LblHora.Location = new System.Drawing.Point(5, 37);
            this.LblHora.Margin = new System.Windows.Forms.Padding(0);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(470, 65);
            this.LblHora.TabIndex = 3;
            this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblHora.Click += new System.EventHandler(this.LblHora_Click);
            // 
            // FrmFechaHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(480, 171);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblHora);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(480, 0);
            this.Name = "FrmFechaHora";
            this.Text = "Pantalla Inicial";
            this.Load += new System.EventHandler(this.FrmFechaHora_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer FechaHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
    }
}