namespace ClasesvirtualesProgramacion.Dialogs
{
    partial class GastosDialogs
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label categoria_Label;
            System.Windows.Forms.Label subcategoriaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label formapagoLabel;
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.subcategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.formapagoComboBox = new System.Windows.Forms.ComboBox();
            fechaLabel = new System.Windows.Forms.Label();
            categoria_Label = new System.Windows.Forms.Label();
            subcategoriaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            formapagoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(416, 213);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(497, 213);
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(78, 18);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 1;
            fechaLabel.Text = "Fecha:";
            // 
            // categoria_Label
            // 
            categoria_Label.AutoSize = true;
            categoria_Label.Location = new System.Drawing.Point(60, 68);
            categoria_Label.Name = "categoria_Label";
            categoria_Label.Size = new System.Drawing.Size(58, 13);
            categoria_Label.TabIndex = 3;
            categoria_Label.Text = "Categoria :";
            // 
            // subcategoriaLabel
            // 
            subcategoriaLabel.AutoSize = true;
            subcategoriaLabel.Location = new System.Drawing.Point(45, 103);
            subcategoriaLabel.Name = "subcategoriaLabel";
            subcategoriaLabel.Size = new System.Drawing.Size(73, 13);
            subcategoriaLabel.TabIndex = 5;
            subcategoriaLabel.Text = "Subcategoria:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(52, 141);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 7;
            descripcionLabel.Text = "Descripción:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(225, 19);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 9;
            valorLabel.Text = "Valor:";
            // 
            // formapagoLabel
            // 
            formapagoLabel.AutoSize = true;
            formapagoLabel.Location = new System.Drawing.Point(362, 19);
            formapagoLabel.Name = "formapagoLabel";
            formapagoLabel.Size = new System.Drawing.Size(70, 13);
            formapagoLabel.TabIndex = 11;
            formapagoLabel.Text = "Forma Pago :";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(124, 12);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(84, 20);
            this.fechaDateTimePicker.TabIndex = 2;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "Alimentos",
            "Transporte",
            "Hogar",
            "Lavanderia",
            "Diversion",
            "Personal"});
            this.categoriaComboBox.Location = new System.Drawing.Point(124, 60);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(469, 21);
            this.categoriaComboBox.TabIndex = 4;
            // 
            // subcategoriaComboBox
            // 
            this.subcategoriaComboBox.FormattingEnabled = true;
            this.subcategoriaComboBox.Items.AddRange(new object[] {
            "Supermercado",
            "Kiosko",
            "Restaurante",
            "Taxi ",
            "Bus",
            "Mototaxi",
            "Electricidad",
            "Agua ",
            "Telefono",
            "Jabon",
            "Detergente",
            "Cine",
            "Viaje",
            "Otros"});
            this.subcategoriaComboBox.Location = new System.Drawing.Point(124, 95);
            this.subcategoriaComboBox.Name = "subcategoriaComboBox";
            this.subcategoriaComboBox.Size = new System.Drawing.Size(468, 21);
            this.subcategoriaComboBox.TabIndex = 6;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(124, 122);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(469, 63);
            this.descripcionTextBox.TabIndex = 8;
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(265, 12);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(80, 20);
            this.nudValor.TabIndex = 10;
            // 
            // formapagoComboBox
            // 
            this.formapagoComboBox.FormattingEnabled = true;
            this.formapagoComboBox.Items.AddRange(new object[] {
            "Efectivo",
            "Crédito ",
            "Tarjeta de Crédito"});
            this.formapagoComboBox.Location = new System.Drawing.Point(438, 12);
            this.formapagoComboBox.Name = "formapagoComboBox";
            this.formapagoComboBox.Size = new System.Drawing.Size(141, 21);
            this.formapagoComboBox.TabIndex = 12;
            // 
            // GastosDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 243);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(categoria_Label);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(subcategoriaLabel);
            this.Controls.Add(this.subcategoriaComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(formapagoLabel);
            this.Controls.Add(this.formapagoComboBox);
            this.Name = "GastosDialogs";
            this.Text = "Informacion de Gastos";
            this.Controls.SetChildIndex(this.formapagoComboBox, 0);
            this.Controls.SetChildIndex(formapagoLabel, 0);
            this.Controls.SetChildIndex(this.nudValor, 0);
            this.Controls.SetChildIndex(valorLabel, 0);
            this.Controls.SetChildIndex(this.descripcionTextBox, 0);
            this.Controls.SetChildIndex(descripcionLabel, 0);
            this.Controls.SetChildIndex(this.subcategoriaComboBox, 0);
            this.Controls.SetChildIndex(subcategoriaLabel, 0);
            this.Controls.SetChildIndex(this.categoriaComboBox, 0);
            this.Controls.SetChildIndex(categoria_Label, 0);
            this.Controls.SetChildIndex(this.fechaDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaLabel, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        public System.Windows.Forms.ComboBox categoriaComboBox;
        public System.Windows.Forms.ComboBox subcategoriaComboBox;
        public System.Windows.Forms.TextBox descripcionTextBox;
        public System.Windows.Forms.NumericUpDown nudValor;
        public System.Windows.Forms.ComboBox formapagoComboBox;
        
    }
}