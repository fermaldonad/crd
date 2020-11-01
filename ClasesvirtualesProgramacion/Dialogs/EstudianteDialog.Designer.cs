namespace ClasesvirtualesProgramacion.Dialogs
{
    partial class EstudianteDialog
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
            System.Windows.Forms.Label identidadLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label fechanacLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label obsLabel;
            this.identidadTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.fechanacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            identidadLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            fechanacLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(428, 160);
            this.btnGuardar.Size = new System.Drawing.Size(78, 23);
            this.btnGuardar.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(509, 160);
            this.btnCancelar.Size = new System.Drawing.Size(78, 23);
            this.btnCancelar.TabIndex = 8;
            // 
            // identidadLabel
            // 
            identidadLabel.AutoSize = true;
            identidadLabel.Location = new System.Drawing.Point(43, 9);
            identidadLabel.Name = "identidadLabel";
            identidadLabel.Size = new System.Drawing.Size(54, 13);
            identidadLabel.TabIndex = 3;
            identidadLabel.Text = "Identidad:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(45, 35);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 5;
            nombresLabel.Text = "Nombres:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(326, 35);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 7;
            apellidosLabel.Text = "Apellidos:";
            // 
            // fechanacLabel
            // 
            fechanacLabel.AutoSize = true;
            fechanacLabel.Location = new System.Drawing.Point(216, 9);
            fechanacLabel.Name = "fechanacLabel";
            fechanacLabel.Size = new System.Drawing.Size(60, 13);
            fechanacLabel.TabIndex = 9;
            fechanacLabel.Text = "Nacimiento";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(408, 9);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(45, 72);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(52, 13);
            direccionLabel.TabIndex = 13;
            direccionLabel.Text = "Direción :";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(13, 113);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(84, 13);
            obsLabel.TabIndex = 15;
            obsLabel.Text = "Observaciones :";
            // 
            // identidadTextBox
            // 
            this.identidadTextBox.Location = new System.Drawing.Point(104, 5);
            this.identidadTextBox.Name = "identidadTextBox";
            this.identidadTextBox.Size = new System.Drawing.Size(92, 20);
            this.identidadTextBox.TabIndex = 0;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombresTextBox.Location = new System.Drawing.Point(104, 32);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 3;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apellidosTextBox.Location = new System.Drawing.Point(387, 31);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidosTextBox.TabIndex = 4;
            // 
            // fechanacDateTimePicker
            // 
            this.fechanacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechanacDateTimePicker.Location = new System.Drawing.Point(277, 5);
            this.fechanacDateTimePicker.Name = "fechanacDateTimePicker";
            this.fechanacDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fechanacDateTimePicker.TabIndex = 1;
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.sexoComboBox.Location = new System.Drawing.Point(448, 5);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(139, 21);
            this.sexoComboBox.TabIndex = 2;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.direccionTextBox.Location = new System.Drawing.Point(112, 61);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(475, 45);
            this.direccionTextBox.TabIndex = 5;
            // 
            // obsTextBox
            // 
            this.obsTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.obsTextBox.Location = new System.Drawing.Point(112, 109);
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(475, 45);
            this.obsTextBox.TabIndex = 6;
            // 
            // EstudianteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 197);
            this.Controls.Add(identidadLabel);
            this.Controls.Add(this.identidadTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(fechanacLabel);
            this.Controls.Add(this.fechanacDateTimePicker);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoComboBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.obsTextBox);
            this.Name = "EstudianteDialog";
            this.Text = "Información de Estudiantes";
            
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.obsTextBox, 0);
            this.Controls.SetChildIndex(obsLabel, 0);
            this.Controls.SetChildIndex(this.direccionTextBox, 0);
            this.Controls.SetChildIndex(direccionLabel, 0);
            this.Controls.SetChildIndex(this.sexoComboBox, 0);
            this.Controls.SetChildIndex(sexoLabel, 0);
            this.Controls.SetChildIndex(this.fechanacDateTimePicker, 0);
            this.Controls.SetChildIndex(fechanacLabel, 0);
            this.Controls.SetChildIndex(this.apellidosTextBox, 0);
            this.Controls.SetChildIndex(apellidosLabel, 0);
            this.Controls.SetChildIndex(this.nombresTextBox, 0);
            this.Controls.SetChildIndex(nombresLabel, 0);
            this.Controls.SetChildIndex(this.identidadTextBox, 0);
            this.Controls.SetChildIndex(identidadLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker fechanacDateTimePicker;
        public System.Windows.Forms.TextBox identidadTextBox;
        public System.Windows.Forms.TextBox nombresTextBox;
        public System.Windows.Forms.TextBox apellidosTextBox;
        public System.Windows.Forms.ComboBox sexoComboBox;
        public System.Windows.Forms.TextBox direccionTextBox;
        public System.Windows.Forms.TextBox obsTextBox;
    }
}