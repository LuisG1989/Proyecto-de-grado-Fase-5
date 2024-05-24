namespace Software_Control_Horario_Arepas
{
    partial class ConsultarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEmpleados));
            this.label5 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.dgEntradasSalidas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreEmpleado = new System.Windows.Forms.TextBox();
            this.cargoEmpleado = new System.Windows.Forms.TextBox();
            this.documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.limpiarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradasSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(348, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "CONSULTAR EMPLEADOS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.OrangeRed;
            this.Salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Salir.Location = new System.Drawing.Point(762, 488);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(151, 42);
            this.Salir.TabIndex = 35;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.RoyalBlue;
            this.Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(60, 488);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(151, 42);
            this.Back.TabIndex = 34;
            this.Back.Text = "Atrás";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // consultar
            // 
            this.consultar.BackColor = System.Drawing.Color.Goldenrod;
            this.consultar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.consultar.Location = new System.Drawing.Point(567, 99);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(138, 31);
            this.consultar.TabIndex = 33;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // dgEntradasSalidas
            // 
            this.dgEntradasSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEntradasSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradasSalidas.Location = new System.Drawing.Point(217, 282);
            this.dgEntradasSalidas.Name = "dgEntradasSalidas";
            this.dgEntradasSalidas.RowHeadersWidth = 51;
            this.dgEntradasSalidas.RowTemplate.Height = 29;
            this.dgEntradasSalidas.Size = new System.Drawing.Size(530, 180);
            this.dgEntradasSalidas.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(54, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Digíte el documento del empleado:";
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.Location = new System.Drawing.Point(90, 201);
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.Size = new System.Drawing.Size(171, 27);
            this.nombreEmpleado.TabIndex = 38;
            // 
            // cargoEmpleado
            // 
            this.cargoEmpleado.Location = new System.Drawing.Point(348, 201);
            this.cargoEmpleado.Name = "cargoEmpleado";
            this.cargoEmpleado.Size = new System.Drawing.Size(154, 27);
            this.cargoEmpleado.TabIndex = 39;
            // 
            // documento
            // 
            this.documento.Location = new System.Drawing.Point(365, 101);
            this.documento.MaxLength = 10;
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(179, 27);
            this.documento.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(90, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(348, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(614, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fecha de Ingreso:";
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.Location = new System.Drawing.Point(614, 201);
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.Size = new System.Drawing.Size(186, 27);
            this.fechaIngreso.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(77, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Registro de Entradas y Salidas:";
            // 
            // limpiarDatos
            // 
            this.limpiarDatos.BackColor = System.Drawing.Color.Tan;
            this.limpiarDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.limpiarDatos.Location = new System.Drawing.Point(711, 99);
            this.limpiarDatos.Name = "limpiarDatos";
            this.limpiarDatos.Size = new System.Drawing.Size(119, 31);
            this.limpiarDatos.TabIndex = 46;
            this.limpiarDatos.Text = "Limpiar";
            this.limpiarDatos.UseVisualStyleBackColor = false;
            this.limpiarDatos.Click += new System.EventHandler(this.limpiarDatos_Click);
            // 
            // ConsultarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 565);
            this.Controls.Add(this.limpiarDatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fechaIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.cargoEmpleado);
            this.Controls.Add(this.nombreEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgEntradasSalidas);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.label5);
            this.Name = "ConsultarEmpleados";
            this.Text = "ConsultarEmpleados";
            this.Load += new System.EventHandler(this.ConsultarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradasSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Button Salir;
        private Button Back;
        private Button consultar;
        private DataGridView dgEntradasSalidas;
        private Label label2;
        private TextBox nombreEmpleado;
        private TextBox cargoEmpleado;
        private TextBox documento;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox fechaIngreso;
        private Label label6;
        private Button limpiarDatos;
    }
}