using MySql.Data.MySqlClient;
using System.Data;

namespace AppCitasMedicas
{
    internal class BaseDatos
    {
        #region declaracion
        List<Modelos.citasnombres> ListaCitasNombre = new List<Modelos.citasnombres>();
        List<Modelos.Cita> ListaCitas = new List<Modelos.Cita>();
        List<Modelos.cargo> ListaCargos = new List<Modelos.cargo>();
        List<Modelos.Tercero> ListaTerceros = new List<Modelos.Tercero>();
        MySqlConnection conn = new MySqlConnection();

        #endregion

        #region datosConexion

        static string Server = "localhost";
        static string user = "root";
        static string pass = "j.8916";
        static string port = "3306";
        static string db = "citasmedicas";

        static string ConnectionString = "server=" + Server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + pass + ";" + "database=" + db + ";";
        #endregion

        #region conn
        public MySqlConnection ConnSql()
        {
            conn.ConnectionString = ConnectionString;
            conn.Open();
            return conn;
        }

        public void closeSql()
        {
            try
            {

                conn.Close();
            }
            catch { }
        }

        #endregion 

        #region Cargos
        public void insertarCargos(Modelos.cargo datos)
        {
            // ConnSql();
            string Instruccionsql = "insert into cargo (nombre, estado, codigo) values(' " + datos.getNombre() + "'," + datos.getEstado() + ",' " + datos.getCodigo() + "')";
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(Instruccionsql, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public List<Modelos.cargo> ConsultarCargos()
        {
            ListaCargos = new List<Modelos.cargo>();
            string Instruccionsql = "select * from cargo";
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(Instruccionsql, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    conexion.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            ListaCargos.Add(new Modelos.cargo());
                            ListaCargos[i].setId((int)reader.GetInt32(0));
                            ListaCargos[i].setCodigo(reader.GetString(1));
                            ListaCargos[i].setNombre(reader.GetString(2));
                            ListaCargos[i].setestado(reader.GetInt16(3));
                            i++;
                        }
                    }

                    reader.Close();
                    return ListaCargos;
                }
            }
        }
        #endregion

