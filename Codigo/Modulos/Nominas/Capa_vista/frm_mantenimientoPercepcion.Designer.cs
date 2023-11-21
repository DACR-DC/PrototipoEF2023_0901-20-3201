
namespace Vista_PrototipoMenu
{
    partial class frm_mantenimientoPercepcion
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
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            this.txt_perc_fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_perc_totales = new System.Windows.Forms.TextBox();
            this.txt_id_perc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_empleado.Location = new System.Drawing.Point(412, 419);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(366, 28);
            this.txt_id_empleado.TabIndex = 104;
            this.txt_id_empleado.Tag = "tbl_empleado_Pk_id_empleado";
            // 
            // txt_perc_fecha
            // 
            this.txt_perc_fecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_perc_fecha.Location = new System.Drawing.Point(412, 376);
            this.txt_perc_fecha.Name = "txt_perc_fecha";
            this.txt_perc_fecha.Size = new System.Drawing.Size(366, 28);
            this.txt_perc_fecha.TabIndex = 103;
            this.txt_perc_fecha.Tag = "perc_fecha_perc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 102;
            this.label4.Tag = "";
            this.label4.Text = "ID_empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 21);
            this.label3.TabIndex = 101;
            this.label3.Tag = "";
            this.label3.Text = "Percepcion Fecha";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(60, 31);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(901, 199);
            this.navegador1.TabIndex = 100;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txt_perc_totales
            // 
            this.txt_perc_totales.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_perc_totales.Location = new System.Drawing.Point(412, 333);
            this.txt_perc_totales.Name = "txt_perc_totales";
            this.txt_perc_totales.Size = new System.Drawing.Size(366, 28);
            this.txt_perc_totales.TabIndex = 99;
            this.txt_perc_totales.Tag = "perc_totales";
            this.txt_perc_totales.TextChanged += new System.EventHandler(this.txt_perc_totales_TextChanged);
            // 
            // txt_id_perc
            // 
            this.txt_id_perc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_perc.Location = new System.Drawing.Point(412, 278);
            this.txt_id_perc.Name = "txt_id_perc";
            this.txt_id_perc.Size = new System.Drawing.Size(366, 28);
            this.txt_id_perc.TabIndex = 98;
            this.txt_id_perc.Tag = "Pk_id_percepciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 97;
            this.label2.Tag = "";
            this.label2.Text = "Percepcion Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 96;
            this.label1.Tag = "";
            this.label1.Text = "ID_Percepcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 476);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 229);
            this.dataGridView1.TabIndex = 95;
            this.dataGridView1.Tag = "tbl_percepciones";
            // 
            // frm_mantenimientoPercepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1295, 803);
            this.Controls.Add(this.txt_id_empleado);
            this.Controls.Add(this.txt_perc_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_perc_totales);
            this.Controls.Add(this.txt_id_perc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_mantenimientoPercepcion";
            this.Text = "frm_mantenimientoPercepcion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id_empleado;
        private System.Windows.Forms.TextBox txt_perc_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_perc_totales;
        private System.Windows.Forms.TextBox txt_id_perc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}