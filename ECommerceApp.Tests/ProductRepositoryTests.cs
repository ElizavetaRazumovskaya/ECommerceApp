using Xunit;
using ECommerceApp.Core.Models;
using ECommerceApp.Data.Repositories;

namespace ECommerceApp.Tests
{
    public class ProductRepositoryTests
    {
        [Fact]
        public void AddProduct_ShouldIncreaseCount()
        {
            
            var repo = new ProductRepository();
            var product = new Product(1, "Laptop", 50000);

            
            repo.AddProduct(product);

          
            var products = repo.GetAllProducts();
            Assert.Single(products);
            Assert.Equal("Laptop", products[0].Name);
        }

        [Fact]
        public void GetById_ShouldReturnCorrectProduct()
        {
           
            var repo = new ProductRepository();
            var p1 = new Product(1, "Laptop", 50000);
            var p2 = new Product(2, "Mouse", 1000);
            repo.AddProduct(p1);
            repo.AddProduct(p2);

            var result = repo.GetById(2);

            
            Assert.NotNull(result);
            Assert.Equal("Mouse", result!.Name);
        }
    }
}