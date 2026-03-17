using System;
using System.Collections.Generic;
using System.Linq;

class ProductQuery
{
    static void Main()
    {
        List<Product> items = new List<Product>
        {
            new Product("Laptop","Electronics",1200),
            new Product("Mouse", "Electronics", 25),
            new Product("Keyboard", "Electronics",75),
            new Product("Shirt", "Clothing",50),
            new Product("Pants", "Clothing",100),
            new Product("Desk", "Furniture",250),
            new Product("Chair", "Furniture",150),
            new Product("Monitor", "Electronics",300)

        };

        Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
        var prQuery = items.Where(n => n.Price >= 100);
        foreach(var item in prQuery)
        {
            Console.WriteLine($"{item.Name}");
        }
        Console.WriteLine("=== 문제 2: Electronics 카테고리 ===");

        var elQuery = items.Where(n => n.Category == "Electronics");
        foreach(var item in elQuery)
        {
            Console.WriteLine($"{item.Name}- {item.Category} - {item.Price}원");
        }

        Console.WriteLine("=== 문제 3: 이름순 정렬 ===");
        var nameQuery = items.OrderBy(n => n.Name);
        foreach( var item in nameQuery)
        {
            Console.WriteLine($"{item.Name}");
        }

        Console.WriteLine("=== 문제 4: 평균 가격 ===");

        var avgQuery = items.Average(n => n.Price);

        Console.WriteLine($"{avgQuery}원");

        Console.WriteLine("=== 문제 5: 가장 저렴한 상품 ===");
        int minprice = items.Min(n=> n.Price);
        var minQuery = items.First(n => n.Price == minprice);
        
        Console.WriteLine($"{minQuery.Name} - {minprice}원");

        Console.WriteLine("=== 문제 6: 가장 비싼 상품 ===");
        int maxprice = items.Max(n=> n.Price);
        var maxQuery = items.First(n => n.Price == maxprice);

        Console.WriteLine($"{maxQuery.Name} - {maxprice}원");

        Console.WriteLine("=== 문제 7: Electronics 평균 가격 ===");

        var prElec = items.Where(n => n.Category == "Electronics");
        var avgElec = prElec.Average(n => (double)n.Price);
        Console.WriteLine($"{avgElec}원");

        Console.WriteLine("=== 문제 8: 'o' 포함 상품(대문자) ===");

        var contQuery = items.Where(n => n.Name.Contains("o"));

        foreach(var  item in contQuery)
        {
            Console.WriteLine($"{item.Name.ToUpper()}");
        }

        Console.WriteLine("=== 문제 9: Clothing 역순 ===");

        var reversClQuery = items.Where(n => n.Category == "Clothing")
                                 .OrderByDescending(n => n.Name);

        foreach (var item in reversClQuery)
        {
            Console.WriteLine($"{item.Name}");
        }

        Console.WriteLine("=== 문제 10:가격 50~300, 복합 정렬 ===");

        var sortQuery = items.Where(n => n.Price >= 50 && n.Price <= 300)
                             .OrderBy(n => n.Price);

        foreach (var item in sortQuery)
        {
            Console.WriteLine($"{item.Name} - {item.Price}원");
        }
    }

}