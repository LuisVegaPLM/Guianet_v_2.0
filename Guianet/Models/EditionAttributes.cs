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
    
    public partial class EditionAttributes
    {
        public EditionAttributes()
        {
            this.EditionAttributeGroup = new HashSet<EditionAttributeGroup>();
        }
    
        public int AttributeId { get; set; }
        public int EditionId { get; set; }
    
        public virtual Attributes Attributes { get; set; }
        public virtual Editions Editions { get; set; }
        public virtual ICollection<EditionAttributeGroup> EditionAttributeGroup { get; set; }
    }
}
