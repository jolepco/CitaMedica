using System.Data;

namespace AppCitasMedicas.Registro
{
    public partial class Citas : Form
    {
        Modelos.Cita obj_Citas = new Modelos.Cita();
        BaseDatos obj_base = new BaseDatos();

        public Citas()
        {
            InitializeComponent();
        }

        private void Citas_Load(object sender, EventArgs e)
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
            lista = new List<Modelos.Combos>();
            lista.AddRange(datos.Where(r => r.getIdCargo() == 1).Select(
                x => new Modelos.Combos
                {
                    Id = x.getId().ToString(),
                    Nombre = x.getCodigo() + "-" + x.getNombre(),
                }
                ).ToList());

            Utilidades.Combos.LLenadoCombos(cbDoctor, lista);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            int idDoctor = int.Parse(cbDoctor.SelectedValue.ToString());
            int idCliente = int.Parse(cbCliente.SelectedValue.ToString());



            obj_Citas.setIdCliente(idCliente);
            obj_Citas.setidDoctor(idDoctor);

            DateTime fecha1 = dateTimePicker1.Value;

            var salida = fecha1.ToString("yyyy/MM/dd HH:mm:ss");

            obj_Citas.setfechaCita(salida);
            try
            {
                obj_base.insertarCita(obj_Citas);
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
