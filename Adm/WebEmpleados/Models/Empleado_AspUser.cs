//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebEmpleados.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado_AspUser
    {
        public int Id_mapeo { get; set; }
        public int Empleado_Id { get; set; }
        public string Asp_User_Id { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string observacion { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}