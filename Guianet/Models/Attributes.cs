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
    
    public partial class Attributes
    {
        public Attributes()
        {
            this.EditionAttributes = new HashSet<EditionAttributes>();
            this.ProductContents = new HashSet<ProductContents>();
        }
    
        public int AttributeId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<EditionAttributes> EditionAttributes { get; set; }
        public virtual ICollection<ProductContents> ProductContents { get; set; }
    }
}
