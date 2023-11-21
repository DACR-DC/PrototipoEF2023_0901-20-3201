
namespace CapaVistaNomina
{
    partial class frm_deduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_deduccion));
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_deduccion_total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_deduccion_descripcion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_id_deduccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_deduccion_valor = new System.Windows.Forms.TextBox();
            this.btn_guardar_deduccion = new System.Windows.Forms.Button();
            this.btn_Guardar_calculo = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.picBox_ayuda = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox3.Location = new System.Drawing.Point(42, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1205, 279);
            this.groupBox3.TabIndex = 128;
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
            this.label11.Location = new System.Drawing.Point(581, 73);
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
            this.label5.Location = new System.Drawing.Point(581, 171);
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
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
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
            this.label4.Location = new System.Drawing.Point(14, 171);
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
            this.label3.Location = new System.Drawing.Point(590, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 93;
            this.label3.Text = "cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 22);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nombre_Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 91;
            this.label1.Text = "ID_Empleado";
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.Location = new System.Drawing.Point(331, 122);
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
            this.txt_id_empleado.TextChanged += new System.EventHandler(this.txt_id_empleado_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_deduccion_total);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 139);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo Deducciones";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 31);
            this.comboBox1.TabIndex = 116;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 22);
            this.label9.TabIndex = 115;
            this.label9.Text = "Descontar";
            // 
            // txt_deduccion_total
            // 
            this.txt_deduccion_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deduccion_total.Location = new System.Drawing.Point(686, 42);
            this.txt_deduccion_total.Name = "txt_deduccion_total";
            this.txt_deduccion_total.ReadOnly = true;
            this.txt_deduccion_total.Size = new System.Drawing.Size(234, 34);
            this.txt_deduccion_total.TabIndex = 110;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(432, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 22);
            this.label10.TabIndex = 109;
            this.label10.Text = "Deduccion total";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(276, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(384, 30);
            this.dateTimePicker1.TabIndex = 105;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(25, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(175, 22);
            this.label18.TabIndex = 104;
            this.label18.Text = "Fecha Deduccion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_deduccion_descripcion);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_id_deduccion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_deduccion_valor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 114);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deducciones";
            // 
            // txt_deduccion_descripcion
            // 
            this.txt_deduccion_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deduccion_descripcion.Location = new System.Drawing.Point(440, 60);
            this.txt_deduccion_descripcion.Name = "txt_deduccion_descripcion";
            this.txt_deduccion_descripcion.Size = new System.Drawing.Size(233, 34);
            this.txt_deduccion_descripcion.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(289, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 22);
            this.label12.TabIndex = 111;
            this.label12.Text = "Decripcion";
            // 
            // txt_id_deduccion
            // 
            this.txt_id_deduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_deduccion.Location = new System.Drawing.Point(206, 57);
            this.txt_id_deduccion.Name = "txt_id_deduccion";
            this.txt_id_deduccion.Size = new System.Drawing.Size(66, 34);
            this.txt_id_deduccion.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(693, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 99;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 98;
            this.label7.Text = "ID_deduccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 97;
            this.label6.Text = "Deducciones";
            // 
            // txt_deduccion_valor
            // 
            this.txt_deduccion_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deduccion_valor.Location = new System.Drawing.Point(772, 60);
            this.txt_deduccion_valor.Name = "txt_deduccion_valor";
            this.txt_deduccion_valor.Size = new System.Drawing.Size(234, 34);
            this.txt_deduccion_valor.TabIndex = 102;
            // 
            // btn_guardar_deduccion
            // 
            this.btn_guardar_deduccion.Location = new System.Drawing.Point(1069, 370);
            this.btn_guardar_deduccion.Name = "btn_guardar_deduccion";
            this.btn_guardar_deduccion.Size = new System.Drawing.Size(123, 65);
            this.btn_guardar_deduccion.TabIndex = 125;
            this.btn_guardar_deduccion.Text = "Guardar Deduccion";
            this.btn_guardar_deduccion.UseVisualStyleBackColor = true;
            this.btn_guardar_deduccion.Click += new System.EventHandler(this.btn_guardar_deduccion_Click_1);
            // 
            // btn_Guardar_calculo
            // 
            this.btn_Guardar_calculo.Location = new System.Drawing.Point(1167, 503);
            this.btn_Guardar_calculo.Name = "btn_Guardar_calculo";
            this.btn_Guardar_calculo.Size = new System.Drawing.Size(116, 65);
            this.btn_Guardar_calculo.TabIndex = 124;
            this.btn_Guardar_calculo.Text = "Guardar Calculo";
            this.btn_Guardar_calculo.UseVisualStyleBackColor = true;
            this.btn_Guardar_calculo.Click += new System.EventHandler(this.btn_Guardar_calculo_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(1024, 503);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(123, 65);
            this.btn_calcular.TabIndex = 123;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 652);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 220);
            this.dataGridView1.TabIndex = 122;
            // 
            // picBox_ayuda
            // 
            this.picBox_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("picBox_ayuda.Image")));
            this.picBox_ayuda.Location = new System.Drawing.Point(1294, 23);
            this.picBox_ayuda.Name = "picBox_ayuda";
            this.picBox_ayuda.Size = new System.Drawing.Size(59, 54);
            this.picBox_ayuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_ayuda.TabIndex = 129;
            this.picBox_ayuda.TabStop = false;
            this.picBox_ayuda.Click += new System.EventHandler(this.picBox_ayuda_Click);
            // 
            // frm_deduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1369, 915);
            this.Controls.Add(this.picBox_ayuda);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_guardar_deduccion);
            this.Controls.Add(this.btn_Guardar_calculo);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_deduccion";
            this.Text = "frm_deduccion";
            this.Load += new System.EventHandler(this.frm_deduccion_percepciones_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ayuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_deduccion_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_deduccion_descripcion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_id_deduccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_deduccion_valor;
        private System.Windows.Forms.Button btn_guardar_deduccion;
        private System.Windows.Forms.Button btn_Guardar_calculo;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_emp_tipo_moneda;
        private System.Windows.Forms.PictureBox picBox_ayuda;
    }
}