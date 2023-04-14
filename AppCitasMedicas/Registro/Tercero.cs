using System.Data;

namespace AppCitasMedicas.Registro
{
    public partial class Tercero : Form
    {
        Modelos.Tercero obj_Tercero = new Modelos.Tercero();
        BaseDatos obj_base = new BaseDatos();
        public Tercero()
        {
            InitializeComponent();
        }

        private void Tercero_Load(object sender, EventArgs e)
        {
            var cargos = obj_base.ConsultarCargos();
            List<Modelos.Combos> listaCombos = new List<Modelos.Combos>();
            listaCombos.AddRange(cargos.Select(x => new Modelos.Combos
            {
                Id = x.getId().ToString(),
                Nombre = x.getNombre(),
            }).ToList());

            Utilidades.Combos.LLenadoCombos(cbEstados, listaCombos);
            cargagrilla();
        }
        public void cargagrilla()
        {
            List<Modelos.Tercero> lista = obj_base.ConsultarTerceros();
            dataGrid.AutoGenerateColumns = true;
            dataGrid.DataSource = null;
            //dataGrid.DataSource = lista;

            dataGrid.Rows.Clear();

            dataGrid.Columns.Add("0", "Id");
            dataGrid.Columns.Add("0", "Codigo");
            dataGrid.Columns.Add("0", "Nombre");
            dataGrid.Columns.Add("0", "Correo");
            dataGrid.Columns.Add("0", "Tipo de Tercero");

            foreach (var item in lista)
            {
                dataGrid.Rows.Add(item.getId(), item.getCodigo(), item.getNombre(), item.getCorreo(), item.getIdCargo());
            }

            //dataGrid.Refresh();


        }

        public void limpiarControles()
        {
            this.txtNombre.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int idCargo = int.Parse(cbEstados.SelectedValue.ToString());
            obj_Tercero.setNombre(this.txtNombre.Text);
            obj_Tercero.setCodigo(this.txtCodigo.Text);
            obj_Tercero.setCorreo(this.txtCorreo.Text);
            obj_Tercero.setIdCargo(idCargo);
            try
            {
                obj_base.insertarTerceros(obj_Tercero);
                cargagrilla();
                limpiarControles();
                MessageBox.Show("Se guarda la informacion en base de datos", "Cargos", MessageBoxButtons.OK,
                 MessageBoxIcon.Question);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cargos", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);

            }
        }
    }
}
