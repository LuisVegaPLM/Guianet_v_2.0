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
    
    public partial class Distributors
    {
        public Distributors()
        {
            this.DistributorProducts = new HashSet<DistributorProducts>();
        }
    
        public int DistributorId { get; set; }
        public string Distributor { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
    
        public virtual ICollection<DistributorProducts> DistributorProducts { get; set; }
    }
}
