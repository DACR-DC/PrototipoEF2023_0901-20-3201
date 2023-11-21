using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;


//Codigo submodulo deducciones creado por David Alejandro Carrillo de la Roca
//Codigo submodulo percepciones creado por Otto Adrian Lopez Ventura
namespace Modelo_PrototipoMenu
{
    public class Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sueldo { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public string Moneda { get; set; }
    }

    
    public class Departamento
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }
    /*
    public class DeduccionTotal
    {
        public int tbl_empleado_Pk_id_empleado { get; set; }
        public string ded_deducciones_totales { get; set; }
    }

    public class PercepcionTotal
    {
        public int tbl_empleado_Pk_id_empleado { get; set; }
        public string perc_totales { get; set; }
    }*/

    public class Sentencias
    {
        public Conexion con;


        public Sentencias()
        {
            con = new Conexion();
        }

        private string conec = "Dsn=HotelSConexion";

        public Empleado BuscarEmpleadoPorID(int idEmpleado)
        {
            Empleado empleadoEncontrado = null;

            using (OdbcConnection conn = new OdbcConnection(conec))
            {
                try
                {
                    conn.Open();

                    string consulta = "SELECT emp_nombre, emp_apellido, emp_sueldo, emp_cargo, emp_tipo_moneda,tbl_departamento_Pk_id_departamento FROM tbl_empleado WHERE Pk_id_empleado = ?";
                    using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idEmpleado);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                empleadoEncontrado = new Empleado
                                {
                                    ID = idEmpleado,
                                    Nombre = reader["emp_nombre"].ToString(),
                                    Apellido = reader["emp_apellido"].ToString(),
                                    Sueldo = reader["emp_sueldo"].ToString(),
                                    Cargo = reader["emp_cargo"].ToString(),
                                    Moneda = reader["emp_tipo_moneda"].ToString(),
                                    Departamento= reader["tbl_departamento_Pk_id_departamento"].ToString(),
                                };
                            }
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al buscar el empleado: " + ex.Message);
                }
            }

            return empleadoEncontrado;
        }

        public OdbcDataAdapter llenartabla(string tabla)
        {
            string sql = "select * from " + tabla + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.connection());
            return datatable;


        }


        public OdbcDataAdapter llenartablaMov(string tabla, int movimiento)
        {
            string sql = "SELECT * FROM " + tabla + " WHERE dedperc_movimiento = " + movimiento + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.connection());
            return datatable;
        }


        public void InsertarDeduccion(int idEmpleado, string dedperc_nombre, float dedperc_monto, int dedperc_movimiento)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_dedu_perc (`Pk_id_dedu_perc`, `dedperc_nombre`, `dedperc_monto`, `dedperc_movimiento`) VALUES (?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Pk_id_dedu_perc", idEmpleado);
                                cmd.Parameters.AddWithValue("@dedperc_nombre", dedperc_nombre);
                                cmd.Parameters.AddWithValue("@dedperc_monto", dedperc_monto);
                                cmd.Parameters.AddWithValue("@dedperc_movimiento", dedperc_movimiento);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al Guardar la deduccion: {ex.Message}");
                        }
                    }
                }
            }
        }

        public void InsertarPercepcion(int idEmpleado, string dedperc_nombre, float dedperc_monto, int dedperc_movimiento)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_dedu_perc (`Pk_id_dedu_perc`, `dedperc_nombre`, `dedperc_monto`, `dedperc_movimiento`) VALUES (?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Pk_id_dedu_perc", idEmpleado);
                                cmd.Parameters.AddWithValue("@dedperc_nombre", dedperc_nombre);
                                cmd.Parameters.AddWithValue("@dedperc_monto", dedperc_monto);
                                cmd.Parameters.AddWithValue("@dedperc_movimiento", dedperc_movimiento);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al Guardar la percepcion: {ex.Message}");
                        }
                    }
                }
            }
        }

        public void GuardarDeduccionTotal(int idEmpleado, DateTime fecha, string deduccionTotal)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_deducciones (`ded_deducciones_totales`, `ded_fecha_ded`, `tbl_empleado_Pk_id_empleado`) VALUES (?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ded_deducciones_totales", deduccionTotal);
                                cmd.Parameters.AddWithValue("@ded_fecha_ded", fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.Parameters.AddWithValue("@tbl_empleado_Pk_id_empleado", idEmpleado);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al Guardar el resultado: {ex.Message}");
                        }
                    }
                }
            }
        }


        public void GuardarPercepcionTotal(int idEmpleado, DateTime fecha, string percepcionTotal)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_percepciones (`perc_totales`, `perc_fecha_perc`, `tbl_empleado_Pk_id_empleado`) VALUES (?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@perc_totales", percepcionTotal);
                                cmd.Parameters.AddWithValue("@perc_fecha_perc", fecha.ToString("yyyy-MM-dd HH:mm:ss"));
                                cmd.Parameters.AddWithValue("@tbl_empleado_Pk_id_empleado", idEmpleado);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al Guardar el resultado: {ex.Message}");
                        }
                    }
                }
            }
        }





        public double MontoDeduccion(string deduccionMonto)
        {
            double monto = 0.0;
            try
            {
                using (OdbcConnection conn = new OdbcConnection(conec))
                {
                    conn.Open();

                    string query = "SELECT dedperc_monto FROM tbl_dedu_perc WHERE dedperc_nombre = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("dedperc_nombre", deduccionMonto);
                        monto = Convert.ToDouble(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return monto;
        }


        public double MontoPercepcion(string percepcionMonto)
        {
            double monto = 0.0;
            try
            {
                using (OdbcConnection conn = new OdbcConnection(conec))
                {
                    conn.Open();

                    string query = "SELECT dedperc_monto FROM tbl_dedu_perc WHERE dedperc_nombre = ?";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("dedperc_nombre", percepcionMonto);
                        monto = Convert.ToDouble(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return monto;
        }


        public string ObtenerDepartamento(int idDepartamento)
        {

            using (OdbcConnection cone = new OdbcConnection(conec))
            {
                cone.Open();

                using (OdbcCommand cmd = new OdbcCommand("SELECT dpt_nombre FROM tbl_departamento WHERE Pk_id_departamento = ?", cone))
                {
                    cmd.Parameters.Add(new OdbcParameter("Pk_id_departamento", idDepartamento));
                    string descripcion = cmd.ExecuteScalar()?.ToString();
                    return descripcion;
                }
            }
        }

        public string ObtenerDeduccionTotal(int idDedEmp)
        {
            using (OdbcConnection cone = new OdbcConnection(conec))
            {
                cone.Open();
                using (OdbcCommand cmd = new OdbcCommand("SELECT ded_deducciones_totales FROM tbl_deducciones WHERE tbl_empleado_Pk_id_empleado = ?", cone))
                {
                    cmd.Parameters.Add(new OdbcParameter("tbl_empleado_Pk_id_empleado", idDedEmp));
                    string descripcion = cmd.ExecuteScalar()?.ToString();
                    return descripcion;
                }
            }
        }

        public string ObtenerPercepcionTotal(int idPercEmp)
        {

            using (OdbcConnection cone = new OdbcConnection(conec))
            {
                cone.Open();

                using (OdbcCommand cmd = new OdbcCommand("SELECT perc_totales FROM tbl_percepciones WHERE tbl_empleado_Pk_id_empleado = ?", cone))
                {
                    cmd.Parameters.Add(new OdbcParameter("tbl_empleado_Pk_id_empleado", idPercEmp));
                    string descripcion = cmd.ExecuteScalar()?.ToString();
                    return descripcion;
                }
            }
        }

        public DataTable ObtenerDatosDedPerc(string query)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            return null;
        }

        public void InsertarNomina(int idEmpleado, string tipoMoneda, string sueldoBase, string totalPercepciones, string totalDeducciones, string sueldoFinal)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_nomina (nomi_tipo_moneda, nomi_sueldo_base, nomi_total_percepciones, nomi_total_deducciones, nomi_sueldo_final, tbl_empleado_Pk_id_empleado) VALUES (?,?,?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@nomi_tipo_moneda", tipoMoneda);
                                cmd.Parameters.AddWithValue("@nomi_sueldo_base", sueldoBase);
                                cmd.Parameters.AddWithValue("@nomi_total_percepciones", totalPercepciones);
                                cmd.Parameters.AddWithValue("@nomi_total_deducciones", totalDeducciones);
                                cmd.Parameters.AddWithValue("@nomi_sueldo_final", sueldoFinal);
                                cmd.Parameters.AddWithValue("@tbl_empleado_Pk_id_empleado", idEmpleado);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al guardar la nómina: {ex.Message}");
                        }
                    }
                }
            }
        }



    }
}
