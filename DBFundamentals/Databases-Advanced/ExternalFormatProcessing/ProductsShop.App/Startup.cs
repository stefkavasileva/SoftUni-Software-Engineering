using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductsShop.Data;
using ProductsShop.Models;

namespace ProductsShop.App
{
    public class Startup
    {
        static void Main()
        {
            //using (var db = new ProductsShopContext())
            //{
            //    db.Database.EnsureDeleted();
            //    db.Database.EnsureCreated();
            //}

            //// ============ Import Data===============/////
            //ImportUsersFromJsonFile("Files/users.json");
            //ImportCategories("Files/categories.json");
            //ImportProducts("Files/products.json");

            //=======Export ===========///
            //01Products In Range//
            //var jsonString = GetProductsInRange();
            //File.WriteAllText("productInRange.json", jsonString);

            // 02. Successfully Sold Products
            //var jsonString = GetSoldProducts();
            //File.WriteAllText("soldProducts.json", jsonString);

            ////03. Categories By Products Count
            //var jsonString = GetCategoryByProductCount();
            //File.WriteAllText("categoryByProductCount.json", jsonString);

            ////04. Users and Products
            //var jsonString = GetUsersAndProducts();
            //File.WriteAllText("usersAndProduct.json", jsonString);
        }

        private static string GetUsersAndProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var users = context
                    .Users
                    .Where(u => u.SoldProducts.Count > 0)
                    .OrderByDescending(u => u.SoldProducts.Count)
                    .ThenBy(u => u.LastName)
                    .Include(u => u.SoldProducts)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        age = u.Age,
                        soldProducts = u.SoldProducts
                            .Select(p => new
                            {
                                name = p.Name,
                                price = p.Price
                            })
                    });

                return JsonConvert.SerializeObject(users);
            }

        }

        private static string GetCategoryByProductCount()
        {
            using (var context = new ProductsShopContext())
            {
                var categories = context
                    .Categories
                    .OrderBy(c => c.Name)
                    .Include(c => c.CategoryProductses)
                    .ThenInclude(cp => cp.Product)
                    .Select(c => new
                    {
                        name = c.Name,
                        productsCount = c.CategoryProductses.Count,
                        averagePrice = c.CategoryProductses.Average(cp => cp.Product.Price),
                        totalRevenue = c.CategoryProductses.Sum(cp => cp.Product.Price)
                    });

                return JsonConvert.SerializeObject(categories);
            }

        }

        private static string GetSoldProducts()
        {
            using (var context = new ProductsShopContext())
            {
                var users = context
                    .Users
                    .Where(u => u.SoldProducts.Count > 0)
                    .Include(u => u.BougthProducts)
                    .ThenInclude(p => p.Buyer)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        soldProducts = u.BougthProducts
                            .Select(p => new
                            {
                                name = p.Name,
                                price = p.Price,
                                buyerFirstName = p.Buyer.FirstName,
                                buyerLastName = p.Buyer.LastName
                            })
                    })
                    .OrderBy(u => u.firstName)
                    .ThenBy(u => u.lastName)
                    .ToList();

                return JsonConvert.SerializeObject(users);
            }

        }

        private static string GetProductsInRange()
        {
            using (var context = new ProductsShopContext())
            {
                var currentProducts = context
                    .Products
                    .Include(p => p.Seller)
                    .Where(p => p.Price >= 500 && p.Price <= 1000)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                    })
                    .OrderByDescending(p => p.price)
                    .ToList();

                return JsonConvert.SerializeObject(currentProducts);
            }

        }

        public static void ImportUsersFromJsonFile(string path)
        {
            var jsonString = File.ReadAllText(path);

            var users = JsonConvert.DeserializeObject<User[]>(jsonString);

            using (var context = new ProductsShopContext())
            {
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }

        public static void ImportProducts(string path)
        {
            var stringJson = File.ReadAllText(path);

            var products = JsonConvert.DeserializeObject<Product[]>(stringJson);

            using (var context = new ProductsShopContext())
            {
                var random = new Random();
                var userIds = context.Users.Select(u => u.Id).ToList();
                var index = random.Next(0, userIds.Count);
                var sellerId = userIds[index];
                int? buyerId = sellerId;

                while (buyerId == sellerId)
                {
                    var buyerIndex = random.Next(0, userIds.Count);
                    buyerId = userIds[buyerIndex];
                }

                foreach (var product in products)
                {
                    index = random.Next(0, userIds.Count);
                    sellerId = userIds[index];
                    product.SellerId = sellerId;

                    if (buyerId - sellerId < 5 && buyerId - sellerId > 0)
                    {
                        buyerId = null;
                    }
                    product.BuyerId = buyerId;

                }

                context.Products.AddRange(products);

                var categoryIds = context.Categories.Select(c => c.Id).ToList();

                foreach (var product in products)
                {
                    index = random.Next(0, categoryIds.Count);
                    product.CategoryProductses.Add(new CategoryProducts { CategoryId = categoryIds[index], ProductId = product.Id });
                }

                context.SaveChanges();
            }
        }

        public static void ImportCategories(string path)
        {
            var stringJson = File.ReadAllText(path);

            var categories = JsonConvert.DeserializeObject<Category[]>(stringJson);

            using (var context = new ProductsShopContext())
            {
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
        }
    }
}
