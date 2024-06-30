using FishingStore.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingStore.ViewModels
{
    internal class ProductViewModel : BaseViewModel
    {
        public ProductService _productService;
        public ObservableCollection<Products> Products { get; set; }

        public ProductViewModel()
        {
            _productService = new ProductService();
            Products = new ObservableCollection<Products>(_productService.GetProducts());
        }

        // Implement other necessary methods like AddProduct, EditProduct, etc.
    }
}