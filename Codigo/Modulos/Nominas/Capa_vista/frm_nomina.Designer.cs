
namespace Vista_PrototipoMenu
{
    partial class frm_nomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nomina));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_emp_tipo_moneda = new System.Windows.Forms.TextBox();
            this.txt_departamento_empleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cargo_empleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_sueldoB_empleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_apellido_empleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_empleado = new System.Windows.Forms.TextBox();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sueldoFinal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_totalPercepciones = new System.Windows.Forms.TextBox();
            this.txt_totalDeducciones = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_guardar_nomina = new System.Windows.Forms.Button();
            this.picBox_ayuda = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ayuda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_emp_tipo_moneda);
            this.groupBox3.Controls.Add(this.txt_departamento_empleado);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_cargo_empleado);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btn_buscar);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txt_sueldoB_empleado);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_apellido_empleado);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_nombre_empleado);
            this.groupBox3.Controls.Add(this.txt_id_empleado);
            this.groupBox3.Location = new System.Drawing.Point(31, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1205, 244);
            this.groupBox3.TabIndex = 129;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // txt_emp_tipo_moneda
            // 
            this.txt_emp_tipo_moneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_tipo_moneda.Location = new System.Drawing.Point(787, 167);
            this.txt_emp_tipo_moneda.Name = "txt_emp_tipo_moneda";
            this.txt_emp_tipo_moneda.ReadOnly = true;
            this.txt_emp_tipo_moneda.Size = new System.Drawing.Size(50, 34);
            this.txt_emp_tipo_moneda.TabIndex = 121;
            this.txt_emp_tipo_moneda.Tag = "emp_tipo_moneda";
            // 
            // txt_departamento_empleado
            // 
            this.txt_departamento_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_departamento_empleado.Location = new System.Drawing.Point(833, 74);
            this.txt_departamento_empleado.Name = "txt_departamento_empleado";
            this.txt_departamento_empleado.ReadOnly = true;
            this.txt_departamento_empleado.Size = new System.Drawing.Size(234, 34);
            this.txt_departamento_empleado.TabIndex = 120;
            this.txt_departamento_empleado.Tag = "tbl_departamento_Pk_id_departamento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(588, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 22);
            this.label11.TabIndex = 119;
            this.label11.Text = "Departamento";
            // 
            // txt_cargo_empleado
            // 
            this.txt_cargo_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargo_empleado.Location = new System.Drawing.Point(833, 120);
            this.txt_cargo_empleado.Name = "txt_cargo_empleado";
            this.txt_cargo_empleado.ReadOnly = true;
            this.txt_cargo_empleado.Size = new System.Drawing.Size(234, 34);
            this.txt_cargo_empleado.TabIndex = 108;
            this.txt_cargo_empleado.Tag = "emp_cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 107;
            this.label5.Text = "Sueldo Base";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(459, 71);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(101, 34);
            this.btn_buscar.TabIndex = 106;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(192, 29);
            this.label17.TabIndex = 103;
            this.label17.Text = "Datos Empleado";
            // 
            // txt_sueldoB_empleado
            // 
            this.txt_sueldoB_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sueldoB_empleado.Location = new System.Drawing.Point(833, 167);
            this.txt_sueldoB_empleado.Name = "txt_sueldoB_empleado";
            this.txt_sueldoB_empleado.ReadOnly = true;
            this.txt_sueldoB_empleado.Size = new System.Drawing.Size(234, 34);
            this.txt_sueldoB_empleado.TabIndex = 96;
            this.txt_sueldoB_empleado.Tag = "emp_sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 22);
            this.label4.TabIndex = 95;
            this.label4.Text = "Apellido_Empleado";
            // 
            // txt_apellido_empleado
            // 
            this.txt_apellido_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido_empleado.Location = new System.Drawing.Point(326, 174);
            this.txt_apellido_empleado.Name = "txt_apellido_empleado";
            this.txt_apellido_empleado.ReadOnly = true;
            this.txt_apellido_empleado.Size = new System.Drawing.Size(234, 34);
            this.txt_apellido_empleado.TabIndex = 94;
            this.txt_apellido_empleado.Tag = "emp_apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(588, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 93;
            this.label3.Text = "cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nombre_Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 91;
            this.label1.Text = "ID_Empleado";
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.Location = new System.Drawing.Point(326, 121);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.ReadOnly = true;
            this.txt_nombre_empleado.Size = new System.Drawing.Size(234, 34);
            this.txt_nombre_empleado.TabIndex = 90;
            this.txt_nombre_empleado.Tag = "emp_nombre";
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_empleado.Location = new System.Drawing.Point(326, 71);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(127, 34);
            this.txt_id_empleado.TabIndex = 89;
            this.txt_id_empleado.Tag = "Pk_id_empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_sueldoFinal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_totalPercepciones);
            this.groupBox1.Controls.Add(this.txt_totalDeducciones);
            this.groupBox1.Location = new System.Drawing.Point(31, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 244);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 29);
            this.label8.TabIndex = 103;
            this.label8.Text = "Datos Deducciones y Percepciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 22);
            this.label9.TabIndex = 95;
            this.label9.Text = "Sueldo Final";
            // 
            // txt_sueldoFinal
            // 
            this.txt_sueldoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sueldoFinal.Location = new System.Drawing.Point(356, 174);
            this.txt_sueldoFinal.Name = "txt_sueldoFinal";
            this.txt_sueldoFinal.ReadOnly = true;
            this.txt_sueldoFinal.Size = new System.Drawing.Size(234, 34);
            this.txt_sueldoFinal.TabIndex = 94;
            this.txt_sueldoFinal.Tag = "nomi_sueldo_final";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 22);
            this.label12.TabIndex = 92;
            this.label12.Text = "Total_percepciones";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 22);
            this.label13.TabIndex = 91;
            this.label13.Text = "Total Deducciones";
            // 
            // txt_totalPercepciones
            // 
            this.txt_totalPercepciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPercepciones.Location = new System.Drawing.Point(356, 119);
            this.txt_totalPercepciones.Name = "txt_totalPercepciones";
            this.txt_totalPercepciones.ReadOnly = true;
            this.txt_totalPercepciones.Size = new System.Drawing.Size(234, 34);
            this.txt_totalPercepciones.TabIndex = 90;
            this.txt_totalPercepciones.Tag = "tbl_percepciones_Pk_id_percepciones";
            // 
            // txt_totalDeducciones
            // 
            this.txt_totalDeducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalDeducciones.Location = new System.Drawing.Point(356, 71);
            this.txt_totalDeducciones.Name = "txt_totalDeducciones";
            this.txt_totalDeducciones.ReadOnly = true;
            this.txt_totalDeducciones.Size = new System.Drawing.Size(234, 34);
            this.txt_totalDeducciones.TabIndex = 89;
            this.txt_totalDeducciones.Tag = "tbl_deducciones_Pk_id_ded";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 576);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 260);
            this.dataGridView1.TabIndex = 131;
            this.dataGridView1.Tag = "tbl_nomina";
            // 
            // btn_guardar_nomina
            // 
            this.btn_guardar_nomina.Location = new System.Drawing.Point(698, 427);
            this.btn_guardar_nomina.Name = "btn_guardar_nomina";
            this.btn_guardar_nomina.Size = new System.Drawing.Size(140, 86);
            this.btn_guardar_nomina.TabIndex = 132;
            this.btn_guardar_nomina.Text = "Guardar";
            this.btn_guardar_nomina.UseVisualStyleBackColor = true;
            this.btn_guardar_nomina.Click += new System.EventHandler(this.btn_guardar_nomina_Click);
            // 
            // picBox_ayuda
            // 
            this.picBox_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("picBox_ayuda.Image")));
            this.picBox_ayuda.Location = new System.Drawing.Point(1254, 34);
            this.picBox_ayuda.Name = "picBox_ayuda";
            this.picBox_ayuda.Size = new System.Drawing.Size(59, 54);
            this.picBox_ayuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_ayuda.TabIndex = 144;
            this.picBox_ayuda.TabStop = false;
            this.picBox_ayuda.Click += new System.EventHandler(this.picBox_ayuda_Click);
            // 
            // frm_nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1398, 913);
            this.Controls.Add(this.picBox_ayuda);
            this.Controls.Add(this.btn_guardar_nomina);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frm_nomina";
            this.Text = "frm_nomina";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ayuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_emp_tipo_moneda;
        private System.Windows.Forms.TextBox txt_departamento_empleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cargo_empleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_sueldoB_empleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_apellido_empleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_empleado;
        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_sueldoFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_totalPercepciones;
        private System.Windows.Forms.TextBox txt_totalDeducciones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_guardar_nomina;
        private System.Windows.Forms.PictureBox picBox_ayuda;
    }
}