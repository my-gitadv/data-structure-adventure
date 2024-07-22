using System;

public class Program
{
    static void Main(string[] args)
    {

        
        //Node nodeA = new Node();
        //Node nodeB = new Node();

        //nodeA.price = 30; nodeA.timestamp = 1; nodeA.isMinHeap = true;
        //nodeB.price = 20; nodeB.timestamp = 2; nodeB.isMinHeap = true;
        //Console.WriteLine("nodeA.compare(nodeB) = " + nodeA.compare(nodeB));
        //Console.WriteLine("nodeB.compare(nodeA) = " + nodeB.compare(nodeA));
        

        
        //Node nodeA = new Node();
        //Node nodeB = new Node();

        //nodeA.price = 30; nodeA.timestamp = 1; nodeA.isMinHeap = false;
        //nodeB.price = 20; nodeB.timestamp = 2; nodeB.isMinHeap = false;

        //Console.WriteLine("nodeA.compare(nodeB) = " + nodeA.compare(nodeB));
        //Console.WriteLine("nodeB.compare(nodeA) = " + nodeB.compare(nodeA));
        

        
        //Node nodeA = new Node();
        //Node nodeB = new Node();

        //nodeA.price = 100; nodeA.timestamp = 1; nodeA.isMinHeap = true;
        //nodeB.price = 100; nodeB.timestamp = 2; nodeB.isMinHeap = true;

        //Console.WriteLine("nodeA.compare(nodeB) = " + nodeA.compare(nodeB));
        //Console.WriteLine("nodeB.compare(nodeA) = " + nodeB.compare(nodeA));
        

        
        StockMarket market = new StockMarket(10, 10); // 10 investos, 10 stocks
        // Add 10 investors and the initial balance
        market.addInvestor("Matthew", 10000); // ID=0
        market.addInvestor("Mark", 10000); // ID=1
        market.addInvestor("Luke", 10000); // ID=2
        market.addInvestor("John", 9000); // ID=3
        market.addInvestor("James", 9000); // ID=4
        market.addInvestor("Peter", 9000); // ID=5
        market.addInvestor("Jude", 8000); // ID=6
        market.addInvestor("Paul", 8000); // ID=7
        market.addInvestor("Timothy", 8000); // ID=8
        market.addInvestor("Titus", 8000); // ID=9
        // Add 10 stocks and the initial price
        market.addStock("PTT", 344);
        market.addStock("CPALL", 60.5);
        market.addStock("SCB", 144);
        market.addStock("KBANK", 170);
        market.addStock("CPF", 27.75);
        market.addStock("TRUE", 7.15);
        market.addStock("CPN", 53);
        market.addStock("BTS", 8.35);
        market.addStock("DTAC", 35.50);
        market.addStock("LH", 8.75);

        //market.giveMeSomeShares();
        market.loadAssets(); // load saved assets
        market.showStockOwnership();

        market.portfolio("Mark");
        market.portfolio("Matthew");


        // To uncomment below, you need to implement Heap


        market.submitSellOrder("Luke", "SCB", 5, 200);
        market.submitSellOrder("Jude", "SCB", 10, 180);
        market.quote("SCB");

        market.submitBuyOrder("John", "SCB", 6, 250);
        market.submitBuyOrder("James", "SCB", 6, 250);

        market.portfolio("John");
        market.portfolio("James");
        market.portfolio("Luke");
        market.portfolio("Jude");

        market.quote("KBANK");

        market.submitBuyOrder("Peter", "KBANK", 2, 90);
        market.quote("KBANK");

        market.submitBuyOrder("Jude", "KBANK", 1, 85);
        market.quote("KBANK");
        market.submitBuyOrder("Paul", "KBANK", 3, 90);
        market.quote("KBANK");
        market.submitBuyOrder("Timothy", "KBANK", 2, 100);
        market.quote("KBANK");
        market.submitBuyOrder("Titus", "KBANK", 2, 80);
        market.quote("KBANK");


        market.submitSellOrder("John", "KBANK", 2, 150);
        market.quote("KBANK");

        market.portfolio("John");
        market.submitSellOrder("John", "KBANK", 6, 85);

        market.portfolio("John");


        market.showStockOwnership();

        market.submitSellOrder("Matthew", "PTT", 3, 350);
        market.submitSellOrder("Matthew", "PTT", 3, 360);
        market.submitSellOrder("Matthew", "PTT", 4, 370);
        market.submitSellOrder("Luke", "PTT", 5, 355);
        market.submitSellOrder("Luke", "PTT", 5, 365);
        market.submitSellOrder("Luke", "PTT", 5, 375);
        market.submitSellOrder("James", "PTT", 3, 360);
        market.submitSellOrder("James", "PTT", 3, 370);
        market.submitSellOrder("James", "PTT", 4, 380);

        market.submitBuyOrder("Mark", "PTT", 6, 370);
        market.submitBuyOrder("John", "PTT", 6, 370);
        market.submitBuyOrder("Peter", "PTT", 10, 370);
        market.submitBuyOrder("Jude", "PTT", 10, 370);

        market.submitBuyOrder("Paul", "PTT", 2, 330);
        market.submitBuyOrder("Paul", "PTT", 2, 300);
        market.submitBuyOrder("Paul", "PTT", 2, 270);

        market.submitBuyOrder("Timothy", "PTT", 3, 330);
        market.submitBuyOrder("Timothy", "PTT", 3, 250);
        market.submitBuyOrder("Timothy", "PTT", 3, 200);

        market.submitSellOrder("Titus", "PTT", 3, 320);
        market.submitSellOrder("Titus", "PTT", 3, 240);
        market.submitSellOrder("Titus", "PTT", 4, 220);
        market.submitSellOrder("Mark", "PTT", 3, 320);
        market.submitSellOrder("Mark", "PTT", 3, 240);
        market.submitSellOrder("Mark", "PTT", 4, 220);

        market.quote("PTT");

        market.showStockOwnership();

        market.portfolio("Mark");

        market.submitBuyOrder("Matthew", "PTT", 20, 150);
        market.submitBuyOrder("Matthew", "PTT", 20, 100);
        market.submitBuyOrder("Matthew", "PTT", 10, 50);

        market.submitSellOrder("Peter", "PTT", 10, 125);
        market.submitSellOrder("Jude", "PTT", 10, 75);
        market.submitSellOrder("Paul", "PTT", 15, 75);
        market.submitSellOrder("Timothy", "PTT", 15, 75);

        market.quote("PTT");

        market.portfolio("Mark");

    }
}