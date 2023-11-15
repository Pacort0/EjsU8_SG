namespace EjsU8_SG_Ej3.Models.Entities
{
    public class clsPersona
    {
        #region atributos
        private string nombre;
        private string apellidos;
        private string direccion;
        private int edad;
        private int id;
        #endregion

        #region constructores
        public clsPersona() { }

        public clsPersona(int id, string nombre, string apellidos, string direccion, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.edad = edad;
        }
        #endregion

        #region propiedades
        public int Id
        {
            get {  return id; } 
            set { id = value; } //Sé que no se puede tener un set en un id, pero quiero declarar el objeto clsPersona en el controller
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos 
        { 
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        #endregion
    }
}
