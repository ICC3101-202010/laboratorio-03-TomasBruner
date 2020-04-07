using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    class Product
    {
        private string nameProduct;
        private string brand;
        private int price;
        private int stock;


        public Product()
        {

        }

        public string GetNameProduct()
        {
            return nameProduct;
        }
        public string GetBrand()
        {
            return brand;
        }
        public int GetPrice()
        {
            return price;
        }
        public int GetStock()
        {
            return stock;
        }

        
        List<string> brands = new List<string>();
        List<int> stocks = new List<int>();
        List<int> prices = new List<int>();
        List<string> nameProducts = new List<string>();
        List<int> totales = new List<int>();
        
        public void CreateProduct()
        {
            Console.WriteLine("Ingrese el nombre del producto");
            nameProduct = Console.ReadLine();
            Console.WriteLine("Ingrese la marca");
            brand = Console.ReadLine();
            Console.WriteLine("Ingrese el precio");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de stock disponible");
            stock = Convert.ToInt32(Console.ReadLine());

            nameProducts.Add(GetNameProduct());
            prices.Add(GetPrice());
            stocks.Add(GetStock());
            brands.Add(GetBrand());
            

        }

       

        public void SeeProducts()
        {

            int i = 0;
            while (i < nameProducts.Count())
            {
                Console.WriteLine((i + 1) + ". Nombre producto:" + nameProducts[i] + " Marca: " + brands[i] + " Precio: " + prices[i] + " Stock: " + stocks[i]);
                i++;
            }
        }

        
        public void SelectProduct()
        {
            int totalCompra = 0;
            int decision = Convert.ToInt32(Console.ReadLine());
            if (decision < nameProducts.Count() + 1)
            {
                Console.WriteLine("¿Cuantos " + nameProducts[decision - 1] + " desea comprar?");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                if (cantidad > stocks[decision - 1])
                {
                    Console.WriteLine("Hay un maximo de " + stocks[decision - 1] + ", porfavor ingrese un numero válido");
                }
                else
                {
                    
                    stocks[decision - 1] = stocks[decision - 1] - cantidad;
                    totalCompra = totalCompra + prices[decision - 1] * cantidad;
                    Console.WriteLine("Ha gastado en este producto " + totalCompra);
                    Console.WriteLine("Se ha añadido a su compra");
                    Console.WriteLine("¿Desea comprar algo más con este cliente? (si/no)");
                    
                }
                
            }
     
        }

        public void boleta(int decision)
        {
            
            Console.WriteLine("Gastó un total de: " + totales[decision]);
        
        }
    }
}

