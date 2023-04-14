using AppCitasMedicas.Modelos;

namespace AppCitasMedicas.Registro
{
    public partial class TiposTerceros : Form
    {
        cargo obj_cargo = new cargo();
        BaseDatos obj_base = new BaseDatos();

        public TiposTerceros()
        {
            InitializeComponent();
        }

        public void limpiarControles()
        {
            this.txtNombre.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            int estado = cbEstados.SelectedValue.ToString() == "1" ? 1 : 0;
            obj_cargo.setNombre(this.txtNombre.Text);
            obj_cargo.setCodigo(this.txtCodigo.Text);
            obj_cargo.setestado(estado);
            try
            {
                obj_base.insertarCargos(obj_cargo);
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


        public void cargagrilla()
        {
            List<Modelos.cargo> lista = obj_base.ConsultarCargos();
            dataGrid.AutoGenerateColumns = true;
            dataGrid.DataSource = null;
            //dataGrid.DataSource = lista;

            dataGrid.Rows.Clear();

            dataGrid.Columns.Add("0", "Id");
            dataGrid.Columns.Add("0", "Codigo");
            dataGrid.Columns.Add("0", "Nombre");
            dataGrid.Columns.Add("0", "Estado");

            foreach (var item in lista)
            {
                dataGrid.Rows.Add(item.getId(), item.getCodigo(), item.getNombre(), item.getEstado());
            }

            //dataGrid.Refresh();


        }

        private void TiposTerceros_Load(object sender, EventArgs e)
        {

            var estado = Utilidades.Combos.listaEstados();
            Utilidades.Combos.LLenadoCombos(cbEstados, estado);
            cargagrilla();

        }

    }
}
