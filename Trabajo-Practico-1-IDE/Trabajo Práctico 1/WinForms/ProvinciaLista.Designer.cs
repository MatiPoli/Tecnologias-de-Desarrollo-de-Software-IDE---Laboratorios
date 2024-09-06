namespace WinForms
{
    partial class ProvinciaLista
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
            provinciasDataGridView = new DataGridView();
            agregarButton = new Button();
            modificarButton = new Button();
            eliminarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)provinciasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // provinciasDataGridView
            // 
            provinciasDataGridView.AllowUserToOrderColumns = true;
            provinciasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            provinciasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            provinciasDataGridView.Location = new Point(12, 12);
            provinciasDataGridView.MultiSelect = false;
            provinciasDataGridView.Name = "provinciasDataGridView";
            provinciasDataGridView.ReadOnly = true;
            provinciasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            provinciasDataGridView.Size = new Size(260, 116);
            provinciasDataGridView.TabIndex = 7;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(181, 132);
            agregarButton.Margin = new Padding(2, 1, 2, 1);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(81, 22);
            agregarButton.TabIndex = 10;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // modificarButton
            // 
            modificarButton.Location = new Point(96, 132);
            modificarButton.Margin = new Padding(2, 1, 2, 1);
            modificarButton.Name = "modificarButton";
            modificarButton.Size = new Size(81, 22);
            modificarButton.TabIndex = 9;
            modificarButton.Text = "Modificar";
            modificarButton.UseVisualStyleBackColor = true;
            modificarButton.Click += modificarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(11, 132);
            eliminarButton.Margin = new Padding(2, 1, 2, 1);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(81, 22);
            eliminarButton.TabIndex = 8;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // ProvinciaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(agregarButton);
            Controls.Add(modificarButton);
            Controls.Add(eliminarButton);
            Controls.Add(provinciasDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProvinciaLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Provincia";
            Load += ProvinciaLista_Load;
            ((System.ComponentModel.ISupportInitialize)provinciasDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView provinciasDataGridView;
        private Button agregarButton;
        private Button modificarButton;
        private Button eliminarButton;
    }
}