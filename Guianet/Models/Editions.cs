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
    
    public partial class Editions
    {
        public Editions()
        {
            this.EditionClients = new HashSet<EditionClients>();
            this.EditionClientProductSIDEF = new HashSet<EditionClientProductSIDEF>();
            this.EditionClientProducts = new HashSet<EditionClientProducts>();
            this.EditionAttributes = new HashSet<EditionAttributes>();
            this.EditionCategoryThree = new HashSet<EditionCategoryThree>();
        }
    
        public int EditionId { get; set; }
        public int NumberEdition { get; set; }
        public string ISBN { get; set; }
        public string BarCode { get; set; }
        public bool Active { get; set; }
        public byte CountryId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public int BookId { get; set; }
        public string EditionCode { get; set; }
        public System.DateTime AddDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Countries Countries { get; set; }
        public virtual Editions Editions1 { get; set; }
        public virtual Editions Editions2 { get; set; }
        public virtual ICollection<EditionClients> EditionClients { get; set; }
        public virtual ICollection<EditionClientProductSIDEF> EditionClientProductSIDEF { get; set; }
        public virtual ICollection<EditionClientProducts> EditionClientProducts { get; set; }
        public virtual ICollection<EditionAttributes> EditionAttributes { get; set; }
        public virtual ICollection<EditionCategoryThree> EditionCategoryThree { get; set; }
    }
}
