using System.ComponentModel.DataAnnotations;
using System.Xml;

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
        [MinLength(2, ErrorMessage = "El nombre debe de tener más de dos caracteres")]
        [MaxLength(15, ErrorMessage = "El nombre debe ser inferior a 15 caracteres")]
        [Required(ErrorMessage = "Se requiere un nombre")]
        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }
        }
        [MinLength(2, ErrorMessage = "Los apellidos deben de tener más de dos caracteres")]
        [MaxLength(30, ErrorMessage = "Los apellidos deben ser inferior a 30 caracteres")]
        [Required(ErrorMessage ="Se requiere un apellido")]
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
        [Range(0,100, ErrorMessage ="La edad debe estar entre 0 y 100 años")]
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        #endregion
    }
}
