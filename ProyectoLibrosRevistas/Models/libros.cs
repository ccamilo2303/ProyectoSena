//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoLibrosRevistas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class libros
    {
        public int id_Libro { get; set; }
        public Nullable<int> id_autor { get; set; }
        public Nullable<int> id_genero { get; set; }
        public Nullable<int> id_Informacion { get; set; }
    
        public virtual autores autores { get; set; }
        public virtual generos generos { get; set; }
        public virtual revistas_libros revistas_libros { get; set; }
    }
}
