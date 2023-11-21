
namespace Vista_PrototipoMenu
{
    partial class frm_mantenimientoDeduccion
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.txt_ded_totales = new System.Windows.Forms.TextBox();
            this.txt_id_ded = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ded_fecha = new System.Windows.Forms.TextBox();
            this.txt_id_empleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(89, 29);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(901, 199);
            this.navegador1.TabIndex = 90;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txt_ded_totales
            // 
            this.txt_ded_totales.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ded_totales.Location = new System.Drawing.Point(441, 331);
            this.txt_ded_totales.Name = "txt_ded_totales";
            this.txt_ded_totales.Size = new System.Drawing.Size(366, 28);
            this.txt_ded_totales.TabIndex = 89;
            this.txt_ded_totales.Tag = "ded_deducciones_totales";
            // 
            // txt_id_ded
            // 
            this.txt_id_ded.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_ded.Location = new System.Drawing.Point(441, 276);
            this.txt_id_ded.Name = "txt_id_ded";
            this.txt_id_ded.Size = new System.Drawing.Size(366, 28);
            this.txt_id_ded.TabIndex = 88;
            this.txt_id_ded.Tag = "Pk_id_ded";
            this.txt_id_ded.TextChanged += new System.EventHandler(this.txt_id_ded_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 87;
            this.label2.Tag = "";
            this.label2.Text = "Deduccion Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 86;
            this.label1.Tag = "";
            this.label1.Text = "ID_Deduccion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(122, 474);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 229);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.Tag = "tbl_deducciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 91;
            this.label3.Tag = "";
            this.label3.Text = "Deduccion Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 92;
            this.label4.Tag = "";
            this.label4.Text = "ID_empleado";
            // 
            // txt_ded_fecha
            // 
            this.txt_ded_fecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ded_fecha.Location = new System.Drawing.Point(441, 374);
            this.txt_ded_fecha.Name = "txt_ded_fecha";
            this.txt_ded_fecha.Size = new System.Drawing.Size(366, 28);
            this.txt_ded_fecha.TabIndex = 93;
            this.txt_ded_fecha.Tag = "ded_fecha_ded";
            // 
            // txt_id_empleado
            // 
            this.txt_id_empleado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_empleado.Location = new System.Drawing.Point(441, 417);
            this.txt_id_empleado.Name = "txt_id_empleado";
            this.txt_id_empleado.Size = new System.Drawing.Size(366, 28);
            this.txt_id_empleado.TabIndex = 94;
            this.txt_id_empleado.Tag = "tbl_empleado_Pk_id_empleado";
            // 
            // frm_mantenimientoDeduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1243, 756);
            this.Controls.Add(this.txt_id_empleado);
            this.Controls.Add(this.txt_ded_fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_ded_totales);
            this.Controls.Add(this.txt_id_ded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_mantenimientoDeduccion";
            this.Text = "frm_mantenimientoDeduccion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txt_ded_totales;
        private System.Windows.Forms.TextBox txt_id_ded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ded_fecha;
        private System.Windows.Forms.TextBox txt_id_empleado;
    }
}