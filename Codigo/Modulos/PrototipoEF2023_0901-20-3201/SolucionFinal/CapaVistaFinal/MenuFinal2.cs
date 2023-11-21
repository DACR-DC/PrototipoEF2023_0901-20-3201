using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaFinal
{
    public partial class MenuFinal2 : Form
    {
        public MenuFinal2()
        {
            InitializeComponent();
        }

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

        private void btn_mantenimiento_empleados_Click(object sender, EventArgs e)
        {
            CapaVistaFinal.MantenimientoLinea mant = new CapaVistaFinal.MantenimientoLinea();
            mant.MdiParent = this;
            mant.Show();
            hideSubMenu();
        }

        private void btnmanteniminetos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTranportes);
        }

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

        private void btnSeguridad_Click_1(object sender, EventArgs e)
        {

        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudasParcial/ParcialFinal.chm", "ParcialFinal.html");
        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            CapaVistaFinal.Reporte rep = new CapaVistaFinal.Reporte();
            rep.MdiParent = this;
            rep.Show();
            hideSubMenu();
        }
    }
}
