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
    
    public partial class EditionBookClientProducts
    {
        public int EditionId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public string Page { get; set; }
        public System.DateTime AddedDate { get; set; }
    
        public virtual EditionClientProducts EditionClientProducts { get; set; }
    }
}
