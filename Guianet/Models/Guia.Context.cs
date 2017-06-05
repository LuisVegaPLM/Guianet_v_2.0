﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GuiaEntities : DbContext
    {
        public GuiaEntities()
            : base("name=GuiaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Editions> Editions { get; set; }
        public virtual DbSet<ClientTypes> ClientTypes { get; set; }
        public virtual DbSet<EditionClients> EditionClients { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Alphabet> Alphabet { get; set; }
        public virtual DbSet<ClientProducts> ClientProducts { get; set; }
        public virtual DbSet<BarCodes> BarCodes { get; set; }
        public virtual DbSet<ClientProductBarCodes> ClientProductBarCodes { get; set; }
        public virtual DbSet<ParticipantProducts> ParticipantProducts { get; set; }
        public virtual DbSet<ClientProductLeafCategories> ClientProductLeafCategories { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<EditionClientProductSIDEF> EditionClientProductSIDEF { get; set; }
        public virtual DbSet<EditionClientProducts> EditionClientProducts { get; set; }
        public virtual DbSet<Distributors> Distributors { get; set; }
        public virtual DbSet<EditionBookClientProducts> EditionBookClientProducts { get; set; }
        public virtual DbSet<DistributorProducts> DistributorProducts { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<ProductStatus> ProductStatus { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<ClientBrands> ClientBrands { get; set; }
        public virtual DbSet<CategoriesThree> CategoriesThree { get; set; }
        public virtual DbSet<AdvertTypes> AdvertTypes { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<ClientAddresses> ClientAddresses { get; set; }
        public virtual DbSet<ClientPhones> ClientPhones { get; set; }
        public virtual DbSet<PhoneTypes> PhoneTypes { get; set; }
        public virtual DbSet<ClientBrandTypes> ClientBrandTypes { get; set; }
        public virtual DbSet<EditionClientProductShots> EditionClientProductShots { get; set; }
        public virtual DbSet<ReassignCategories> ReassignCategories { get; set; }
        public virtual DbSet<ClientAdverts> ClientAdverts { get; set; }
        public virtual DbSet<Adverts> Adverts { get; set; }
        public virtual DbSet<ImageSizes> ImageSizes { get; set; }
        public virtual DbSet<EditionProductShotSizes> EditionProductShotSizes { get; set; }
        public virtual DbSet<Attributes> Attributes { get; set; }
        public virtual DbSet<EditionAttributes> EditionAttributes { get; set; }
        public virtual DbSet<AttributeGroup> AttributeGroup { get; set; }
        public virtual DbSet<EditionAttributeGroup> EditionAttributeGroup { get; set; }
        public virtual DbSet<ProductContents> ProductContents { get; set; }
        public virtual DbSet<InternationalProducts> InternationalProducts { get; set; }
        public virtual DbSet<InternationalEditionClientProducts> InternationalEditionClientProducts { get; set; }
        public virtual DbSet<InternationalClientProducts> InternationalClientProducts { get; set; }
        public virtual DbSet<LeafCategories> LeafCategories { get; set; }
        public virtual DbSet<LeafHomogeneousCategories> LeafHomogeneousCategories { get; set; }
        public virtual DbSet<Works> Works { get; set; }
        public virtual DbSet<ProductAdverts> ProductAdverts { get; set; }
        public virtual DbSet<ClientProductAdverts> ClientProductAdverts { get; set; }
        public virtual DbSet<EditionClientProductAdverts> EditionClientProductAdverts { get; set; }
        public virtual DbSet<ClientAdvertCategories> ClientAdvertCategories { get; set; }
        public virtual DbSet<EditionCategoryThree> EditionCategoryThree { get; set; }
    }
}
