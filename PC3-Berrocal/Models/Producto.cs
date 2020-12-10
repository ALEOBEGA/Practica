using System.ComponentModel.DataAnnotations;

namespace PC3_Berrocal.Models{
    public class Producto
    {
        
        public int id { get; set; }
        public string Nombre_Producto { get; set; }
        public string Url { get; set; }
        public string Descripcion { get; set; }
        public double Precio_Total { get; set; }
        public int Celular { get; set; }
        public string Lugar { get; set; }
        public string Nombre_Usuario { get; set; }
    }
}