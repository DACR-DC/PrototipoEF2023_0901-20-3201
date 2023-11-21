namespace CapaVistaNomina
{
    partial class frm_mantenimiento_empleado
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
            this.txt_empleado_dept = new System.Windows.Forms.TextBox();
            this.txt_telefono_empleado = new System.Windows.Forms.TextBox();
            this.txt_correo_empleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_emp_sueldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cargo_empleado = new System.Windows.Forms.TextBox();
            this.txt_apellido_empleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre_empleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataDepa = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_fecha__contratacion = new System.Windows.Forms.TextBox();
            this.txt_tipo_moneda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepa)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_empleado_dept
            // 
            this.txt_empleado_dept.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empleado_dept.Location = new System.Drawing.Point(406, 622);
            this.txt_empleado_dept.Name = "txt_empleado_dept";
            this.txt_empleado_dept.Size = new System.Drawing.Size(366, 32);
            this.txt_empleado_dept.TabIndex = 108;
            this.txt_empleado_dept.Tag = "tbl_departamento_Pk_id_departamento";
            // 
            // txt_telefono_empleado
            // 
            this.txt_telefono_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_empleado.Location = new System.Drawing.Point(406, 533);
            this.txt_telefono_empleado.Name = "txt_telefono_empleado";
            this.txt_telefono_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_telefono_empleado.TabIndex = 106;
            this.txt_telefono_empleado.Tag = "emp_telefono";
            // 
            // txt_correo_empleado
            // 
            this.txt_correo_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo_empleado.Location = new System.Drawing.Point(406, 481);
            this.txt_correo_empleado.Name = "txt_correo_empleado";
            this.txt_correo_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_correo_empleado.TabIndex = 105;
            this.txt_correo_empleado.Tag = "emp_correo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 621);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 22);
            this.label9.TabIndex = 113;
            this.label9.Text = "Id_departamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 568);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 22);
            this.label8.TabIndex = 112;
            this.label8.Text = "Fecha_contratacion";
            // 
            // txt_emp_sueldo
            // 
            this.txt_emp_sueldo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_sueldo.Location = new System.Drawing.Point(336, 378);
            this.txt_emp_sueldo.Name = "txt_emp_sueldo";
            this.txt_emp_sueldo.Size = new System.Drawing.Size(64, 32);
            this.txt_emp_sueldo.TabIndex = 103;
            this.txt_emp_sueldo.Tag = "emp_tipo_moneda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 111;
            this.label7.Text = "Telefono";
            // 
            // txt_cargo_empleado
            // 
            this.txt_cargo_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo_empleado.Location = new System.Drawing.Point(406, 431);
            this.txt_cargo_empleado.Name = "txt_cargo_empleado";
            this.txt_cargo_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_cargo_empleado.TabIndex = 104;
            this.txt_cargo_empleado.Tag = "emp_cargo";
            // 
            // txt_apellido_empleado
            // 
            this.txt_apellido_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_empleado.Location = new System.Drawing.Point(406, 326);
            this.txt_apellido_empleado.Name = "txt_apellido_empleado";
            this.txt_apellido_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_apellido_empleado.TabIndex = 101;
            this.txt_apellido_empleado.Tag = "emp_apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 22);
            this.label6.TabIndex = 110;
            this.label6.Text = "Correo";
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.Location = new System.Drawing.Point(406, 277);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_nombre_empleado.TabIndex = 100;
            this.txt_nombre_empleado.Tag = "emp_nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 101;
            this.label1.Text = "ID_Empleado";
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_empleado.Location = new System.Drawing.Point(406, 229);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(366, 32);
            this.txt_id_empleado.TabIndex = 99;
            this.txt_id_empleado.Tag = "Pk_id_empleado";
            this.txt_id_empleado.TextChanged += new System.EventHandler(this.txt_id_empleado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 102;
            this.label2.Text = "Nombre_Empleado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 669);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 153);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.Tag = "tbl_empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 22);
            this.label5.TabIndex = 109;
            this.label5.Text = "Moneda y Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 22);
            this.label4.TabIndex = 105;
            this.label4.Text = "Apellido_Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 103;
            this.label3.Text = "Cargo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.dataDepa);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(856, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 268);
            this.panel1.TabIndex = 119;
            // 
            // dataDepa
            // 
            this.dataDepa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDepa.Location = new System.Drawing.Point(22, 85);
            this.dataDepa.Name = "dataDepa";
            this.dataDepa.RowHeadersVisible = false;
            this.dataDepa.RowHeadersWidth = 51;
            this.dataDepa.RowTemplate.Height = 24;
            this.dataDepa.Size = new System.Drawing.Size(270, 151);
            this.dataDepa.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 22);
            this.label10.TabIndex = 120;
            this.label10.Text = "Departamentos";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(203, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(795, 203);
            this.navegador1.TabIndex = 120;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load_1);
            // 
            // txt_fecha__contratacion
            // 
            this.txt_fecha__contratacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha__contratacion.Location = new System.Drawing.Point(406, 575);
            this.txt_fecha__contratacion.Name = "txt_fecha__contratacion";
            this.txt_fecha__contratacion.Size = new System.Drawing.Size(366, 32);
            this.txt_fecha__contratacion.TabIndex = 107;
            this.txt_fecha__contratacion.Tag = "emp_fecha_contratacion";
            // 
            // txt_tipo_moneda
            // 
            this.txt_tipo_moneda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo_moneda.Location = new System.Drawing.Point(406, 378);
            this.txt_tipo_moneda.Name = "txt_tipo_moneda";
            this.txt_tipo_moneda.Size = new System.Drawing.Size(366, 32);
            this.txt_tipo_moneda.TabIndex = 102;
            this.txt_tipo_moneda.Tag = "emp_sueldo";
            // 
            // frm_mantenimiento_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1247, 835);
            this.Controls.Add(this.txt_tipo_moneda);
            this.Controls.Add(this.txt_fecha__contratacion);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_empleado_dept);
            this.Controls.Add(this.txt_telefono_empleado);
            this.Controls.Add(this.txt_correo_empleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_emp_sueldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cargo_empleado);
            this.Controls.Add(this.txt_apellido_empleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nombre_empleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_empleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frm_mantenimiento_empleado";
            this.Text = "6002-frm_mantenimiento_empleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDepa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_empleado_dept;
        private System.Windows.Forms.TextBox txt_telefono_empleado;
        private System.Windows.Forms.TextBox txt_correo_empleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_emp_sueldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cargo_empleado;
        private System.Windows.Forms.TextBox txt_apellido_empleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre_empleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
       // private CapaVista.Navegador navegador1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataDepa;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_fecha__contratacion;
        private System.Windows.Forms.TextBox txt_tipo_moneda;
    }
}