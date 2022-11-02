namespace ComparerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new()
            {
                new Product()
                {
                    Description = "Milk",
                    Price = 2.2D,
                    Quantity = 50
                },
                new Product()
                {
                    Description = "Honey",
                    Price = 12.5,
                    Quantity = 30
                },
                new Product()
                {
                    Description = "Eggs",
                    Price = 4.5,
                    Quantity = 50
                },
            };

            products.Sort();
            products.ForEach(p => Console.WriteLine(p));

            Console.WriteLine();

            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            products.ForEach(p => Console.WriteLine(p));

            products.Sort((p1, p2) => p1.Quantity - p2.Quantity);
            products.ForEach(p => Console.WriteLine(p));


            var honeyProducts = from product in products
                                where product.Description!.Equals("Honey")
                                select product;

            foreach (var product in honeyProducts)
            {
                Console.WriteLine(product);
            }


            var sortedProducts = from product in products
                                 orderby product.Quantity
                                 select product;

            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product);
            }

            // method syntax
            var milkProducts = products
                .Where(p => p.Description == "Milk")
                .Select(p => p.Price);
            
            foreach (var product in milkProducts)
            {
                Console.WriteLine(product);
            }

            List<Product> sortedProductList = products
                .OrderBy(p => p.Price)
                .ThenBy(p => p.Quantity)
                .ToList();

            var sum = products
                .Where(p => p.Description == "Milk")
                .Select(p => p.Quantity)
                .Sum();

            var sum2 = (from p in products
                        where p.Description == "Milk"
                        select p.Quantity).Sum();
        }
    }
}