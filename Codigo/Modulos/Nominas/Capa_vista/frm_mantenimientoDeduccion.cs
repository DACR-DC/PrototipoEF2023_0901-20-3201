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

namespace Vista_PrototipoMenu
{
    public partial class frm_mantenimientoDeduccion : Form
    {
        Seguridad_Controlador.Controlador cn = new Seguridad_Controlador.Controlador();
        Controlador_PrototipoMenu.Controlador ctrl = new Controlador_PrototipoMenu.Controlador();
        public frm_mantenimientoDeduccion()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6004";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txt_id_ded, txt_ded_totales, txt_ded_fecha, txt_id_empleado };
            TextBox[] Idtextbox = { txt_id_ded, txt_ded_totales };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
        }

        private void txt_id_ded_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
