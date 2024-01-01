
using System.Collections.Generic;
using Catalog;

Console.WriteLine("Hello, World!");
List<Product> products = new List<Product>();

/*int count = 56;
count++;
Console.WriteLine("Count " + count);
Console.WriteLine("Hello, World2!");
*/

Console.WriteLine("Welcome to Transflower Store");
Console.WriteLine("Choose Option:");
Console.WriteLine("1:Show Catalog");
Console.WriteLine("2:Show Product Details");
Console.WriteLine("3:Show Cart");
Console.WriteLine("4:Add to Cart");
Console.WriteLine("5:Remove from Cart");
int option = int.Parse(Console.ReadLine());

switch (option)
{
    case 1:
        {
            Product p1 = new Product();
            p1.Id = 1;
            p1.Title = "Polity";
            p1.UnitPrice = 750;
            p1.Description = "By M Laxmikanth";
            p1.ImagUrl = "polity.png";
            Product p2 = new Product { Id=2,Title="Psychology",Description="By Ciccarelli",
               UnitPrice=1000,ImagUrl="psychology.png"};
            products.Add(p1);
            products.Add(p2);
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
            break;       
        }
}
