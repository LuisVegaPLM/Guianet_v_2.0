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
    
    public partial class EditionClientProducts
    {
        public int EditionId { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public System.DateTime AddedDate { get; set; }
        public bool Validation { get; set; }
    
        public virtual ClientProducts ClientProducts { get; set; }
        public virtual Editions Editions { get; set; }
        public virtual ParticipantProducts ParticipantProducts { get; set; }
        public virtual EditionBookClientProducts EditionBookClientProducts { get; set; }
        public virtual Status Status { get; set; }
    }
}
