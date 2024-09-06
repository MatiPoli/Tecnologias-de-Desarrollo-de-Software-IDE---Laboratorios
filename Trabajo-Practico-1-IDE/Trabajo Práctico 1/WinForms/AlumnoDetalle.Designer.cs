namespace WindowsForms
{
    partial class AlumnoDetalle
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
            components = new System.ComponentModel.Container();
            nombreTextBox = new TextBox();
            aceptarButton = new Button();
            errorProvider = new ErrorProvider(components);
            cancelarButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            apellidoTextBox = new TextBox();
            legajoTextBox = new TextBox();
            direccionTextBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            provinciaBox = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(100, 54);
            nombreTextBox.Margin = new Padding(2, 1, 2, 1);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(110, 23);
            nombreTextBox.TabIndex = 2;
            // 
            // aceptarButton
            // 
            aceptarButton.Location = new Point(24, 208);
            aceptarButton.Margin = new Padding(2, 1, 2, 1);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(81, 22);
            aceptarButton.TabIndex = 6;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = true;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(129, 208);
            cancelarButton.Margin = new Padding(2, 1, 2, 1);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(81, 22);
            cancelarButton.TabIndex = 7;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Legajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 130);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(100, 19);
            apellidoTextBox.Margin = new Padding(2, 1, 2, 1);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(110, 23);
            apellidoTextBox.TabIndex = 1;
            // 
            // legajoTextBox
            // 
            legajoTextBox.Location = new Point(100, 89);
            legajoTextBox.Margin = new Padding(2, 1, 2, 1);
            legajoTextBox.Name = "legajoTextBox";
            legajoTextBox.Size = new Size(110, 23);
            legajoTextBox.TabIndex = 3;
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(100, 127);
            direccionTextBox.Margin = new Padding(2, 1, 2, 1);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(110, 23);
            direccionTextBox.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // provinciaBox
            // 
            provinciaBox.FormattingEnabled = true;
            provinciaBox.Location = new Point(100, 164);
            provinciaBox.Name = "provinciaBox";
            provinciaBox.Size = new Size(110, 23);
            provinciaBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 167);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "Provincia";
            // 
            // AlumnoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 246);
            Controls.Add(label5);
            Controls.Add(provinciaBox);
            Controls.Add(direccionTextBox);
            Controls.Add(legajoTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(nombreTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            Name = "AlumnoDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Alumno";
            Load += AlumnoDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private Button aceptarButton;
        private ErrorProvider errorProvider;
        private Button cancelarButton;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox direccionTextBox;
        private TextBox legajoTextBox;
        private TextBox apellidoTextBox;
        private ErrorProvider errorProvider1;
        private Label label5;
        private ComboBox provinciaBox;
    }
}