using MySql.Data.MySqlClient;
using System.Data;

namespace AppCitasMedicas.Dao
{
    internal class Dao
    {
        public Dao()
        {

        }
        public bool EjecutarSql(string ConsultaInsertar, string cadenaConexion)
        {
            bool resultado = false;
            // Database Conexion = ObtenerConexion(NombreConexion);
            MySqlConnection mysqlConnection = null;
            MySqlCommand Comando = null;
            MySqlTransaction sqlTransaction = null;

            try
            {
                using (mysqlConnection = new MySqlConnection(cadenaConexion))
                {

                    mysqlConnection.Open();
                    sqlTransaction = mysqlConnection.BeginTransaction();

                    using (Comando = new MySqlCommand(ConsultaInsertar, mysqlConnection))
                    {

                        Comando.CommandType = CommandType.Text;
                        Comando.Transaction = sqlTransaction;

                        try
                        {

                            Comando.ExecuteNonQuery();
                            sqlTransaction.Commit();
                            resultado = true;
                        }
                        catch
                        {
                            sqlTransaction.Rollback();
                            //throw;
                        }

                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public DataTable EjecutarDTSql<Tabla>(string ConsultaInsertar, string cadenaConexion, ref Tabla Resultado) where Tabla : DataTable
        {
            // Database Conexion = ObtenerConexion(NombreConexion);
            MySqlConnection mysqlConnection = null;
            MySqlCommand Comando = null;
            MySqlTransaction sqlTransaction = null;

            try
            {
                using (mysqlConnection = new MySqlConnection(cadenaConexion))
                {

                    mysqlConnection.Open();
                    sqlTransaction = mysqlConnection.BeginTransaction();

                    using (Comando = new MySqlCommand(ConsultaInsertar, mysqlConnection))
                    {

                        Comando.CommandType = CommandType.Text;
                        Comando.Transaction = sqlTransaction;

                        try
                        {

                            Comando.ExecuteReader();
                            MySqlDataAdapter Adapter = new MySqlDataAdapter(Comando);
                            Adapter.Fill(Resultado);

                            sqlTransaction.Commit();
                            return Resultado;
                        }
                        catch
                        {
                            sqlTransaction.Rollback();
                            //throw;
                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return null;

        }


        public MySqlDataReader EjecutarDaterader(string ConsultaInsertar, string cadenaConexion)
        {
            // Database Conexion = ObtenerConexion(NombreConexion);
            MySqlConnection mysqlConnection = null;
            MySqlCommand Comando = null;
            MySqlTransaction sqlTransaction = null;

            try
            {
                using (mysqlConnection = new MySqlConnection(cadenaConexion))
                {

                    mysqlConnection.Open();
                    sqlTransaction = mysqlConnection.BeginTransaction();

                    using (Comando = new MySqlCommand(ConsultaInsertar, mysqlConnection))
                    {

                        Comando.CommandType = CommandType.Text;
                        Comando.Transaction = sqlTransaction;

                        try
                        {

                            var Resultado = Comando.ExecuteReader();
                            //MySqlDataAdapter Adapter = new MySqlDataAdapter(Comando);


                            sqlTransaction.Commit();
                            return Resultado;
                        }
                        catch
                        {
                            sqlTransaction.Rollback();
                            //throw;
                        }

                    }
                }
            }
            catch (Exception ex)
            {

            }
            return null;

        }

    }
}
