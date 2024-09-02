namespace Academia
{
    partial class formLogin
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
            btnIngresar = new Button();
            label2 = new Label();
            label3 = new Label();
            linkOlvidaPass = new LinkLabel();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(189, 155);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 74);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 109);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // linkOlvidaPass
            // 
            linkOlvidaPass.AutoSize = true;
            linkOlvidaPass.Location = new Point(45, 159);
            linkOlvidaPass.Name = "linkOlvidaPass";
            linkOlvidaPass.Size = new Size(119, 15);
            linkOlvidaPass.TabIndex = 4;
            linkOlvidaPass.TabStop = true;
            linkOlvidaPass.Text = "Olvidè mi contraseña";
            linkOlvidaPass.Click += linkOlvidaPass_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(164, 71);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(164, 106);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 18);
            label4.Name = "label4";
            label4.Size = new Size(229, 30);
            label4.TabIndex = 7;
            label4.Text = "¡Bienvenido al Sistema!\r\nPor favor digite su información de Ingreso";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formLogin
            // 
            AcceptButton = btnIngresar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 229);
            Controls.Add(label4);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(linkOlvidaPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = " ";
            Load += formLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label label2;
        private Label label3;
        private LinkLabel linkOlvidaPass;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Label label4;
    }
}
