namespace CotizadorVillaCoral;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblHuesped = new Label();
        lblNoches = new Label();
        lblTarifa = new Label();
        lblTasa = new Label();
        lblPersonas = new Label();
        txtHuesped = new TextBox();
        nudNoches = new NumericUpDown();
        nudTarifa = new NumericUpDown();
        nudTasa = new NumericUpDown();
        nudPersonas = new NumericUpDown();
        chkFinSemana = new CheckBox();
        flowBotones = new FlowLayoutPanel();
        btnNivel1 = new Button();
        btnPesos = new Button();
        btnPorPersona = new Button();
        btnDeposito = new Button();
        btnFinSemana = new Button();
        btnDesglose = new Button();
        btnTraslado = new Button();
        btnExcursion = new Button();
        btnMinibar = new Button();
        btnCuentaTotal = new Button();
        btnViejo = new Button();
        btnFactura = new Button();
        btnLimpiar = new Button();
        lstResultados = new ListBox();
        ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudTasa).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudPersonas).BeginInit();
        flowBotones.SuspendLayout();
        SuspendLayout();
        // 
        // lblHuesped
        // 
        lblHuesped.AutoSize = true;
        lblHuesped.Location = new Point(20, 23);
        lblHuesped.Name = "lblHuesped";
        lblHuesped.Size = new Size(62, 20);
        lblHuesped.TabIndex = 0;
        lblHuesped.Text = "Huésped";
        // 
        // lblNoches
        // 
        lblNoches.AutoSize = true;
        lblNoches.Location = new Point(440, 23);
        lblNoches.Name = "lblNoches";
        lblNoches.Size = new Size(55, 20);
        lblNoches.TabIndex = 2;
        lblNoches.Text = "Noches";
        // 
        // lblTarifa
        // 
        lblTarifa.AutoSize = true;
        lblTarifa.Location = new Point(600, 23);
        lblTarifa.Name = "lblTarifa";
        lblTarifa.Size = new Size(71, 20);
        lblTarifa.TabIndex = 4;
        lblTarifa.Text = "Tarifa US$";
        // 
        // lblTasa
        // 
        lblTasa.AutoSize = true;
        lblTasa.Location = new Point(20, 63);
        lblTasa.Name = "lblTasa";
        lblTasa.Size = new Size(61, 20);
        lblTasa.TabIndex = 6;
        lblTasa.Text = "Tasa RD$";
        // 
        // lblPersonas
        // 
        lblPersonas.AutoSize = true;
        lblPersonas.Location = new Point(220, 63);
        lblPersonas.Name = "lblPersonas";
        lblPersonas.Size = new Size(62, 20);
        lblPersonas.TabIndex = 8;
        lblPersonas.Text = "Personas";
        // 
        // txtHuesped
        // 
        txtHuesped.Location = new Point(95, 19);
        txtHuesped.Name = "txtHuesped";
        txtHuesped.Size = new Size(320, 27);
        txtHuesped.TabIndex = 1;
        txtHuesped.Text = "Tu Nombre";
        // 
        // nudNoches
        // 
        nudNoches.Location = new Point(510, 19);
        nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudNoches.Name = "nudNoches";
        nudNoches.Size = new Size(70, 27);
        nudNoches.TabIndex = 3;
        nudNoches.Value = new decimal(new int[] { 3, 0, 0, 0 });
        // 
        // nudTarifa
        // 
        nudTarifa.DecimalPlaces = 2;
        nudTarifa.Location = new Point(685, 19);
        nudTarifa.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nudTarifa.Name = "nudTarifa";
        nudTarifa.Size = new Size(100, 27);
        nudTarifa.TabIndex = 5;
        nudTarifa.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // nudTasa
        // 
        nudTasa.DecimalPlaces = 2;
        nudTasa.Location = new Point(95, 59);
        nudTasa.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nudTasa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudTasa.Name = "nudTasa";
        nudTasa.Size = new Size(90, 27);
        nudTasa.TabIndex = 7;
        nudTasa.Value = new decimal(new int[] { 59, 0, 0, 0 });
        // 
        // nudPersonas
        // 
        nudPersonas.Location = new Point(295, 59);
        nudPersonas.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
        nudPersonas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudPersonas.Name = "nudPersonas";
        nudPersonas.Size = new Size(70, 27);
        nudPersonas.TabIndex = 9;
        nudPersonas.Value = new decimal(new int[] { 2, 0, 0, 0 });
        // 
        // chkFinSemana
        // 
        chkFinSemana.AutoSize = true;
        chkFinSemana.Location = new Point(400, 61);
        chkFinSemana.Name = "chkFinSemana";
        chkFinSemana.Size = new Size(159, 24);
        chkFinSemana.TabIndex = 10;
        chkFinSemana.Text = "Fin de semana (+15%)";
        chkFinSemana.UseVisualStyleBackColor = true;
        // 
        // flowBotones
        // 
        flowBotones.AutoScroll = true;
        flowBotones.Controls.Add(btnNivel1);
        flowBotones.Controls.Add(btnPesos);
        flowBotones.Controls.Add(btnPorPersona);
        flowBotones.Controls.Add(btnDeposito);
        flowBotones.Controls.Add(btnFinSemana);
        flowBotones.Controls.Add(btnDesglose);
        flowBotones.Controls.Add(btnTraslado);
        flowBotones.Controls.Add(btnExcursion);
        flowBotones.Controls.Add(btnMinibar);
        flowBotones.Controls.Add(btnCuentaTotal);
        flowBotones.Controls.Add(btnViejo);
        flowBotones.Controls.Add(btnFactura);
        flowBotones.Controls.Add(btnLimpiar);
        flowBotones.Location = new Point(20, 100);
        flowBotones.Name = "flowBotones";
        flowBotones.Size = new Size(930, 115);
        flowBotones.TabIndex = 11;
        // 
        // btnNivel1
        // 
        btnNivel1.AutoSize = true;
        btnNivel1.Margin = new Padding(5);
        btnNivel1.Name = "btnNivel1";
        btnNivel1.Size = new Size(70, 30);
        btnNivel1.TabIndex = 0;
        btnNivel1.Text = "Nivel 1";
        btnNivel1.UseVisualStyleBackColor = true;
        btnNivel1.Click += btnNivel1_Click;
        // 
        // btnPesos
        // 
        btnPesos.AutoSize = true;
        btnPesos.Margin = new Padding(5);
        btnPesos.Name = "btnPesos";
        btnPesos.Size = new Size(100, 30);
        btnPesos.TabIndex = 1;
        btnPesos.Text = "Total en RD$";
        btnPesos.UseVisualStyleBackColor = true;
        btnPesos.Click += btnPesos_Click;
        // 
        // btnPorPersona
        // 
        btnPorPersona.AutoSize = true;
        btnPorPersona.Margin = new Padding(5);
        btnPorPersona.Name = "btnPorPersona";
        btnPorPersona.Size = new Size(95, 30);
        btnPorPersona.TabIndex = 2;
        btnPorPersona.Text = "Por persona";
        btnPorPersona.UseVisualStyleBackColor = true;
        btnPorPersona.Click += btnPorPersona_Click;
        // 
        // btnDeposito
        // 
        btnDeposito.AutoSize = true;
        btnDeposito.Margin = new Padding(5);
        btnDeposito.Name = "btnDeposito";
        btnDeposito.Size = new Size(130, 30);
        btnDeposito.TabIndex = 3;
        btnDeposito.Text = "Depósito y saldo";
        btnDeposito.UseVisualStyleBackColor = true;
        btnDeposito.Click += btnDeposito_Click;
        // 
        // btnFinSemana
        // 
        btnFinSemana.AutoSize = true;
        btnFinSemana.Margin = new Padding(5);
        btnFinSemana.Name = "btnFinSemana";
        btnFinSemana.Size = new Size(110, 30);
        btnFinSemana.TabIndex = 4;
        btnFinSemana.Text = "Fin de semana";
        btnFinSemana.UseVisualStyleBackColor = true;
        btnFinSemana.Click += btnFinSemana_Click;
        // 
        // btnDesglose
        // 
        btnDesglose.AutoSize = true;
        btnDesglose.Margin = new Padding(5);
        btnDesglose.Name = "btnDesglose";
        btnDesglose.Size = new Size(80, 30);
        btnDesglose.TabIndex = 5;
        btnDesglose.Text = "Desglose";
        btnDesglose.UseVisualStyleBackColor = true;
        btnDesglose.Click += btnDesglose_Click;
        // 
        // btnTraslado
        // 
        btnTraslado.AutoSize = true;
        btnTraslado.Margin = new Padding(5);
        btnTraslado.Name = "btnTraslado";
        btnTraslado.Size = new Size(75, 30);
        btnTraslado.TabIndex = 6;
        btnTraslado.Text = "Traslado";
        btnTraslado.UseVisualStyleBackColor = true;
        btnTraslado.Click += btnTraslado_Click;
        // 
        // btnExcursion
        // 
        btnExcursion.AutoSize = true;
        btnExcursion.Margin = new Padding(5);
        btnExcursion.Name = "btnExcursion";
        btnExcursion.Size = new Size(80, 30);
        btnExcursion.TabIndex = 7;
        btnExcursion.Text = "Excursión";
        btnExcursion.UseVisualStyleBackColor = true;
        btnExcursion.Click += btnExcursion_Click;
        // 
        // btnMinibar
        // 
        btnMinibar.AutoSize = true;
        btnMinibar.Margin = new Padding(5);
        btnMinibar.Name = "btnMinibar";
        btnMinibar.Size = new Size(75, 30);
        btnMinibar.TabIndex = 8;
        btnMinibar.Text = "Minibar";
        btnMinibar.UseVisualStyleBackColor = true;
        btnMinibar.Click += btnMinibar_Click;
        // 
        // btnCuentaTotal
        // 
        btnCuentaTotal.AutoSize = true;
        btnCuentaTotal.Margin = new Padding(5);
        btnCuentaTotal.Name = "btnCuentaTotal";
        btnCuentaTotal.Size = new Size(100, 30);
        btnCuentaTotal.TabIndex = 9;
        btnCuentaTotal.Text = "Cuenta total";
        btnCuentaTotal.UseVisualStyleBackColor = true;
        btnCuentaTotal.Click += btnCuentaTotal_Click;
        // 
        // btnViejo
        // 
        btnViejo.AutoSize = true;
        btnViejo.Margin = new Padding(5);
        btnViejo.Name = "btnViejo";
        btnViejo.Size = new Size(140, 30);
        btnViejo.TabIndex = 10;
        btnViejo.Text = "Probar sistema viejo";
        btnViejo.UseVisualStyleBackColor = true;
        btnViejo.Click += btnViejo_Click;
        // 
        // btnFactura
        // 
        btnFactura.AutoSize = true;
        btnFactura.Margin = new Padding(5);
        btnFactura.Name = "btnFactura";
        btnFactura.Size = new Size(75, 30);
        btnFactura.TabIndex = 11;
        btnFactura.Text = "Factura";
        btnFactura.UseVisualStyleBackColor = true;
        btnFactura.Click += btnFactura_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.AutoSize = true;
        btnLimpiar.Margin = new Padding(5);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(70, 30);
        btnLimpiar.TabIndex = 12;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // lstResultados
        // 
        lstResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        lstResultados.Font = new Font("Consolas", 10F);
        lstResultados.FormattingEnabled = true;
        lstResultados.ItemHeight = 20;
        lstResultados.Location = new Point(20, 230);
        lstResultados.Name = "lstResultados";
        lstResultados.Size = new Size(930, 344);
        lstResultados.TabIndex = 12;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(980, 600);
        Controls.Add(lstResultados);
        Controls.Add(flowBotones);
        Controls.Add(chkFinSemana);
        Controls.Add(nudPersonas);
        Controls.Add(lblPersonas);
        Controls.Add(nudTasa);
        Controls.Add(lblTasa);
        Controls.Add(nudTarifa);
        Controls.Add(lblTarifa);
        Controls.Add(nudNoches);
        Controls.Add(lblNoches);
        Controls.Add(txtHuesped);
        Controls.Add(lblHuesped);
        MinimumSize = new Size(800, 500);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Cotizador Villa Coral · Tu Nombre · TuMatricula";
        ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudTasa).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudPersonas).EndInit();
        flowBotones.ResumeLayout(false);
        flowBotones.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblHuesped;
    private Label lblNoches;
    private Label lblTarifa;
    private Label lblTasa;
    private Label lblPersonas;
    private TextBox txtHuesped;
    private NumericUpDown nudNoches;
    private NumericUpDown nudTarifa;
    private NumericUpDown nudTasa;
    private NumericUpDown nudPersonas;
    private CheckBox chkFinSemana;
    private FlowLayoutPanel flowBotones;
    private Button btnNivel1;
    private Button btnPesos;
    private Button btnPorPersona;
    private Button btnDeposito;
    private Button btnFinSemana;
    private Button btnDesglose;
    private Button btnTraslado;
    private Button btnExcursion;
    private Button btnMinibar;
    private Button btnCuentaTotal;
    private Button btnViejo;
    private Button btnFactura;
    private Button btnLimpiar;
    private ListBox lstResultados;
}
