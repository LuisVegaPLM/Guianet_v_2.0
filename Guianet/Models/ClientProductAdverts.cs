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
    
    public partial class ClientProductAdverts
    {
        public ClientProductAdverts()
        {
            this.EditionClientProductAdverts = new HashSet<EditionClientProductAdverts>();
        }
    
        public int ClientId { get; set; }
        public int ProductAdvertId { get; set; }
    
        public virtual ProductAdverts ProductAdverts { get; set; }
        public virtual Clients Clients { get; set; }
        public virtual ICollection<EditionClientProductAdverts> EditionClientProductAdverts { get; set; }
    }
}
