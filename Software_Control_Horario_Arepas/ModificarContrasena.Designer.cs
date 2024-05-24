namespace Software_Control_Horario_Arepas
{
    partial class ModificarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarContrasena));
            this.label1 = new System.Windows.Forms.Label();
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.newPass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.modificarPass = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.confPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(309, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "CAMBIAR CONTRASEÑA";
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.AutoSize = true;
            this.oldPassLabel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.oldPassLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldPassLabel.ForeColor = System.Drawing.Color.Brown;
            this.oldPassLabel.Location = new System.Drawing.Point(151, 93);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(209, 23);
            this.oldPassLabel.TabIndex = 15;
            this.oldPassLabel.Text = "Contraseña Anterior";
            // 
            // newPass
            // 
            this.newPass.AutoSize = true;
            this.newPass.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.newPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newPass.ForeColor = System.Drawing.Color.Brown;
            this.newPass.Location = new System.Drawing.Point(161, 136);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(191, 23);
            this.newPass.TabIndex = 16;
            this.newPass.Text = "Nueva Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(124, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(409, 136);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(151, 27);
            this.newPassword.TabIndex = 21;
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(409, 93);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '*';
            this.oldPassword.Size = new System.Drawing.Size(151, 27);
            this.oldPassword.TabIndex = 22;
            // 
            // modificarPass
            // 
            this.modificarPass.BackColor = System.Drawing.Color.Goldenrod;
            this.modificarPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modificarPass.Location = new System.Drawing.Point(294, 275);
            this.modificarPass.Name = "modificarPass";
            this.modificarPass.Size = new System.Drawing.Size(151, 42);
            this.modificarPass.TabIndex = 25;
            this.modificarPass.Text = "Modificar";
            this.modificarPass.UseVisualStyleBackColor = false;
            this.modificarPass.Click += new System.EventHandler(this.modificarPass_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.OrangeRed;
            this.Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Salir.Location = new System.Drawing.Point(606, 392);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(151, 42);
            this.Salir.TabIndex = 24;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(56, 392);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(151, 42);
            this.Back.TabIndex = 23;
            this.Back.Text = "Atrás";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // confPassword
            // 
            this.confPassword.Location = new System.Drawing.Point(409, 178);
            this.confPassword.Name = "confPassword";
            this.confPassword.PasswordChar = '*';
            this.confPassword.Size = new System.Drawing.Size(151, 27);
            this.confPassword.TabIndex = 26;
            // 
            // ModificarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confPassword);
            this.Controls.Add(this.modificarPass);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newPass);
            this.Controls.Add(this.oldPassLabel);
            this.Controls.Add(this.label1);
            this.Name = "ModificarContrasena";
            this.Text = "Contraseña";
            this.Load += new System.EventHandler(this.ModificarContrasena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label oldPassLabel;
        private Label newPass;
        private Label label4;
        private TextBox newPassword;
        private TextBox oldPassword;
        private Button modificarPass;
        private Button Salir;
        private Button Back;
        private TextBox confPassword;
    }
}