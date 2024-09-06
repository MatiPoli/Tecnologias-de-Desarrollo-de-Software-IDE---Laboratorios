namespace WinForms
{
    partial class AlumnoLista
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
            eliminarButton = new Button();
            modificarButton = new Button();
            agregarButton = new Button();
            alumnosDataGridView = new DataGridView();
            provinciasButton = new Button();
            ((System.ComponentModel.ISupportInitialize)alumnosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(522, 429);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(81, 22);
            eliminarButton.TabIndex = 3;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(607, 429);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(81, 22);
            modificarButton.TabIndex = 4;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(692, 429);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(81, 22);
            agregarButton.TabIndex = 5;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // alumnosDataGridView
            // 
            alumnosDataGridView.AllowUserToOrderColumns = true;
            alumnosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            alumnosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alumnosDataGridView.Location = new Point(12, 12);
            alumnosDataGridView.MultiSelect = false;
            alumnosDataGridView.Name = "alumnosDataGridView";
            alumnosDataGridView.ReadOnly = true;
            alumnosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            alumnosDataGridView.Size = new Size(760, 413);
            alumnosDataGridView.TabIndex = 6;
            alumnosDataGridView.CellContentClick += alumnosDataGridView_CellContentClick;
            // 
            // provinciasButton
            // 
            provinciasButton.Location = new Point(12, 431);
            provinciasButton.Name = "provinciasButton";
            provinciasButton.Size = new Size(115, 23);
            provinciasButton.TabIndex = 7;
            provinciasButton.Text = "Listado Provincias";
            provinciasButton.UseVisualStyleBackColor = true;
            provinciasButton.Click += provinciasButton_Click;
            // 
            // AlumnoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(provinciasButton);
            Controls.Add(alumnosDataGridView);
            Controls.Add(agregarButton);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AlumnoLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Universidad";
            Load += AlumnoLista_Load;
            ((System.ComponentModel.ISupportInitialize)alumnosDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button eliminarButton;
        private Button modificarButton;
        private Button agregarButton;
        private DataGridView alumnosDataGridView;
        private Button provinciasButton;
    }
}
