using System;
using System.IO;

namespace ShoppingListDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm võimaldab luua kaustajal ise kausta ja faili;
            //seega jätan kasutajale võimaluse neid ise nimetada;
            //kasutaja võiks nimeks määrata: ShoppingList kausta ja seejärel myShoppingList.txt faili; 


            string rootDirectory = @"C:\Users\...\samples1";
            Console.WriteLine("Enter directory name:");

            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();


            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }


        }
    }
}
