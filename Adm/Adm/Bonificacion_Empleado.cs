//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bonificacion_Empleado
    {
        public int Empleado_Id { get; set; }
        public int Id_Bonificacion { get; set; }
        public string Nombre_Hijo { get; set; }
        public System.DateTime Fecha_Nacimiento_Hijo { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
