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
    
    public partial class ClientAdvertCategories
    {
        public int ClientId { get; set; }
        public int AdvertId { get; set; }
        public int EditionId { get; set; }
        public int CategoryThreeId { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<byte> AdvertTypeId { get; set; }
    
        public virtual AdvertTypes AdvertTypes { get; set; }
        public virtual CategoriesThree CategoryThree { get; set; }
        public virtual ClientAdverts ClientAdverts { get; set; }
        public virtual EditionClients EditionClients { get; set; }
    }
}