        #region Terceros
        public void insertarTerceros(Modelos.Tercero datos)
        {
            // ConnSql();

            string Instruccionsql = "insert into terceros  (codigo,nombre,correo,idcargo) " +
                "values(' " + datos.getCodigo() + "','" + datos.getNombre() + "',' " + datos.getCorreo() + "', " + datos.getIdCargo() + ")";
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(Instruccionsql, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public List<Modelos.Tercero> ConsultarTerceros()
        {
            ListaTerceros = new List<Modelos.Tercero>();
            string Instruccionsql = "select * from terceros";
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(Instruccionsql, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    conexion.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            ListaTerceros.Add(new Modelos.Tercero());
                            ListaTerceros[i].setId((int)reader.GetInt32(0));
                            ListaTerceros[i].setCodigo(reader.GetString(1));
                            ListaTerceros[i].setNombre(reader.GetString(2));
                            ListaTerceros[i].setCorreo(reader.GetString(3));
                            ListaTerceros[i].setIdCargo(reader.GetInt16(4));
                            i++;
                        }
                    }

                    reader.Close();
                    return ListaTerceros;
                }
            }
        }
        #endregion

        #region Citas
        public void insertarCita(Modelos.Cita datos)
        {
            string Instruccionsql = "insert into citas  (idcliente, iddoctor, fechacita) " +
                "values('" + datos.getIdCliente() + "',' " + datos.getidDoctor() + "', '" + datos.getfechaCita() + "')";
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(Instruccionsql, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public List<Modelos.Cita> ConsultarCitas()
        {
            ListaCitas = new List<Modelos.Cita>();
            string Instruccionsql = "select * from citas";
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(Instruccionsql, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    conexion.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            ListaCitas.Add(new Modelos.Cita());
                            ListaCitas[i].setId((int)reader.GetInt32(0));
                            ListaCitas[i].setIdCliente(reader.GetInt32(1));
                            ListaCitas[i].setidDoctor(reader.GetInt32(2));
                            ListaCitas[i].setfechaCita(reader.GetString(3));
                            i++;
                        }
                    }

                    reader.Close();
                    return ListaCitas;
                }
            }
        }
        #endregion

        #region Consulta de Citas

        public List<Modelos.citasnombres> ConsultarCitasxCliente(int id)
        {
            ListaCitasNombre = new List<Modelos.citasnombres>();
            string Instruccionsql = "select c.*, cl.nombre as NombreCliente,  d.nombre as NombreDoctor from citas c inner join terceros cl on c.idcliente =cl.id inner join  terceros d on c.iddoctor =d.id where c.idcliente = " + id;
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(Instruccionsql, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    conexion.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            ListaCitasNombre.Add(new Modelos.citasnombres());
                            ListaCitasNombre[i].setId((int)reader.GetInt32(0));
                            ListaCitasNombre[i].setIdCliente(reader.GetInt32(1));
                            ListaCitasNombre[i].setidDoctor(reader.GetInt32(2));
                            ListaCitasNombre[i].setfechaCita(reader.GetString(3));
                            ListaCitasNombre[i].setNombreCliente(reader.GetString(4));
                            ListaCitasNombre[i].setNombreDoctor(reader.GetString(5));
                            i++;
                        }
                    }

                    reader.Close();
                    return ListaCitasNombre;
                }
            }
        }

        public List<Modelos.citasnombres> ConsultarCitasxDoctosyrangodefechas(int id, string fechaI, string fechaf)
        {
            //string Instruccionsql = "select c.*, cl.nombre as NombreCliente,  d.nombre as NombreDoctor from citas c inner join terceros cl on c.idcliente =cl.id inner join  terceros d on c.iddoctor =d.idwhere where c.iddoctor = " + id +" and fechaCita > '"+ fecha +"'";
            string Instruccionsql = "select c.*, cl.nombre as NombreCliente,  d.nombre as NombreDoctor from citas c inner join terceros cl on c.idcliente =cl.id inner join  terceros d on c.iddoctor =d.id where c.id =" + id + " and c.fechacita between '" + fechaI + "' and '" + fechaf + "'";
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                ListaCitasNombre = new List<Modelos.citasnombres>();
                using (MySqlCommand comando = new MySqlCommand(Instruccionsql, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    conexion.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            ListaCitasNombre.Add(new Modelos.citasnombres());
                            ListaCitasNombre[i].setId((int)reader.GetInt32(0));
                            ListaCitasNombre[i].setIdCliente(reader.GetInt32(1));
                            ListaCitasNombre[i].setidDoctor(reader.GetInt32(2));
                            ListaCitasNombre[i].setfechaCita(reader.GetString(3));
                            ListaCitasNombre[i].setNombreCliente(reader.GetString(4));
                            ListaCitasNombre[i].setNombreDoctor(reader.GetString(5));
                            i++;
                        }
                    }

                    reader.Close();
                    return ListaCitasNombre;
                }
            }
        }

        public List<Modelos.citasnombres> ConsultarCitasxrangodefechas(string fechaI, string fechaf)
        {
            //string Instruccionsql = "select c.*, cl.nombre as NombreCliente,  d.nombre as NombreDoctor from citas c inner join terceros cl on c.idcliente =cl.id inner join  terceros d on c.iddoctor =d.idwhere where c.iddoctor = " + id +" and fechaCita > '"+ fecha +"'";
            string Instruccionsql = "select c.*, cl.nombre as NombreCliente,  d.nombre as NombreDoctor from citas c inner join terceros cl on c.idcliente =cl.id inner join  terceros d on c.iddoctor =d.id where  c.fechacita between '" + fechaI + "' and '" + fechaf + "'";
            using (MySqlConnection conexion = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand comando = new MySqlCommand(Instruccionsql, conexion))
                {
                    comando.CommandType = CommandType.Text;
                    ListaCitasNombre = new List<Modelos.citasnombres>();
                    conexion.Open();
                    MySqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            ListaCitasNombre.Add(new Modelos.citasnombres());
                            ListaCitasNombre[i].setId((int)reader.GetInt32(0));
                            ListaCitasNombre[i].setIdCliente(reader.GetInt32(1));
                            ListaCitasNombre[i].setidDoctor(reader.GetInt32(2));
                            ListaCitasNombre[i].setfechaCita(reader.GetString(3));
                            ListaCitasNombre[i].setNombreCliente(reader.GetString(4));
                            ListaCitasNombre[i].setNombreDoctor(reader.GetString(5));
                            i++;
                        }
                    }

                    reader.Close();
                    return ListaCitasNombre;
                }
            }
        }
        #endregion
    }
}
