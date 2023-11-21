using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using Seguridad_Controlador;  // Agregar cuando se vincule la DLL de seguridad 

namespace Vista_PrototipoMenu
{
    public partial class MenuNominas : Form
    {
        Seguridad_Controlador.Controlador cn = new Seguridad_Controlador.Controlador();
        Controlador_PrototipoMenu.Controlador ctrl = new Controlador_PrototipoMenu.Controlador();
        // Controlador cn = new Controlador();  // Agregar cuando se vincule la DLL de seguridad 

        //Método que guarda en un arreglo de tipo botón los botones que se tienen en el formulario. Se les da permiso a los diferentes botones de acuerdo a la función que realice este
        public MenuNominas()
        {
            InitializeComponent();
            //Control para habilitar opciones del menu
             //Button[] apps = {btn_Deducciones_Percepciones, btn_mantenimiento_departamentos, btn_mantenimiento_empleados, btn_nominas}; // Agregar cuando se vincule la DLL de seguridad 
            //Llamada metodo de libreria Controlador del modulo de Seguridad
            //cn.deshabilitarApps(apps); // Agregar cuando se vincule la DLL de seguridad 
            //Llamada metodo de libreria Controlador del modulo de Seguridad
           // cn.getAccesoApp(1002, apps[0]); // Agregar cuando se vincule la DLL de seguridad 

        }

        //Validaciones que si son visibles los panales los oculta
        private void hideSubMenu()
        {
            
            if (panelTranportes.Visible == true)
                panelTranportes.Visible = false;
            if (PanelAuditoria.Visible == true)
                PanelAuditoria.Visible = false;
            if (panelseguridad.Visible == true)
                panelseguridad.Visible = false;
            if (panelayuda.Visible == true)
                panelayuda.Visible = false;
        }
        //Método que valida si el submenu no es visible oculta el submenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Método que muestra el panel indicado
        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }
        //Método que muestra el panel indicado
        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelAuditoria);
        }
        //Método que muestra el panel indicado
        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelayuda);
        }
        //Método que muestra el panel indicado
        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelseguridad);
        }
        //Método que muestra el formulario indicado
        //Método que muestra el formulario indicado
        private void btn_Deducciones_Percepciones_Click(object sender, EventArgs e)
        {
            Vista_PrototipoMenu.frm_mantenimiento_deducciones_percepciones mantpercded = new Vista_PrototipoMenu.frm_mantenimiento_deducciones_percepciones();
            mantpercded.MdiParent = this;
            mantpercded.Show();
            hideSubMenu(); 
        }
        

        private void btninicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método que oculta el formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método que muestra el formulario indicado
        private void btnayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasNomina/AyudaNominasHSC.chm", "MenuNominas.html");
        }

        private void btn_mantenimiento_empleados_Click(object sender, EventArgs e)
        {
            CapaVistaNomina.frm_mantenimiento_empleado mant = new CapaVistaNomina.frm_mantenimiento_empleado();
            mant.MdiParent = this;
            mant.Show();
            hideSubMenu();
        }

        private void btn_mantenimiento_departamentos_Click(object sender, EventArgs e)
        {
            CapaVistaNomina.frm_mantenimiento_departamento mantdep = new CapaVistaNomina.frm_mantenimiento_departamento();
            mantdep.MdiParent = this;
            mantdep.Show();
            hideSubMenu();
        }

        private void btn_deducciones_Click(object sender, EventArgs e)
        {
            CapaVistaNomina.frm_deduccion ded = new CapaVistaNomina.frm_deduccion();
            ded.MdiParent = this;
            ded.Show();
            hideSubMenu();
        }

        private void btn_nominas_Click(object sender, EventArgs e)
        {
            Vista_PrototipoMenu.frm_nomina nomi = new Vista_PrototipoMenu.frm_nomina();
            nomi.MdiParent = this;
            nomi.Show();
            hideSubMenu();
        }

        private void btn_percepciones_Click(object sender, EventArgs e)
        {
            CapaVistaNomina.frm_percepciones ded = new CapaVistaNomina.frm_percepciones();
            ded.MdiParent = this;
            ded.Show();
            hideSubMenu();

        }

        private void btn_mant_deducciones_Click(object sender, EventArgs e)
        {
            Vista_PrototipoMenu.frm_mantenimientoDeduccion dedMant = new Vista_PrototipoMenu.frm_mantenimientoDeduccion();
            dedMant.MdiParent = this;
            dedMant.Show();
            hideSubMenu();
        }

        private void btn_mant_perc_Click(object sender, EventArgs e)
        {
            Vista_PrototipoMenu.frm_mantenimientoPercepcion percMant = new Vista_PrototipoMenu.frm_mantenimientoPercepcion();
            percMant.MdiParent = this;
            percMant.Show();
            hideSubMenu();
        }
    }
}
