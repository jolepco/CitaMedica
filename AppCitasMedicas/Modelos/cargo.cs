namespace AppCitasMedicas.Modelos
{
    internal class cargo
    {
        public cargo()
        {

        }
        private int id;
        private string Nombre;
        private int estado;
        private string Codigo;

        public void setId(int id) { this.id = id; }
        public void setNombre(string Nombre) { this.Nombre = Nombre; }
        public void setestado(int estado) { this.estado = estado; }
        public void setCodigo(string Codigo) { this.Codigo = Codigo; }

        public int getId() { return id; }
        public string getNombre() { return Nombre; }
        public int getEstado() { return estado; }
        public string getCodigo() { return Codigo; }
    }
}
