using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_PrototipoMenu;
using Controlador_PrototipoMenu;
using Seguridad_Controlador;

//Codigo submodulo deducciones creado por David Alejandro Carrillo de la Roca

namespace CapaVistaNomina
{
    public partial class frm_mantenimiento_empleado : Form
    {
        Seguridad_Controlador.Controlador cn = new Seguridad_Controlador.Controlador();
        Controlador_PrototipoMenu.Controlador ctrl = new Controlador_PrototipoMenu.Controlador();
        
        string tabla = "tbl_departamento";
        public frm_mantenimiento_empleado()
        {
            InitializeComponent();
            //this.navegador1.config("tbl_empleado", this, "");
           
             llenar();
           
        }
        public void llenar()
        {
           DataTable dt = ctrl.llenartabla(tabla);
           dataDepa.DataSource = dt;
        }
            private void btn_buscar_Click(object sender, EventArgs e)
        {
           
        }

       

        private void navegador1_Load_1(object sender, EventArgs e)
        {
         NavegadorVista.Navegador.idApp = "6002";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = {txt_id_empleado, txt_nombre_empleado, txt_apellido_empleado, txt_tipo_moneda, txt_emp_sueldo, txt_cargo_empleado, txt_correo_empleado, txt_telefono_empleado, txt_fecha__contratacion, txt_empleado_dept };
            TextBox[] Idtextbox = { txt_id_empleado, txt_nombre_empleado };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
        }

        private void txt_id_empleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
