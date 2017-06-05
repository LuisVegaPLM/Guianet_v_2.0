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
    
    public partial class EditionClients
    {
        public EditionClients()
        {
            this.ClientBrands = new HashSet<ClientBrands>();
            this.InternationalEditionClientProducts = new HashSet<InternationalEditionClientProducts>();
            this.EditionClientProductAdverts = new HashSet<EditionClientProductAdverts>();
            this.ClientAdvertCategories = new HashSet<ClientAdvertCategories>();
        }
    
        public int EditionId { get; set; }
        public int ClientId { get; set; }
        public string Page { get; set; }
        public byte ClientTypeId { get; set; }
        public System.DateTime AddedDate { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual ClientTypes ClientTypes { get; set; }
        public virtual Editions Editions { get; set; }
        public virtual ICollection<ClientBrands> ClientBrands { get; set; }
        public virtual ICollection<InternationalEditionClientProducts> InternationalEditionClientProducts { get; set; }
        public virtual ICollection<EditionClientProductAdverts> EditionClientProductAdverts { get; set; }
        public virtual ICollection<ClientAdvertCategories> ClientAdvertCategories { get; set; }
    }
}
