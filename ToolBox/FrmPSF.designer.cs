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
            this.components = new System.ComponentModel.Container();
            this.errError = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.btnCalcularImporteCuotas = new System.Windows.Forms.Button();
            this.cmbFrecuenciaDePagos = new System.Windows.Forms.ComboBox();
            this.txtPeriodoEnAnios = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDatosDerecho = new System.Windows.Forms.Panel();
            this.txtSumaDeIntereses = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSumaDeCuotas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalDeCuotas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPagosPorAnio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInteresEquivalente = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errError)).BeginInit();
            this.MainContainer.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDesglose)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.penelDatosIzquierdo.SuspendLayout();
            this.panelDatosDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // errError
            // 
            this.errError.ContainerControl = this;
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
            this.panelData.Location = new System.Drawing.Point(0, 159);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(806, 448);
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
            this.gridDesglose.Location = new System.Drawing.Point(12, 9);
            this.gridDesglose.Name = "gridDesglose";
            this.gridDesglose.Size = new System.Drawing.Size(786, 431);
            this.gridDesglose.TabIndex = 36;
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
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.panelDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.panelDatos.Size = new System.Drawing.Size(806, 159);
            this.panelDatos.TabIndex = 46;
            // 
            // penelDatosIzquierdo
            // 
            this.penelDatosIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.penelDatosIzquierdo.Controls.Add(this.btnCalcularImporteCuotas);
            this.penelDatosIzquierdo.Controls.Add(this.cmbFrecuenciaDePagos);
            this.penelDatosIzquierdo.Controls.Add(this.txtPeriodoEnAnios);
            this.penelDatosIzquierdo.Controls.Add(this.label5);
            this.penelDatosIzquierdo.Controls.Add(this.label4);
            this.penelDatosIzquierdo.Controls.Add(this.txtTNA);
            this.penelDatosIzquierdo.Controls.Add(this.label3);
            this.penelDatosIzquierdo.Controls.Add(this.txtCapital);
            this.penelDatosIzquierdo.Controls.Add(this.label2);
            this.penelDatosIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.penelDatosIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.penelDatosIzquierdo.Margin = new System.Windows.Forms.Padding(0);
            this.penelDatosIzquierdo.Name = "penelDatosIzquierdo";
            this.penelDatosIzquierdo.Size = new System.Drawing.Size(403, 159);
            this.penelDatosIzquierdo.TabIndex = 0;
            // 
            // btnCalcularImporteCuotas
            // 
            this.btnCalcularImporteCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcularImporteCuotas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularImporteCuotas.Location = new System.Drawing.Point(11, 121);
            this.btnCalcularImporteCuotas.Name = "btnCalcularImporteCuotas";
            this.btnCalcularImporteCuotas.Size = new System.Drawing.Size(385, 27);
            this.btnCalcularImporteCuotas.TabIndex = 43;
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
            this.cmbFrecuenciaDePagos.Location = new System.Drawing.Point(157, 86);
            this.cmbFrecuenciaDePagos.Name = "cmbFrecuenciaDePagos";
            this.cmbFrecuenciaDePagos.Size = new System.Drawing.Size(239, 24);
            this.cmbFrecuenciaDePagos.TabIndex = 42;
            // 
            // txtPeriodoEnAnios
            // 
            this.txtPeriodoEnAnios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriodoEnAnios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodoEnAnios.Location = new System.Drawing.Point(157, 60);
            this.txtPeriodoEnAnios.Name = "txtPeriodoEnAnios";
            this.txtPeriodoEnAnios.Size = new System.Drawing.Size(239, 23);
            this.txtPeriodoEnAnios.TabIndex = 41;
            this.txtPeriodoEnAnios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 63);
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
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Frecuencia de Pagos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTNA
            // 
            this.txtTNA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTNA.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTNA.Location = new System.Drawing.Point(157, 34);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.Size = new System.Drawing.Size(239, 23);
            this.txtTNA.TabIndex = 38;
            this.txtTNA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "TNA %";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCapital
            // 
            this.txtCapital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCapital.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.Location = new System.Drawing.Point(157, 8);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(239, 23);
            this.txtCapital.TabIndex = 36;
            this.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 11);
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
            this.panelDatosDerecho.Controls.Add(this.label9);
            this.panelDatosDerecho.Controls.Add(this.txtSumaDeCuotas);
            this.panelDatosDerecho.Controls.Add(this.label10);
            this.panelDatosDerecho.Controls.Add(this.txtTotalDeCuotas);
            this.panelDatosDerecho.Controls.Add(this.label6);
            this.panelDatosDerecho.Controls.Add(this.txtPagosPorAnio);
            this.panelDatosDerecho.Controls.Add(this.label7);
            this.panelDatosDerecho.Controls.Add(this.txtInteresEquivalente);
            this.panelDatosDerecho.Controls.Add(this.label100);
            this.panelDatosDerecho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatosDerecho.Location = new System.Drawing.Point(403, 0);
            this.panelDatosDerecho.Margin = new System.Windows.Forms.Padding(0);
            this.panelDatosDerecho.Name = "panelDatosDerecho";
            this.panelDatosDerecho.Size = new System.Drawing.Size(403, 159);
            this.panelDatosDerecho.TabIndex = 1;
            // 
            // txtSumaDeIntereses
            // 
            this.txtSumaDeIntereses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumaDeIntereses.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaDeIntereses.Location = new System.Drawing.Point(175, 124);
            this.txtSumaDeIntereses.Name = "txtSumaDeIntereses";
            this.txtSumaDeIntereses.ReadOnly = true;
            this.txtSumaDeIntereses.Size = new System.Drawing.Size(220, 23);
            this.txtSumaDeIntereses.TabIndex = 55;
            this.txtSumaDeIntereses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Suma de Interes";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSumaDeCuotas
            // 
            this.txtSumaDeCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSumaDeCuotas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumaDeCuotas.Location = new System.Drawing.Point(175, 95);
            this.txtSumaDeCuotas.Name = "txtSumaDeCuotas";
            this.txtSumaDeCuotas.ReadOnly = true;
            this.txtSumaDeCuotas.Size = new System.Drawing.Size(220, 23);
            this.txtSumaDeCuotas.TabIndex = 53;
            this.txtSumaDeCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Suma de Cuotas";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalDeCuotas
            // 
            this.txtTotalDeCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalDeCuotas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDeCuotas.Location = new System.Drawing.Point(175, 66);
            this.txtTotalDeCuotas.Name = "txtTotalDeCuotas";
            this.txtTotalDeCuotas.ReadOnly = true;
            this.txtTotalDeCuotas.Size = new System.Drawing.Size(220, 23);
            this.txtTotalDeCuotas.TabIndex = 51;
            this.txtTotalDeCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Nº total de cuotas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPagosPorAnio
            // 
            this.txtPagosPorAnio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPagosPorAnio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagosPorAnio.Location = new System.Drawing.Point(175, 37);
            this.txtPagosPorAnio.Name = "txtPagosPorAnio";
            this.txtPagosPorAnio.ReadOnly = true;
            this.txtPagosPorAnio.Size = new System.Drawing.Size(220, 23);
            this.txtPagosPorAnio.TabIndex = 49;
            this.txtPagosPorAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Nº de pagos por año";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInteresEquivalente
            // 
            this.txtInteresEquivalente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInteresEquivalente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteresEquivalente.Location = new System.Drawing.Point(175, 8);
            this.txtInteresEquivalente.Name = "txtInteresEquivalente";
            this.txtInteresEquivalente.ReadOnly = true;
            this.txtInteresEquivalente.Size = new System.Drawing.Size(220, 23);
            this.txtInteresEquivalente.TabIndex = 47;
            this.txtInteresEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label100
            // 
            this.label100.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.Color.White;
            this.label100.Location = new System.Drawing.Point(21, 11);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(136, 16);
            this.label100.TabIndex = 46;
            this.label100.Text = "Interes Equivalente";
            this.label100.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            ((System.ComponentModel.ISupportInitialize)(this.errError)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errError;
        private System.Windows.Forms.Panel MainContainer;
        private System.Windows.Forms.TableLayoutPanel panelDatos;
        private System.Windows.Forms.Panel penelDatosIzquierdo;
        private System.Windows.Forms.Button btnCalcularImporteCuotas;
        private System.Windows.Forms.ComboBox cmbFrecuenciaDePagos;
        private System.Windows.Forms.TextBox txtPeriodoEnAnios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDatosDerecho;
        private System.Windows.Forms.TextBox txtSumaDeIntereses;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSumaDeCuotas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalDeCuotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPagosPorAnio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInteresEquivalente;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView gridDesglose;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNumeroDeCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCuotaAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCapitalAmortizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCapitalAdeudado;
    }
}