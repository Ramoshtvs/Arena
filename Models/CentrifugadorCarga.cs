//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arena.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CentrifugadorCarga
    {
        public int Id { get; set; }
        public Nullable<decimal> TemperaturaAgua { get; set; }
        public Nullable<decimal> Conductividad { get; set; }
        public Nullable<decimal> Ph { get; set; }
        public Nullable<decimal> DurezaAgua { get; set; }
        public Nullable<decimal> Silice { get; set; }
        public Nullable<decimal> Fosfato { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    }
}
