using System;

namespace CapaPresentacion
{
    partial class Nivel1
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
            txtHuesped = new TextBox();
            nudTarifa = new NumericUpDown();
            chkFinSemana = new CheckBox();
            Btn_Cerrar = new Button();
            lstResultados = new ListBox();
            btn_Calcular1 = new Button();
            Btn_Limpiar = new Button();
            nudNoches = new NumericUpDown();
            label1 = new Label();
            Tarifa = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            SuspendLayout();
            // 
            // txtHuesped
            // 
            txtHuesped.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            txtHuesped.Location = new Point(12, 139);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(337, 30);
            txtHuesped.TabIndex = 0;
            txtHuesped.TextChanged += txtHuesped_TextChanged;
            // 
            // nudTarifa
            // 
            nudTarifa.Location = new Point(504, 139);
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(120, 27);
            nudTarifa.TabIndex = 8;
            // 
            // chkFinSemana
            // 
            chkFinSemana.AutoSize = true;
            chkFinSemana.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkFinSemana.Location = new Point(663, 141);
            chkFinSemana.Name = "chkFinSemana";
            chkFinSemana.Size = new Size(124, 27);
            chkFinSemana.TabIndex = 2;
            chkFinSemana.Text = "Fin Semana";
            chkFinSemana.UseVisualStyleBackColor = true;
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.BackColor = Color.Red;
            Btn_Cerrar.ForeColor = SystemColors.InactiveBorder;
            Btn_Cerrar.Location = new Point(763, 12);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(52, 37);
            Btn_Cerrar.TabIndex = 4;
            Btn_Cerrar.Text = "X";
            Btn_Cerrar.UseVisualStyleBackColor = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // lstResultados
            // 
            lstResultados.BackColor = SystemColors.InactiveCaption;
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(113, 257);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(576, 264);
            lstResultados.TabIndex = 5;
            lstResultados.SelectedIndexChanged += lstResultados_SelectedIndexChanged;
            // 
            // btn_Calcular1
            // 
            btn_Calcular1.BackColor = Color.FromArgb(0, 192, 0);
            btn_Calcular1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calcular1.Location = new Point(463, 195);
            btn_Calcular1.Name = "btn_Calcular1";
            btn_Calcular1.Size = new Size(94, 29);
            btn_Calcular1.TabIndex = 6;
            btn_Calcular1.Text = "Calcular";
            btn_Calcular1.UseVisualStyleBackColor = false;
            btn_Calcular1.Click += btn_Calcular1_Click;
            // 
            // Btn_Limpiar
            // 
            Btn_Limpiar.BackColor = Color.FromArgb(255, 192, 128);
            Btn_Limpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_Limpiar.Location = new Point(595, 195);
            Btn_Limpiar.Name = "Btn_Limpiar";
            Btn_Limpiar.Size = new Size(94, 29);
            Btn_Limpiar.TabIndex = 7;
            Btn_Limpiar.Text = "Limpiar";
            Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(369, 139);
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(120, 27);
            nudNoches.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 116);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 9;
            label1.Text = "Noches";
            // 
            // Tarifa
            // 
            Tarifa.AutoSize = true;
            Tarifa.Location = new Point(533, 116);
            Tarifa.Name = "Tarifa";
            Tarifa.Size = new Size(45, 20);
            Tarifa.TabIndex = 10;
            Tarifa.Text = "Tarifa";
            // 
            // Nivel1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(827, 615);
            Controls.Add(Tarifa);
            Controls.Add(label1);
            Controls.Add(nudNoches);
            Controls.Add(Btn_Limpiar);
            Controls.Add(btn_Calcular1);
            Controls.Add(lstResultados);
            Controls.Add(Btn_Cerrar);
            Controls.Add(chkFinSemana);
            Controls.Add(nudTarifa);
            Controls.Add(txtHuesped);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Nivel1";
            StartPosition = FormStartPosition.Manual;
            Text = "Nivel 1";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHuesped;
        private NumericUpDown nudTarifa;
        private CheckBox chkFinSemana;
        private Button Btn_Cerrar;
        private ListBox lstResultados;
        private Button btn_Calcular1;
        private Button Btn_Limpiar;
        private NumericUpDown nudNoches;
        private Label label1;
        private Label Tarifa;
    }
}