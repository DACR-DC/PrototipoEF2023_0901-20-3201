using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Codigo submodulo deducciones creado por David Alejandro Carrillo de la Roca

namespace CapaVistaNomina
{
    public partial class frm_mantenimiento_departamento : Form
    {
        Seguridad_Controlador.Controlador cn = new Seguridad_Controlador.Controlador();
        Controlador_PrototipoMenu.Controlador ctrl = new Controlador_PrototipoMenu.Controlador();
        public frm_mantenimiento_departamento()
        {
            InitializeComponent();
           // this.navegador1.config("tbl_departamento", this, "");
        }

        public void llenar()
        {
            // DataTable dt = ctrl.llenartabla(tabla);
            // dataGridView1.DataSource = dt;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6001";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txt_id_departamento, txt_nombre_empleado };
            TextBox[] Idtextbox = { txt_id_departamento, txt_nombre_empleado };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
        }

        private void txt_id_departamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
