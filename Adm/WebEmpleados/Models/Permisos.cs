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
