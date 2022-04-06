using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject
{
    internal class ChristmasCampaign : ICampaign
    {
        public void MakeCampaign()
        {
            Console.WriteLine("Tüm oyunculara oyunlarda %30 indirim uygulandı!");
        }

        public void MakeCampaign(Gamer gamer)
        {
            Console.WriteLine(gamer.Name+" adlı oyuncuya tüm oyunlarda %30 indirim uygulandı!");
        }
    }
}
