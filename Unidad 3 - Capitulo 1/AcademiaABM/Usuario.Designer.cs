﻿namespace AcademiaABM
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            tlUsuarios = new ToolStripContainer();
            tlAlumnos = new TableLayoutPanel();
            dgvUsuarios = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            _usuario = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            Habilitado = new DataGridViewCheckBoxColumn();
            btnActualizar = new Button();
            btnSalir = new Button();
            tsUsuarios = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tlUsuarios.ContentPanel.SuspendLayout();
            tlUsuarios.TopToolStripPanel.SuspendLayout();
            tlUsuarios.SuspendLayout();
            tlAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tsUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // tlUsuarios
            // 
            // 
            // tlUsuarios.ContentPanel
            // 
            tlUsuarios.ContentPanel.Controls.Add(tlAlumnos);
            tlUsuarios.ContentPanel.Size = new Size(800, 425);
            tlUsuarios.Dock = DockStyle.Fill;
            tlUsuarios.Location = new Point(0, 0);
            tlUsuarios.Name = "tlUsuarios";
            tlUsuarios.Size = new Size(800, 450);
            tlUsuarios.TabIndex = 0;
            tlUsuarios.Text = "toolStripContainer1";
            // 
            // tlUsuarios.TopToolStripPanel
            // 
            tlUsuarios.TopToolStripPanel.Controls.Add(tsUsuarios);
            // 
            // tlAlumnos
            // 
            tlAlumnos.ColumnCount = 2;
            tlAlumnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlAlumnos.ColumnStyles.Add(new ColumnStyle());
            tlAlumnos.Controls.Add(dgvUsuarios, 0, 0);
            tlAlumnos.Controls.Add(btnActualizar, 0, 1);
            tlAlumnos.Controls.Add(btnSalir, 1, 1);
            tlAlumnos.Dock = DockStyle.Fill;
            tlAlumnos.Location = new Point(0, 0);
            tlAlumnos.Name = "tlAlumnos";
            tlAlumnos.RowCount = 2;
            tlAlumnos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlAlumnos.RowStyles.Add(new RowStyle());
            tlAlumnos.Size = new Size(800, 425);
            tlAlumnos.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { id, nombre, apellido, _usuario, email, Habilitado });
            tlAlumnos.SetColumnSpan(dgvUsuarios, 2);
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(794, 390);
            dgvUsuarios.TabIndex = 0;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            id.DataPropertyName = "ID";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 43;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.DataPropertyName = "Apellido";
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // _usuario
            // 
            _usuario.DataPropertyName = "Usuario";
            _usuario.HeaderText = "Usuario";
            _usuario.Name = "_usuario";
            _usuario.ReadOnly = true;
            // 
            // email
            // 
            email.DataPropertyName = "Email";
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // Habilitado
            // 
            Habilitado.DataPropertyName = "Habilitado";
            Habilitado.HeaderText = "Habilitado";
            Habilitado.Name = "Habilitado";
            Habilitado.ReadOnly = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Location = new Point(641, 399);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(722, 399);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tsUsuarios
            // 
            tsUsuarios.Dock = DockStyle.None;
            tsUsuarios.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbEditar, tsbEliminar });
            tsUsuarios.Location = new Point(3, 0);
            tsUsuarios.Name = "tsUsuarios";
            tsUsuarios.Size = new Size(81, 25);
            tsUsuarios.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(23, 22);
            tsbNuevo.Text = "toolStripButton1";
            tsbNuevo.ToolTipText = "Nuevo";
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(23, 22);
            tsbEditar.Text = "Editar";
            // 
            // tsbEliminar
            // 
            tsbEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(23, 22);
            tsbEliminar.Text = "Eliminar";
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlUsuarios);
            Name = "Usuario";
            Text = "Usuarios";
            Load += Usuario_Load;
            tlUsuarios.ContentPanel.ResumeLayout(false);
            tlUsuarios.TopToolStripPanel.ResumeLayout(false);
            tlUsuarios.TopToolStripPanel.PerformLayout();
            tlUsuarios.ResumeLayout(false);
            tlUsuarios.PerformLayout();
            tlAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tsUsuarios.ResumeLayout(false);
            tsUsuarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tlUsuarios;
        private TableLayoutPanel tlAlumnos;
        private DataGridView dgvUsuarios;
        private Button btnActualizar;
        private Button btnSalir;
        private ToolStrip tsUsuarios;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn _usuario;
        private DataGridViewTextBoxColumn email;
        private DataGridViewCheckBoxColumn Habilitado;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbEliminar;
    }
}
