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
    
    public partial class CategoriesThree
    {
        public CategoriesThree()
        {
            this.LeafHomogeneousCategories = new HashSet<LeafHomogeneousCategories>();
            this.ClientAdvertCategories = new HashSet<ClientAdvertCategories>();
            this.EditionCategoryThree = new HashSet<EditionCategoryThree>();
        }
    
        public int CategoryThreeId { get; set; }
        public string CategoryThree { get; set; }
        public byte Level { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<LeafHomogeneousCategories> LeafHomogeneousCategories { get; set; }
        public virtual ICollection<ClientAdvertCategories> ClientAdvertCategories { get; set; }
        public virtual ICollection<EditionCategoryThree> EditionCategoryThree { get; set; }
    }
}
