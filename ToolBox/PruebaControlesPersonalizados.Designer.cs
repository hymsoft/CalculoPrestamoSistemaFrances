namespace ToolBox
{
    partial class PruebaControlesPersonalizados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcularImporteCuotas = new System.Windows.Forms.Button();
            this.txtPeriodoEnAnios = new ToolBox.CustomTextBox();
            this.txtTNA = new ToolBox.CustomTextBox();
            this.txtCapital = new ToolBox.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnCalcularImporteCuotas);
            this.panel1.Controls.Add(this.txtPeriodoEnAnios);
            this.panel1.Controls.Add(this.txtTNA);
            this.panel1.Controls.Add(this.txtCapital);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 225);
            this.panel1.TabIndex = 0;
            // 
            // btnCalcularImporteCuotas
            // 
            this.btnCalcularImporteCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcularImporteCuotas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularImporteCuotas.Location = new System.Drawing.Point(44, 162);
            this.btnCalcularImporteCuotas.Name = "btnCalcularImporteCuotas";
            this.btnCalcularImporteCuotas.Size = new System.Drawing.Size(385, 27);
            this.btnCalcularImporteCuotas.TabIndex = 47;
            this.btnCalcularImporteCuotas.Text = "Calcular";
            this.btnCalcularImporteCuotas.UseVisualStyleBackColor = true;
            this.btnCalcularImporteCuotas.Click += new System.EventHandler(this.btnCalcularImporteCuotas_Click);
            // 
            // txtPeriodoEnAnios
            // 
            this.txtPeriodoEnAnios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtPeriodoEnAnios.BorderColor = System.Drawing.Color.DimGray;
            this.txtPeriodoEnAnios.BorderFocusColor = System.Drawing.Color.White;
            this.txtPeriodoEnAnios.BorderSize = 2;
            this.txtPeriodoEnAnios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoEnAnios.ForeColor = System.Drawing.Color.White;
            this.txtPeriodoEnAnios.Location = new System.Drawing.Point(192, 104);
            this.txtPeriodoEnAnios.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodoEnAnios.Multiline = false;
            this.txtPeriodoEnAnios.Name = "txtPeriodoEnAnios";
            this.txtPeriodoEnAnios.Padding = new System.Windows.Forms.Padding(7);
            this.txtPeriodoEnAnios.PasswordChar = false;
            this.txtPeriodoEnAnios.ReadOnly = false;
            this.txtPeriodoEnAnios.Size = new System.Drawing.Size(239, 31);
            this.txtPeriodoEnAnios.TabIndex = 43;
            this.txtPeriodoEnAnios.Texts = "";
            this.txtPeriodoEnAnios.UnderlinedStyle = true;
            this.txtPeriodoEnAnios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriodoEnAnios_KeyPress);
            // 
            // txtTNA
            // 
            this.txtTNA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtTNA.BorderColor = System.Drawing.Color.DimGray;
            this.txtTNA.BorderFocusColor = System.Drawing.Color.White;
            this.txtTNA.BorderSize = 2;
            this.txtTNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTNA.ForeColor = System.Drawing.Color.White;
            this.txtTNA.Location = new System.Drawing.Point(192, 63);
            this.txtTNA.Margin = new System.Windows.Forms.Padding(4);
            this.txtTNA.Multiline = false;
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.Padding = new System.Windows.Forms.Padding(7);
            this.txtTNA.PasswordChar = false;
            this.txtTNA.ReadOnly = false;
            this.txtTNA.Size = new System.Drawing.Size(239, 31);
            this.txtTNA.TabIndex = 42;
            this.txtTNA.Texts = "";
            this.txtTNA.UnderlinedStyle = true;
            this.txtTNA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTNA_KeyPress);
            // 
            // txtCapital
            // 
            this.txtCapital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtCapital.BorderColor = System.Drawing.Color.DimGray;
            this.txtCapital.BorderFocusColor = System.Drawing.Color.White;
            this.txtCapital.BorderSize = 2;
            this.txtCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.ForeColor = System.Drawing.Color.White;
            this.txtCapital.Location = new System.Drawing.Point(192, 22);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapital.Multiline = false;
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Padding = new System.Windows.Forms.Padding(7);
            this.txtCapital.PasswordChar = false;
            this.txtCapital.ReadOnly = false;
            this.txtCapital.Size = new System.Drawing.Size(239, 31);
            this.txtCapital.TabIndex = 41;
            this.txtCapital.Texts = "";
            this.txtCapital.UnderlinedStyle = true;
            this.txtCapital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapital_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Años";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "TNA %";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Valor del préstamo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PruebaControlesPersonalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 308);
            this.Controls.Add(this.panel1);
            this.Name = "PruebaControlesPersonalizados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PruebaControlesPersonalizados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustomTextBox txtPeriodoEnAnios;
        private CustomTextBox txtTNA;
        private CustomTextBox txtCapital;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcularImporteCuotas;
    }
}