using System;
using Controlador_PrototipoMenu;
using Modelo_PrototipoMenu;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_PrototipoMenu
{
    public partial class frm_nomina : Form
    {
        Controlador ctrl = new Controlador();
        string tabla = "tbl_nomina";
        public frm_nomina()
        {
            InitializeComponent();
            llenar();
        }

        public void llenar()
        {
            DataTable dt = ctrl.llenartabla(tabla);
            dataGridView1.DataSource = dt;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_id_empleado.Text, out int idEmpleado))
                {

                    Empleado empleadoEncontrado = ctrl.BuscarEmpleadoPorID(idEmpleado);


                    if (empleadoEncontrado != null)
                    {
                        foreach (Control control in groupBox3.Controls)
                        {
                            if (control is TextBox)
                            {
                                TextBox textBox = (TextBox)control;
                                if (textBox.Tag != null && textBox.Tag.ToString() != "")
                                {
                                    string campo = textBox.Tag.ToString();
                                    if (campo == "emp_nombre")
                                    {
                                        textBox.Text = empleadoEncontrado.Nombre;
                                    }
                                    else if (campo == "emp_apellido")
                                    {
                                        textBox.Text = empleadoEncontrado.Apellido;
                                    }
                                    else if (campo == "emp_sueldo")
                                    {
                                        textBox.Text = empleadoEncontrado.Sueldo;
                                    }
                                    else if (campo == "emp_cargo")
                                    {
                                        textBox.Text = empleadoEncontrado.Cargo;
                                    }
                                    else if (campo == "emp_tipo_moneda")
                                    {
                                        textBox.Text = empleadoEncontrado.Moneda;
                                    }
                                    else if (campo == "tbl_departamento_Pk_id_departamento")
                                    {
                                        textBox.Text = empleadoEncontrado.Departamento;
                                        string dept = txt_departamento_empleado.Text;
                                        int.TryParse(dept, out int iddept);
                                        string departamentoEncontrado = ctrl.ObtenerDepartamento(iddept);
                                        textBox.Text = departamentoEncontrado;
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Empleado no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID de empleado no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btn_guardar_nomina_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_id_empleado.Text, out int idEmpleado) &&
                double.TryParse(txt_totalDeducciones.Text, out double totalDeducciones) &&
                double.TryParse(txt_sueldoB_empleado.Text, out double sueldoBase) &&
                double.TryParse(txt_totalPercepciones.Text, out double totalPercepciones) &&
                double.TryParse(txt_sueldoFinal.Text, out double sueldoFinal)
                )
            {

                string tipoMoneda = txt_emp_tipo_moneda.Text;
                ctrl.InsertarNomina(idEmpleado, tipoMoneda, sueldoBase.ToString(), totalPercepciones.ToString(), totalDeducciones.ToString(), sueldoFinal.ToString()); // Convierte sueldoFinal a cadena
                MessageBox.Show("Nómina guardada ");
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
            llenar();
        }

        private void picBox_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasNomina/AyudaNominasHSC.chm", "Nomina.html");
        }
    }
}
