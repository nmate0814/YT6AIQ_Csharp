using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT6AIQ_Beadando
{
    internal class Item
    {
        //Változók, getter, setter
        public int ID { get; set; }
        public string Name { get; set; }

        //Konstruktor
        public Item(int id, string name)
        {
            ID = id;
            Name = name;
        }

        // Az Equals metódust felüldefiniáljuk, hogy megnézzük van-e egyezőség
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Item other = (Item)obj;
            return ID == other.ID && Name == other.Name;
        }

        // A GetHashCode metódus felüldifiniáláda a hashkód generáláshoz
        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Name);
        }
    }
}
