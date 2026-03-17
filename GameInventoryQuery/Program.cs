using System;
using System.Collections.Generic;
using System.Linq;


class GameInvetoryQuery
{
    static void Main()
    {
        List<GameItem> items = new List<GameItem>
        {
            new GameItem("나무 검", "무기", "일반", 100, 3),
            new GameItem("강철 대검", "무기", "희귀", 800, 1),
            new GameItem("용의 검", "무기" ,"전설", 5000,1),
            new GameItem("가죽 갑옷", "방어구" ,"일반", 200,2),
            new GameItem("미스릴 갑옷", "방어구" ,"희귀", 1200,1),
            new GameItem("드래곤 갑옷", "방어구" ,"전설", 8000,0),
            new GameItem("체력 물약", "소비" ,"일반", 50,10),
            new GameItem("마나 물약", "소비" ,"일반", 80,5),
            new GameItem("고급 물약", "소비" ,"희귀", 500,0),
            new GameItem("엘릭서", "소비" ,"전설", 3000,2),
        };

        Console.WriteLine("== 쿼리 1: 가격 500이상 (가격 내림차순) ===");
        var query = items
            .Where(n => n.Price > 500)
            .OrderByDescending(n => n.Price);
        foreach(var item in query)
        {
            Console.WriteLine($"{item.Name} - {item.Type} - {item.Price}");
        }

        Console.WriteLine("=== 쿼리 2: 무기 타입(등급순) ===");
        var querywep = items
            .Where(n => n.Type == "무기")
            .OrderBy(n => 
            n.Grade == "일반" ? 1:
            n.Grade == "희귀" ? 2:
            3);
        foreach (var item in querywep)
        {
            Console.WriteLine($"{item.Name}- {item.Grade} - {item.Price}");
        }
        Console.WriteLine("=== 쿼리 3: 총 가치 1000 이상 ===");
        var totalpri = items
            .Where(n => n.Price * n.Quantity > 1000);
        foreach (var item in totalpri)
        {
            Console.WriteLine($"{item.Name}- 총 가치 : {item.Price * item.Quantity}");
        }

        Console.WriteLine("=== 쿼리 4: 품절 아이템 (이름순)===");
        var soldOut = items.Where(n => n.Quantity == 0)
                           .OrderBy(n=>n.Name);
        foreach (var item in soldOut)
        {
            Console.WriteLine($"{item.Name}");
        }
        Console.WriteLine("=== 쿼리 5: 전설 등급(이름과 가격)===");

        var queryLegend = items.Where(n => n.Grade == "전설");

        foreach (var item in queryLegend)
        {
            Console.WriteLine($"{item.Name} - {item.Price}원");
        }



    }
}