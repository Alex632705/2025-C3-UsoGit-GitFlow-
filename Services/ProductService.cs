using ProyectoCRUD.Models;

namespace ProyectoCRUD.Services
{
    public class ProductService
    {
        private List<Product> products = new List<Product>();
        private int counter = 1;

        public void CreateProduct(string name, decimal price) {}
        public List<Product> ListProducts() => products;
        public void EditProduct(int id, string newName, decimal newPrice) {}
        public void DeleteProduct(int id) {}
    }
}
