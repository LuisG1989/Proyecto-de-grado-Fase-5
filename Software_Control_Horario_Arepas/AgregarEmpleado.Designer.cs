namespace Software_Control_Horario_Arepas
{
    partial class AgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoEmpleado = new System.Windows.Forms.ComboBox();
            this.fechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.documento = new System.Windows.Forms.TextBox();
            this.nombreEmpleado = new System.Windows.Forms.TextBox();
            this.crearEmpleado = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "CREAR EMPLEADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(301, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(311, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(240, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(204, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tipo de Empleado";
            // 
            // tipoEmpleado
            // 
            this.tipoEmpleado.FormattingEnabled = true;
            this.tipoEmpleado.Location = new System.Drawing.Point(444, 275);
            this.tipoEmpleado.Name = "tipoEmpleado";
            this.tipoEmpleado.Size = new System.Drawing.Size(151, 28);
            this.tipoEmpleado.TabIndex = 19;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.CustomFormat = "MM/dd/yyyy";
            this.fechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaIngreso.Location = new System.Drawing.Point(444, 232);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(151, 27);
            this.fechaIngreso.TabIndex = 20;
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(444, 188);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(151, 27);
            this.documento.TabIndex = 21;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.Location = new System.Drawing.Point(444, 145);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Size = new System.Drawing.Size(151, 27);
            this.nombreEmpleado.TabIndex = 22;
            // 
            // crearEmpleado
            // 
            this.crearEmpleado.BackColor = System.Drawing.Color.Goldenrod;
            this.crearEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.crearEmpleado.Location = new System.Drawing.Point(444, 331);
            this.crearEmpleado.Name = "crearEmpleado";
            this.crearEmpleado.Size = new System.Drawing.Size(151, 42);
            this.crearEmpleado.TabIndex = 25;
            this.crearEmpleado.Text = "Crear";
            this.crearEmpleado.UseVisualStyleBackColor = false;
            this.crearEmpleado.Click += new System.EventHandler(this.crearEmpleado_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.OrangeRed;
            this.Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Salir.Location = new System.Drawing.Point(692, 473);
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
            this.Back.Location = new System.Drawing.Point(106, 473);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(151, 42);
            this.Back.TabIndex = 23;
            this.Back.Text = "Atrás";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 565);
            this.Controls.Add(this.crearEmpleado);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.nombreEmpleado);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.fechaIngreso);
            this.Controls.Add(this.tipoEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox tipoEmpleado;
        private TextBox documento;
        private TextBox nombreEmpleado;
        private Button crearEmpleado;
        private Button Salir;
        private Button Back;
        private DateTimePicker fechaIngreso;
    }
}