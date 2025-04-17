namespace ProductApi.Services
{
    using ProductApi.Models;

    public interface IProductService
    {
        List<Product> GetAll();
        Product? GetById(int id);
        Product Add(Product product);
        bool Update(Product product);
        bool Delete(int id);
    }
}
