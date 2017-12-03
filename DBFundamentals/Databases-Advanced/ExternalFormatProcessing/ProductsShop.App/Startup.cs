using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProductsShop.Data;
using ProductsShop.Models;
using System.Xml.Linq;

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

            //Import Data from XML
            //var path = "Files/users.xml";
            //ImportUsersFromXml(path);
            //var categoriesPath = "Files/categories.xml";
            //ImportCategoriesFromXml(categoriesPath);
            //var path = "Files/products.xml";
            //ImportProductsFromXml(path);

            // ======= XML ===========//
            //GetProductsInRangeXml();
            //GetSoldProductsXml();
            //GetCategoryByProductCountXml();
            GetUsersAndProductsXml();
        }

        private static void GetUsersAndProductsXml()
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

                var xDocument = new XDocument();
                xDocument.Add(new XElement("users", new XAttribute("count", users.Count())));

                foreach (var user in users)
                {
                    var productsXEls = new List<XElement>();

                    foreach (var soldProduct in user.soldProducts)
                    {
                        productsXEls.Add(new XElement("product", new XAttribute("name", soldProduct.name), new XAttribute("price", soldProduct.price)));
                    }

                    var userAttributes = new List<XAttribute>();

                    if (user.firstName != null)
                    {
                        userAttributes = new List<XAttribute>
                        {
                            new XAttribute("first-name",user.firstName),
                            new XAttribute("last-name", user.lastName)
                        };
                    }

                    if (user.age != null)
                    {
                        var age = int.Parse(user.age.ToString());
                        userAttributes.Add(new XAttribute("age", age));
                    }

                    xDocument.Root.Add(new XElement("user", userAttributes, new XElement("sold-products", new XAttribute("count", user.soldProducts.Count()), productsXEls)));
                }

                var writer = new StreamWriter("usersProducts.xml");

                using (writer)
                {
                    xDocument.Save(writer);
                }
            }

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


        private static void GetCategoryByProductCountXml()
        {
            using (var context = new ProductsShopContext())
            {
                var categories = context
                    .Categories
                    .Include(c => c.CategoryProductses)
                    .ThenInclude(cp => cp.Product)
                    .Select(c => new
                    {
                        name = c.Name,
                        productsCount = c.CategoryProductses.Count,
                        averagePrice = c.CategoryProductses.Average(cp => cp.Product.Price),
                        totalRevenue = c.CategoryProductses.Sum(cp => cp.Product.Price)
                    })
                    .OrderBy(c => c.productsCount);

                var xDocument = new XDocument();
                xDocument.Add(new XElement("categories"));

                foreach (var category in categories)
                {
                    xDocument.Root.Add(new XElement("category",
                        new XAttribute("products-count", category.productsCount),
                        new XElement("average-price", category.averagePrice),
                        new XElement("total-revenue", category.totalRevenue)));
                }

                var writer = new StreamWriter("categories.xml");
                using (writer)
                {
                    xDocument.Save(writer);
                }
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


        private static void GetSoldProductsXml()
        {
            using (var context = new ProductsShopContext())
            {
                var users = context
                    .Users
                    .Where(u => u.SoldProducts.Count > 0)
                    .Include(u => u.SoldProducts)
                    .ThenInclude(p => p.Buyer)
                    .Select(u => new
                    {
                        firstName = u.FirstName,
                        lastName = u.LastName,
                        soldProducts = u.SoldProducts
                            .Select(p => new
                            {
                                name = p.Name,
                                price = p.Price,
                            }).ToList()
                    })
                    .OrderBy(u => u.lastName)
                    .ThenBy(u => u.firstName)
                    .ToList();

                var xDocument = new XDocument();

                xDocument.Add(new XElement("users"));

                foreach (var user in users)
                {
                    var products = new List<XElement>();

                    foreach (var soldProduct in user.soldProducts)
                    {
                        products.Add(new XElement("product", new XAttribute("name", soldProduct.name), new XAttribute("price", soldProduct.price)));
                    }

                    if (user.firstName is null)
                    {
                        xDocument.Root.Add(
                            new XElement("user",
                                new XAttribute("lastName", user.lastName)), new XElement("sold-products", products));
                    }
                    else
                    {
                        xDocument.Root.Add(new XElement("user", new XAttribute("firstName", user.firstName), new XAttribute("lastName", user.lastName)), new XElement("sold-products", products));

                    }
                }

                var writer = new StreamWriter("soldproducts.xml");

                using (writer)
                {
                    xDocument.Save(writer);
                }
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


        private static void GetProductsInRangeXml()
        {
            using (var context = new ProductsShopContext())
            {
                var products = context
                    .Products
                    .Where(p => p.Price >= 1000 && p.Price <= 2000 && p.Buyer != null)
                    .Include(p => p.Buyer)
                    .Select(p => new
                    {
                        name = p.Name,
                        price = p.Price,
                        buier = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                    })
                    .OrderBy(p => p.price)
                    .ToList();

                var xDocument = new XDocument();
                xDocument.Add(new XElement("products"));

                foreach (var product in products)
                {
                    xDocument.Root.Add(new XElement("product", new XAttribute("name", product.name),
                            new XAttribute("price", product.price), new XAttribute("buyer", product.buier)));

                    var writer = new StreamWriter("products.xml");
                    using (writer)
                    {
                        xDocument.Save(writer);
                    }
                }
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


        public static void ImportUsersFromXml(string path)
        {
            var xmlString = File.ReadAllText(path);

            var elements = XDocument.Parse(xmlString).Root.Elements();
            var users = new List<User>();

            foreach (var xElement in elements)
            {
                var firstName = xElement.Attribute("firstName")?.Value;
                var lastName = xElement.Attribute("lastName").Value;

                int? age = null;

                if (xElement.Attribute("age") != null)
                {
                    age = int.Parse(xElement.Attribute("age").Value);
                }

                var user = new User(firstName, lastName, age);
                users.Add(user);
            }

            using (var context = new ProductsShopContext())
            {
                context.Users.AddRange(users);
                context.SaveChanges();
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


        public static void ImportProductsFromXml(string path)
        {
            var stringXml = File.ReadAllText(path);

            var elements = XDocument.Parse(stringXml).Root.Elements();
            var products = new List<Product>();

            foreach (var xElement in elements)
            {
                var currentProduct = new Product
                {
                    Name = xElement.Element("name").Value,
                    Price = decimal.Parse(xElement.Element("price").Value)

                };

                products.Add(currentProduct);
            }

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


        public static void ImportCategoriesFromXml(string path)
        {
            var stringXml = File.ReadAllText(path);

            var elements = XDocument.Parse(stringXml).Root.Elements();
            var categories = new List<Category>();

            foreach (var xElement in elements)
            {
                var category = new Category()
                {
                    Name = xElement.Element("name").Value
                };

                categories.Add(category);
            }

            using (var context = new ProductsShopContext())
            {
                context.Categories.AddRange(categories);
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
