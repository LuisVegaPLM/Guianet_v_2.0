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
    
    public partial class InternationalClientProducts
    {
        public InternationalClientProducts()
        {
            this.InternationalEditionClientProducts = new HashSet<InternationalEditionClientProducts>();
        }
    
        public int InternationalProductId { get; set; }
        public int ClientId { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual InternationalProducts InternationalProducts { get; set; }
        public virtual ICollection<InternationalEditionClientProducts> InternationalEditionClientProducts { get; set; }
    }
}
