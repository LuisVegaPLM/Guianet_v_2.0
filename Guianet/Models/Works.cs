//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Guianet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Works
    {
        public int WorkId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public string WorkDescription { get; set; }
        public System.DateTime AddedDate { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string Module { get; set; }
        public string Details { get; set; }
        public bool Active { get; set; }
        public string WorkDescriptionLevelThree { get; set; }
    
        public virtual ClientProducts ClientProducts { get; set; }
    }
}