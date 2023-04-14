using System.Data;

namespace AppCitasMedicas.Informes
{

    public partial class CitasxCliente : Form
    {
        Modelos.citasnombres obj_Citas = new Modelos.citasnombres();
        BaseDatos obj_base = new BaseDatos();
        public CitasxCliente()
        {
            InitializeComponent();
        }

        private void CitasxCliente_Load(object sender, EventArgs e)
        {
            List<Modelos.Combos> lista = new List<Modelos.Combos>();
            var datos = obj_base.ConsultarTerceros();
            lista.AddRange(datos.Where(r => r.getIdCargo() == 2).Select(
                x => new Modelos.Combos
                {
                    Id = x.getId().ToString(),
                    Nombre = x.getCodigo() + "-" + x.getNombre(),
                }
                ).ToList());

            Utilidades.Combos.LLenadoCombos(cbCliente, lista);
            dataGrid.Columns.Add("0", "Id");
            dataGrid.Columns.Add("0", "Fecha Cita");
            dataGrid.Columns.Add("0", "Doctor");

        }

        public void cargagrilla(int id)
        {
            List<Modelos.citasnombres> lista = obj_base.ConsultarCitasxCliente(id);
            dataGrid.AutoGenerateColumns = true;
            dataGrid.DataSource = null;
            //dataGrid.DataSource = lista;

            dataGrid.Rows.Clear();

            dataGrid.Columns.Add("0", "Id");
            dataGrid.Columns.Add("0", "Fecha Cita");
            dataGrid.Columns.Add("0", "Doctor");


            foreach (var item in lista)
            {
                dataGrid.Rows.Add(item.getId(), item.getfechaCita(), item.getNombreDoctor());
            }

            if (lista.Count > 0)
            {
                MessageBox.Show("e visualiza la siguienete informacion", "Consulta", MessageBoxButtons.OK,
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
            int id = int.Parse(cbCliente.SelectedValue.ToString());
            cargagrilla(id);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbCliente.SelectedIndex = 0;
            dataGrid.Rows.Clear();
        }
    }
}
