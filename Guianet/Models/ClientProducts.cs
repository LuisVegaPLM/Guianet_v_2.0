//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Guianet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientProducts
    {
        public ClientProducts()
        {
            this.ClientProductBarCodes = new HashSet<ClientProductBarCodes>();
            this.ClientProductLeafCategories = new HashSet<ClientProductLeafCategories>();
            this.EditionClientProductSIDEF = new HashSet<EditionClientProductSIDEF>();
            this.EditionClientProducts = new HashSet<EditionClientProducts>();
            this.ProductStatus = new HashSet<ProductStatus>();
            this.ReassignCategories = new HashSet<ReassignCategories>();
            this.Works = new HashSet<Works>();
        }
    
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public string RegisterSanitary { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Products Products { get; set; }
        public virtual ICollection<ClientProductBarCodes> ClientProductBarCodes { get; set; }
        public virtual ICollection<ClientProductLeafCategories> ClientProductLeafCategories { get; set; }
        public virtual ICollection<EditionClientProductSIDEF> EditionClientProductSIDEF { get; set; }
        public virtual ICollection<EditionClientProducts> EditionClientProducts { get; set; }
        public virtual ICollection<ProductStatus> ProductStatus { get; set; }
        public virtual ICollection<ReassignCategories> ReassignCategories { get; set; }
        public virtual ICollection<Works> Works { get; set; }
    }
}
