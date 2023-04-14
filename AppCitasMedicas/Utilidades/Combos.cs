namespace AppCitasMedicas.Utilidades
{
    public class Combos
    {
        public static void LLenadoCombos(ComboBox combo, List<Modelos.Combos> Lista)
        {
            combo.DataSource = null;
            combo.Items.Clear();
            if (Lista.Where(c => c.Id == "0").Count() == 0)
                Lista.Add(new Modelos.Combos { Nombre = "Seleccionar", Id = "0" });
            Lista = Lista.OrderBy(c => Convert.ToInt32(c.Id)).ToList();
            combo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //      combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection Datos = new AutoCompleteStringCollection();
            Datos.AddRange(Lista.Select(c => c.Nombre).ToArray());
            combo.AutoCompleteCustomSource = Datos;
            combo.DataSource = Lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id";
            ///cambio save
        }

        public static List<Modelos.Combos> listaEstados()
        {
            List<Modelos.Combos> lista = new List<Modelos.Combos>();

            lista.AddRange(new List<Modelos.Combos> {
               new Modelos.Combos {Id = "0",Nombre = "Inactivo",},
                new Modelos.Combos { Id = "1",Nombre = "Activo",}
               });

            return lista;
        }
    }
}
