//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NMA_DESK.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class accidente
    {
        public int id_accidente { get; set; }
        public Nullable<System.DateTime> fec_accident { get; set; }
        public string tipo_accidente { get; set; }
        public string run_trabajador { get; set; }
        public byte[] doc_diat { get; set; }
        public string nombre_doc_diat { get; set; }
        public string content_type_doc_diat { get; set; }
        public string estado_accidente { get; set; }
        public Nullable<int> id_usuario { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}
