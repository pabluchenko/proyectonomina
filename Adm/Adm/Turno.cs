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
    
    public partial class Turno
    {
        public int Id_Turno { get; set; }
        public string Hora_Entrada { get; set; }
        public string Hora_Salida { get; set; }
        public string Observaciones { get; set; }

        public override string ToString()
        {
            return " DE: " + this.Hora_Entrada + "  A: " + this.Hora_Salida;
        }
    }
    
}
