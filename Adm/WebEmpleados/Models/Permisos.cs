//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebEmpleados.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permisos
    {
        public int Id_Permiso { get; set; }
        public int Empleado_Id { get; set; }
        public System.DateTime Fecha_Desde { get; set; }
        public System.DateTime Fecha_Hasta { get; set; }
        public string Motivo { get; set; }
        public int Cantidad_Horas { get; set; }
        public System.DateTime Fecha_Solicitud { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
