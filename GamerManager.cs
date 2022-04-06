using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject
{
    internal class GamerManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu "+gamer.Name+ " başarıyla kaydoldu.");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu başarıyla silindi.");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu başarıyla güncellendi.");
        }
        public List<Gamer> GetAll()
        {
            List<Gamer> list = new List<Gamer>();
            foreach (var gamer in list)
            {
                Console.WriteLine(gamer.Name + gamer.LastName);
            }
            return list; //normalde veritabanından çekilen bilgi list<Gamer> olarak döner ve datagride bağlanır.
        }
    }
}
