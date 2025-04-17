using ProductApi.Models;
using System.Xml.Linq;

namespace ProductApi.Repositories
{
    public static class ProductRepository
    {
        private static readonly List<Product> _products = new();
        private static int _nextId = 1;

        public static List<Product> GetAll() => _products;

        public static Product? GetById(int id) =>
            _products.FirstOrDefault(p => p.Id == id);

        public static Product Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return product;
        }

        public static bool Update(Product product)
        {
            var index = _products.FindIndex(p => p.Id == product.Id);
            if (index == -1) return false;
            _products[index] = product;
            return true;
        }

        public static bool Delete(int id)
        {
            var product = GetById(id);
            if (product is null) return false;
            _products.Remove(product);
            return true;
        }
    }
}
