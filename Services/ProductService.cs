namespace ProductApi.Services
{
    using ProductApi.Models;
    using ProductApi.Repositories;

    public class ProductService : IProductService
    {
        public List<Product> GetAll() => ProductRepository.GetAll();

        public Product? GetById(int id) => ProductRepository.GetById(id);

        public Product Add(Product product) => ProductRepository.Add(product);

        public bool Update(Product product) => ProductRepository.Update(product);

        public bool Delete(int id) => ProductRepository.Delete(id);
    }
}
