namespace AppCitasMedicas.Informes
{
    public partial class ConsultarCitasxrangodefechas : Form
    {
        BaseDatos obj_base = new BaseDatos();
        public ConsultarCitasxrangodefechas()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
        }
        public void cargagrilla(string inicial, string fin)
        {
            dataGrid.Rows.Clear();
            dataGrid.Refresh();
            List<Modelos.citasnombres> lista = new List<Modelos.citasnombres>();
            lista = obj_base.ConsultarCitasxrangodefechas(inicial, fin);
            //dataGrid.AutoGenerateColumns = true;
            dataGrid.DataSource = null;
            //dataGrid.DataSource = lista;

            //dataGrid.Columns.Add("0", "Id");
            //dataGrid.Columns.Add("0", "Fecha Cita");
            //dataGrid.Columns.Add("0", "Cliente");
            //dataGrid.Columns.Add("0", "Doctor");

            foreach (var item in lista)
            {
                dataGrid.Rows.Add(item.getId(), item.getfechaCita(), item.getNombreCliente(), item.getNombreDoctor());
            }

            if (lista.Count > 0)
            {
                MessageBox.Show("Se visualiza la siguienete informacion", "Consulta", MessageBoxButtons.OK,
                MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("No se Encuentra información", "Cargos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            //dataGrid.Refresh();


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var inicial = dateTimePickerInit.Value.ToString("yyyy/MM/dd HH:mm:ss");
            var fin = dateTimePickerEnd.Value.ToString("yyyy/MM/dd HH:mm:ss");


            cargagrilla(inicial, fin);
        }

        private void ConsultarCitasxrangodefechas_Load(object sender, EventArgs e)
        {
            dataGrid.Columns.Add("0", "Id");
            dataGrid.Columns.Add("0", "Fecha Cita");
            dataGrid.Columns.Add("0", "Cliente");
            dataGrid.Columns.Add("0", "Doctor");
        }
    }
}
