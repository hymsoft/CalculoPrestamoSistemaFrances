namespace ToolBox
{
    partial class FrmPrestamoSistemaFrances
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
            this.MainContainer = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.gridDesglose = new System.Windows.Forms.DataGridView();
            this.gridNumeroDeCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCuotaAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCapitalAmortizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCapitalAdeudado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDatos = new System.Windows.Forms.TableLayoutPanel();
            this.penelDatosIzquierdo = new System.Windows.Forms.Panel();
            this.txtPeriodoEnAnios = new ToolBox.CustomTextBox();
            this.txtTNA = new ToolBox.CustomTextBox();
            this.txtCapital = new ToolBox.CustomTextBox();
            this.btnCalcularImporteCuotas = new System.Windows.Forms.Button();
            this.cmbFrecuenciaDePagos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDatosDerecho = new System.Windows.Forms.Panel();
            this.txtSumaDeIntereses = new ToolBox.CustomTextBox();
            this.txtSumaDeCuotas = new ToolBox.CustomTextBox();
            this.txtTotalDeCuotas = new ToolBox.CustomTextBox();
            this.txtPagosPorAnio = new ToolBox.CustomTextBox();
            this.txtInteresEquivalente = new ToolBox.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainContainer.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDesglose)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.penelDatosIzquierdo.SuspendLayout();
            this.panelDatosDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.BackColor = System.Drawing.Color.Silver;
            this.MainContainer.Controls.Add(this.panelData);
            this.MainContainer.Controls.Add(this.panelDatos);
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(806, 607);
            this.MainContainer.TabIndex = 0;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.panelData.Controls.Add(this.gridDesglose);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 207);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(806, 400);
            this.panelData.TabIndex = 47;
            // 
            // gridDesglose
            // 
            this.gridDesglose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDesglose.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDesglose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDesglose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridNumeroDeCuota,
            this.gridCuotaAPagar,
            this.gridInteres,
            this.gridCapitalAmortizado,
            this.gridCapitalAdeudado});
            this.gridDesglose.Location = new System.Drawing.Point(12, 6);
            this.gridDesglose.Name = "gridDesglose";
            this.gridDesglose.Size = new System.Drawing.Size(786, 386);
            this.gridDesglose.TabIndex = 10;
            // 
            // gridNumeroDeCuota
            // 
            this.gridNumeroDeCuota.HeaderText = "Nº de Cuota";
            this.gridNumeroDeCuota.Name = "gridNumeroDeCuota";
            this.gridNumeroDeCuota.ReadOnly = true;
            // 
            // gridCuotaAPagar
            // 
            this.gridCuotaAPagar.HeaderText = "Cuota a pagar";
            this.gridCuotaAPagar.Name = "gridCuotaAPagar";
            this.gridCuotaAPagar.ReadOnly = true;
            // 
            // gridInteres
            // 
            this.gridInteres.HeaderText = "Interés";
            this.gridInteres.Name = "gridInteres";
            this.gridInteres.ReadOnly = true;
            // 
            // gridCapitalAmortizado
            // 
            this.gridCapitalAmortizado.HeaderText = "Capital Amortizado";
            this.gridCapitalAmortizado.Name = "gridCapitalAmortizado";
            this.gridCapitalAmortizado.ReadOnly = true;
            // 
            // gridCapitalAdeudado
            // 
            this.gridCapitalAdeudado.HeaderText = "Capital Adeudado";
            this.gridCapitalAdeudado.Name = "gridCapitalAdeudado";
            this.gridCapitalAdeudado.ReadOnly = true;
            // 
            // panelDatos
            // 
            this.panelDatos.ColumnCount = 2;
            this.panelDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDatos.Controls.Add(this.penelDatosIzquierdo, 0, 0);
            this.panelDatos.Controls.Add(this.panelDatosDerecho, 1, 0);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatos.Location = new System.Drawing.Point(0, 0);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.RowCount = 1;
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.panelDatos.Size = new System.Drawing.Size(806, 207);
            this.panelDatos.TabIndex = 46;
            // 
            // penelDatosIzquierdo
            // 
            this.penelDatosIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.penelDatosIzquierdo.Controls.Add(this.textBox1);
            this.penelDatosIzquierdo.Controls.Add(this.txtPeriodoEnAnios);
            this.penelDatosIzquierdo.Controls.Add(this.txtTNA);
            this.penelDatosIzquierdo.Controls.Add(this.txtCapital);
            this.penelDatosIzquierdo.Controls.Add(this.btnCalcularImporteCuotas);
            this.penelDatosIzquierdo.Controls.Add(this.cmbFrecuenciaDePagos);
            this.penelDatosIzquierdo.Controls.Add(this.label5);
            this.penelDatosIzquierdo.Controls.Add(this.label4);
            this.penelDatosIzquierdo.Controls.Add(this.label3);
            this.penelDatosIzquierdo.Controls.Add(this.label2);
            this.penelDatosIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penelDatosIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.penelDatosIzquierdo.Margin = new System.Windows.Forms.Padding(0);
            this.penelDatosIzquierdo.Name = "penelDatosIzquierdo";
            this.penelDatosIzquierdo.Size = new System.Drawing.Size(403, 207);
            this.penelDatosIzquierdo.TabIndex = 0;
            // 
            // txtPeriodoEnAnios
            // 
            this.txtPeriodoEnAnios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtPeriodoEnAnios.BorderColor = System.Drawing.Color.DimGray;
            this.txtPeriodoEnAnios.BorderFocusColor = System.Drawing.Color.White;
            this.txtPeriodoEnAnios.BorderSize = 2;
            this.txtPeriodoEnAnios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoEnAnios.ForeColor = System.Drawing.Color.White;
            this.txtPeriodoEnAnios.Location = new System.Drawing.Point(157, 93);
            this.txtPeriodoEnAnios.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodoEnAnios.Multiline = false;
            this.txtPeriodoEnAnios.Name = "txtPeriodoEnAnios";
            this.txtPeriodoEnAnios.Padding = new System.Windows.Forms.Padding(7);
            this.txtPeriodoEnAnios.PasswordChar = false;
            this.txtPeriodoEnAnios.ReadOnly = false;
            this.txtPeriodoEnAnios.Size = new System.Drawing.Size(239, 31);
            this.txtPeriodoEnAnios.TabIndex = 3;
            this.txtPeriodoEnAnios.Texts = "";
            this.txtPeriodoEnAnios.UnderlinedStyle = true;
            // 
            // txtTNA
            // 
            this.txtTNA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtTNA.BorderColor = System.Drawing.Color.DimGray;
            this.txtTNA.BorderFocusColor = System.Drawing.Color.White;
            this.txtTNA.BorderSize = 2;
            this.txtTNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTNA.ForeColor = System.Drawing.Color.White;
            this.txtTNA.Location = new System.Drawing.Point(157, 52);
            this.txtTNA.Margin = new System.Windows.Forms.Padding(4);
            this.txtTNA.Multiline = false;
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.Padding = new System.Windows.Forms.Padding(7);
            this.txtTNA.PasswordChar = false;
            this.txtTNA.ReadOnly = false;
            this.txtTNA.Size = new System.Drawing.Size(239, 31);
            this.txtTNA.TabIndex = 2;
            this.txtTNA.Texts = "";
            this.txtTNA.UnderlinedStyle = true;
            // 
            // txtCapital
            // 
            this.txtCapital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtCapital.BorderColor = System.Drawing.Color.DimGray;
            this.txtCapital.BorderFocusColor = System.Drawing.Color.White;
            this.txtCapital.BorderSize = 2;
            this.txtCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.ForeColor = System.Drawing.Color.White;
            this.txtCapital.Location = new System.Drawing.Point(157, 11);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapital.Multiline = false;
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Padding = new System.Windows.Forms.Padding(7);
            this.txtCapital.PasswordChar = false;
            this.txtCapital.ReadOnly = false;
            this.txtCapital.Size = new System.Drawing.Size(239, 31);
            this.txtCapital.TabIndex = 1;
            this.txtCapital.Texts = "";
            this.txtCapital.UnderlinedStyle = true;
            // 
            // btnCalcularImporteCuotas
            // 
            this.btnCalcularImporteCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcularImporteCuotas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularImporteCuotas.Location = new System.Drawing.Point(11, 168);
            this.btnCalcularImporteCuotas.Name = "btnCalcularImporteCuotas";
            this.btnCalcularImporteCuotas.Size = new System.Drawing.Size(385, 27);
            this.btnCalcularImporteCuotas.TabIndex = 5;
            this.btnCalcularImporteCuotas.Text = "Calcular";
            this.btnCalcularImporteCuotas.UseVisualStyleBackColor = true;
            this.btnCalcularImporteCuotas.Click += new System.EventHandler(this.btnCalcularImporteCuotas_Click);
            // 
            // cmbFrecuenciaDePagos
            // 
            this.cmbFrecuenciaDePagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFrecuenciaDePagos.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFrecuenciaDePagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecuenciaDePagos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrecuenciaDePagos.FormattingEnabled = true;
            this.cmbFrecuenciaDePagos.Location = new System.Drawing.Point(157, 134);
            this.cmbFrecuenciaDePagos.Name = "cmbFrecuenciaDePagos";
            this.cmbFrecuenciaDePagos.Size = new System.Drawing.Size(239, 24);
            this.cmbFrecuenciaDePagos.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Años";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Frecuencia de Pagos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 37;
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
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Valor del préstamo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelDatosDerecho
            // 
            this.panelDatosDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.panelDatosDerecho.Controls.Add(this.txtSumaDeIntereses);
            this.panelDatosDerecho.Controls.Add(this.txtSumaDeCuotas);
            this.panelDatosDerecho.Controls.Add(this.txtTotalDeCuotas);
            this.panelDatosDerecho.Controls.Add(this.txtPagosPorAnio);
            this.panelDatosDerecho.Controls.Add(this.txtInteresEquivalente);
            this.panelDatosDerecho.Controls.Add(this.label9);
            this.panelDatosDerecho.Controls.Add(this.label10);
            this.panelDatosDerecho.Controls.Add(this.label6);
            this.panelDatosDerecho.Controls.Add(this.label7);
            this.panelDatosDerecho.Controls.Add(this.label100);
            this.panelDatosDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosDerecho.Location = new System.Drawing.Point(403, 0);
            this.panelDatosDerecho.Margin = new System.Windows.Forms.Padding(0);
            this.panelDatosDerecho.Name = "panelDatosDerecho";
            this.panelDatosDerecho.Size = new System.Drawing.Size(403, 207);
            this.panelDatosDerecho.TabIndex = 1;
            // 
            // txtSumaDeIntereses
            // 
            this.txtSumaDeIntereses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumaDeIntereses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtSumaDeIntereses.BorderColor = System.Drawing.Color.DimGray;
            this.txtSumaDeIntereses.BorderFocusColor = System.Drawing.Color.White;
            this.txtSumaDeIntereses.BorderSize = 2;
            this.txtSumaDeIntereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaDeIntereses.ForeColor = System.Drawing.Color.White;
            this.txtSumaDeIntereses.Location = new System.Drawing.Point(172, 163);
            this.txtSumaDeIntereses.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumaDeIntereses.Multiline = false;
            this.txtSumaDeIntereses.Name = "txtSumaDeIntereses";
            this.txtSumaDeIntereses.Padding = new System.Windows.Forms.Padding(7);
            this.txtSumaDeIntereses.PasswordChar = false;
            this.txtSumaDeIntereses.ReadOnly = true;
            this.txtSumaDeIntereses.Size = new System.Drawing.Size(223, 31);
            this.txtSumaDeIntereses.TabIndex = 10;
            this.txtSumaDeIntereses.Texts = "";
            this.txtSumaDeIntereses.UnderlinedStyle = true;
            // 
            // txtSumaDeCuotas
            // 
            this.txtSumaDeCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumaDeCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtSumaDeCuotas.BorderColor = System.Drawing.Color.DimGray;
            this.txtSumaDeCuotas.BorderFocusColor = System.Drawing.Color.White;
            this.txtSumaDeCuotas.BorderSize = 2;
            this.txtSumaDeCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaDeCuotas.ForeColor = System.Drawing.Color.White;
            this.txtSumaDeCuotas.Location = new System.Drawing.Point(172, 125);
            this.txtSumaDeCuotas.Margin = new System.Windows.Forms.Padding(4);
            this.txtSumaDeCuotas.Multiline = false;
            this.txtSumaDeCuotas.Name = "txtSumaDeCuotas";
            this.txtSumaDeCuotas.Padding = new System.Windows.Forms.Padding(7);
            this.txtSumaDeCuotas.PasswordChar = false;
            this.txtSumaDeCuotas.ReadOnly = true;
            this.txtSumaDeCuotas.Size = new System.Drawing.Size(223, 31);
            this.txtSumaDeCuotas.TabIndex = 9;
            this.txtSumaDeCuotas.Texts = "";
            this.txtSumaDeCuotas.UnderlinedStyle = true;
            // 
            // txtTotalDeCuotas
            // 
            this.txtTotalDeCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDeCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtTotalDeCuotas.BorderColor = System.Drawing.Color.DimGray;
            this.txtTotalDeCuotas.BorderFocusColor = System.Drawing.Color.White;
            this.txtTotalDeCuotas.BorderSize = 2;
            this.txtTotalDeCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDeCuotas.ForeColor = System.Drawing.Color.White;
            this.txtTotalDeCuotas.Location = new System.Drawing.Point(172, 87);
            this.txtTotalDeCuotas.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalDeCuotas.Multiline = false;
            this.txtTotalDeCuotas.Name = "txtTotalDeCuotas";
            this.txtTotalDeCuotas.Padding = new System.Windows.Forms.Padding(7);
            this.txtTotalDeCuotas.PasswordChar = false;
            this.txtTotalDeCuotas.ReadOnly = true;
            this.txtTotalDeCuotas.Size = new System.Drawing.Size(223, 31);
            this.txtTotalDeCuotas.TabIndex = 8;
            this.txtTotalDeCuotas.Texts = "";
            this.txtTotalDeCuotas.UnderlinedStyle = true;
            // 
            // txtPagosPorAnio
            // 
            this.txtPagosPorAnio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPagosPorAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtPagosPorAnio.BorderColor = System.Drawing.Color.DimGray;
            this.txtPagosPorAnio.BorderFocusColor = System.Drawing.Color.White;
            this.txtPagosPorAnio.BorderSize = 2;
            this.txtPagosPorAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagosPorAnio.ForeColor = System.Drawing.Color.White;
            this.txtPagosPorAnio.Location = new System.Drawing.Point(172, 49);
            this.txtPagosPorAnio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagosPorAnio.Multiline = false;
            this.txtPagosPorAnio.Name = "txtPagosPorAnio";
            this.txtPagosPorAnio.Padding = new System.Windows.Forms.Padding(7);
            this.txtPagosPorAnio.PasswordChar = false;
            this.txtPagosPorAnio.ReadOnly = true;
            this.txtPagosPorAnio.Size = new System.Drawing.Size(223, 31);
            this.txtPagosPorAnio.TabIndex = 7;
            this.txtPagosPorAnio.Texts = "";
            this.txtPagosPorAnio.UnderlinedStyle = true;
            // 
            // txtInteresEquivalente
            // 
            this.txtInteresEquivalente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInteresEquivalente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.txtInteresEquivalente.BorderColor = System.Drawing.Color.DimGray;
            this.txtInteresEquivalente.BorderFocusColor = System.Drawing.Color.White;
            this.txtInteresEquivalente.BorderSize = 2;
            this.txtInteresEquivalente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteresEquivalente.ForeColor = System.Drawing.Color.White;
            this.txtInteresEquivalente.Location = new System.Drawing.Point(172, 11);
            this.txtInteresEquivalente.Margin = new System.Windows.Forms.Padding(4);
            this.txtInteresEquivalente.Multiline = false;
            this.txtInteresEquivalente.Name = "txtInteresEquivalente";
            this.txtInteresEquivalente.Padding = new System.Windows.Forms.Padding(7);
            this.txtInteresEquivalente.PasswordChar = false;
            this.txtInteresEquivalente.ReadOnly = true;
            this.txtInteresEquivalente.Size = new System.Drawing.Size(223, 31);
            this.txtInteresEquivalente.TabIndex = 6;
            this.txtInteresEquivalente.Texts = "";
            this.txtInteresEquivalente.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Suma de Interes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Suma de Cuotas";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Nº total de cuotas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Nº de pagos por año";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label100
            // 
            this.label100.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.Color.White;
            this.label100.Location = new System.Drawing.Point(21, 26);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(136, 16);
            this.label100.TabIndex = 46;
            this.label100.Text = "Interes Equivalente";
            this.label100.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 41;
            // 
            // FrmPrestamoSistemaFrances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(806, 607);
            this.Controls.Add(this.MainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrestamoSistemaFrances";
            this.Text = "Prestamo Sistema Francés";
            this.Load += new System.EventHandler(this.frmPrestamoSistemaFrances_Load);
            this.MainContainer.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDesglose)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.penelDatosIzquierdo.ResumeLayout(false);
            this.penelDatosIzquierdo.PerformLayout();
            this.panelDatosDerecho.ResumeLayout(false);
            this.panelDatosDerecho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.TableLayoutPanel panelDatos;
        private System.Windows.Forms.Panel penelDatosIzquierdo;
        private System.Windows.Forms.Button btnCalcularImporteCuotas;
        private System.Windows.Forms.ComboBox cmbFrecuenciaDePagos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDatosDerecho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView gridDesglose;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNumeroDeCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCuotaAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCapitalAmortizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCapitalAdeudado;
        private CustomTextBox txtCapital;
        private CustomTextBox txtPeriodoEnAnios;
        private CustomTextBox txtTNA;
        private CustomTextBox txtSumaDeIntereses;
        private CustomTextBox txtSumaDeCuotas;
        private CustomTextBox txtTotalDeCuotas;
        private CustomTextBox txtPagosPorAnio;
        private CustomTextBox txtInteresEquivalente;
        private System.Windows.Forms.TextBox textBox1;
    }
}