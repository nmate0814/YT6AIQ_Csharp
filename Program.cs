using System;
using System.Collections.Generic;

namespace YT6AIQ_Beadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet példányosítása
            HashSet<Item> items = new HashSet<Item>();

            //bevásárló lista feltöltése 20 elemmel
            items.Add(new Item(1, "Alma"));
            items.Add(new Item(2, "Méz"));
            items.Add(new Item(3, "Rizs"));
            items.Add(new Item(4, "Kenyér"));
            items.Add(new Item(5, "Zsemle"));
            items.Add(new Item(6, "Liszt"));
            items.Add(new Item(7, "Cukor"));
            items.Add(new Item(8, "Ecet"));
            items.Add(new Item(9, "Tejföl"));
            items.Add(new Item(10, "Tojás"));
            items.Add(new Item(11, "Tészta"));
            items.Add(new Item(12, "Csirkecomb"));
            items.Add(new Item(13, "Sertéscomb"));
            items.Add(new Item(14, "Darálthús"));
            items.Add(new Item(15, "Csipsz"));
            items.Add(new Item(16, "Lekvár"));
            items.Add(new Item(17, "Kakaó"));
            items.Add(new Item(18, "Kóla"));
            items.Add(new Item(19, "Kávé"));
            items.Add(new Item(20, "Tea"));

            //Ki listázza a bevásárló darabszámát
            Console.WriteLine("Hány tételt tartalmaz a bevásárló lista: " + items.Count);

            //Megnézi hogy van-e már benne kenyér
            Console.WriteLine("Van-e benne kenyér?: " + items.Contains(new Item(4, "Kenyér")));

            //Kiveszi a mézet a bevásárló listából
            Console.WriteLine("Ki vette-e a mézet: " + items.Remove(new Item(2, "Méz")));

            //A méz eltávolítása után megszámolja a bevásárló listán lévő cikkeket
            Console.WriteLine("A méz eltávolítása után: " + items.Count + "db\n");
            
            //Bevásárló lista kiírása
            Console.WriteLine("Bevásárló lista:");
            foreach (var item in items)
            {
                Console.WriteLine("ID: " + item.ID + ", Name: " + item.Name);
            }

            //Egy példa string, amin műveletet/formázást végzünk
            string exampleString = "Ez egy bevásárló lista!";

            //Megmutatja a szöveget
            Console.WriteLine("\nEredeti szöveg: " + exampleString);
            
            //Kiírja a szöveget nagybetűkkel
            Console.WriteLine("Nagybetűvel: " + exampleString.ToUpper());

            //Kiírja a szöveg hosszát
            Console.WriteLine("Hossza: " + exampleString.Length + " karakter");

            //Szöveg egy részletének kiírása (3. karaktertől 13 karakterig)
            Console.WriteLine("Szövegrészlet: " + exampleString.Substring(3, 13) + " (3. tól a 13.-ig karakterig)");
        }
    }
}
