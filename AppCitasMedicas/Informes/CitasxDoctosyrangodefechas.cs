namespace AppCitasMedicas.Informes
{
    public partial class CitasxDoctosyrangodefechas : Form
    {
        Modelos.citasnombres obj_Citas = new Modelos.citasnombres();
        BaseDatos obj_base = new BaseDatos();
        public CitasxDoctosyrangodefechas()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbDoctor.SelectedIndex = 0;
            dataGrid.Rows.Clear();
        }
        public void cargagrilla(int id, string inicial, string fin)
        {
            List<Modelos.citasnombres> lista = obj_base.ConsultarCitasxDoctosyrangodefechas(id, inicial, fin);
            dataGrid.AutoGenerateColumns = true;
            dataGrid.DataSource = null;
            //dataGrid.DataSource = lista;

            dataGrid.Rows.Clear();

            dataGrid.Columns.Add("0", "Id");
            dataGrid.Columns.Add("0", "Fecha Cita");
            dataGrid.Columns.Add("0", "Cliente");


            foreach (var item in lista)
            {
                dataGrid.Rows.Add(item.getId(), item.getfechaCita(), item.getNombreCliente());
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

        private void CitasxDoctosyrangodefechas_Load(object sender, EventArgs e)
        {
            List<Modelos.Combos> lista = new List<Modelos.Combos>();
            var datos = obj_base.ConsultarTerceros();
            lista.AddRange(datos.Where(r => r.getIdCargo() == 1).Select(
                x => new Modelos.Combos
                {
                    Id = x.getId().ToString(),
                    Nombre = x.getCodigo() + "-" + x.getNombre(),
                }
                ).ToList());

            Utilidades.Combos.LLenadoCombos(cbDoctor, lista);

            dataGrid.Columns.Add("0", "Id");
            dataGrid.Columns.Add("0", "Fecha Cita");
            dataGrid.Columns.Add("0", "Cliente");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idDoctor = int.Parse(cbDoctor.SelectedValue.ToString());
            var inicial = dateTimePickerInit.Value.ToString("yyyy/MM/dd HH:mm:ss");
            var fin = dateTimePickerEnd.Value.ToString("yyyy/MM/dd HH:mm:ss");
            cargagrilla(idDoctor, inicial, fin);

        }
    }
}
