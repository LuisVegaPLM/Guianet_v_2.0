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
    
    public partial class ClientProductLeafCategories
    {
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int LeafCategoryId { get; set; }
        public string Module { get; set; }
        public int CategoryThreeId { get; set; }
    
        public virtual ClientProducts ClientProducts { get; set; }
        public virtual LeafHomogeneousCategories LeafHomogeneousCategories { get; set; }
    }
}
