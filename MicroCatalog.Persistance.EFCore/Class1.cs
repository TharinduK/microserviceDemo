using MicroCatalog.PersistantModel;
using Microsoft.EntityFrameworkCore;
using System;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace MicroCatalog.Persistance.EFCore
{
    public class CatalogContext : Context
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }

        // Additional code ...

    }
}
