using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using Modelo_PrototipoMenu;

//Codigo submodulo deducciones creado por David Alejandro Carrillo de la Roca
//Codigo submodulo percepciones creado por Otto Adrian Lopez Ventura

namespace Controlador_PrototipoMenu
{
    public class Controlador
    {
        public Sentencias sn;

        public Controlador()
        {
            sn = new Sentencias();
        }

        public DataTable llenartabla(string tabla)
        {
            OdbcDataAdapter dt = sn.llenartabla(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;

        }

        public DataTable llenartablaMov(string tabla, int movimiento)
        {
            OdbcDataAdapter dt = sn.llenartablaMov(tabla, movimiento);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;

        }

        public Empleado BuscarEmpleadoPorID(int id)
        {
            Empleado empleado = sn.BuscarEmpleadoPorID(id);
            return empleado;
        }



        public double CalcularDeduccion(string deduccionMonto, double sueldoBase)
        {
            double montoDeduccion = sn.MontoDeduccion(deduccionMonto);
            return montoDeduccion;
        }

        public string ObtenerDepartamento(int idDepartamento)
        {
            string descripcion = sn.ObtenerDepartamento(idDepartamento);
            return descripcion;
        }

        public DataTable ObtenerDatosDedPerc()
        {
            string query = "SELECT dedperc_nombre FROM tbl_dedu_perc WHERE dedperc_movimiento = 1";
            return sn.ObtenerDatosDedPerc(query);
        }
        public DataTable ObtenerDatosPerc()
        {
            string query = "SELECT dedperc_nombre FROM tbl_dedu_perc WHERE dedperc_movimiento = 2";
            return sn.ObtenerDatosDedPerc(query);
        }


        public string ObtenerDeduccionTotal(int idDedEmp)
        {
            string descripcion = sn.ObtenerDeduccionTotal(idDedEmp);
            return descripcion;
        }

        public string ObtenerPercepcionTotal(int idPercEmp)
        {
            string descripcion = sn.ObtenerPercepcionTotal(idPercEmp);
            return descripcion;
        }

        public void InsertarNomina(int idEmpleado, string tipoMoneda, string sueldoBase, string totalPercepciones, string totalDeducciones, string sueldoFinal)
        {
            sn.InsertarNomina(idEmpleado, tipoMoneda, sueldoBase, totalPercepciones, totalDeducciones, sueldoFinal);

        }

        public void InsertarDeduccion(int idEmpleado, string dedperc_nombre, float dedperc_monto, int dedperc_movimiento)
        {
            sn.InsertarDeduccion(idEmpleado, dedperc_nombre, dedperc_monto, dedperc_movimiento);

        }

        public double CalcularPercepcion(string percepcionMonto, double sueldoBase)
        {
            double montoPercepcion = sn.MontoPercepcion(percepcionMonto);
            return montoPercepcion;
        }


        public void InsertarPercepcion(int idEmpleado, string dedperc_nombre, float dedperc_monto, int dedperc_movimiento)
        {
            sn.InsertarPercepcion(idEmpleado, dedperc_nombre, dedperc_monto, dedperc_movimiento);

        }

        public void GuardarDeduccionTotal(int idEmpleado, DateTime fecha, string deduccionTotal)
        {
     
            sn.GuardarDeduccionTotal(idEmpleado, fecha, deduccionTotal);
        }

        public void GuardarPercepcionTotal(int idEmpleado, DateTime fecha, string percepcionTotal)
        {

            sn.GuardarPercepcionTotal(idEmpleado, fecha, percepcionTotal);
        }


    }
}
