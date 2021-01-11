using CatalogueApp.Models;
namespace CatalogueApp.Services
{
    public static class DbInit
    {
        public static void initData(CatalogueDbRepository CatalogueDb){
            CatalogueDb.Categories.Add(new Category{Name="ordinateurs"});
            CatalogueDb.Categories.Add(new Category{Name="Imprt"});
            CatalogueDb.Categories.Add(new Category{Name="Table"});
            CatalogueDb.Products.Add(new Product{Name="hp",Price=123,CategoryID=1});
            CatalogueDb.Products.Add(new Product{Name="dell",Price=323,CategoryID=1});
            CatalogueDb.Products.Add(new Product{Name="hp",Price=673,CategoryID=2});
            CatalogueDb.Products.Add(new Product{Name="10x20",Price=453,CategoryID=3});
            CatalogueDb.SaveChanges();
        }
    }
}