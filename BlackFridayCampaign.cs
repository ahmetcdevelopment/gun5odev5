using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject
{
    internal class BlackFridayCampaign : ICampaign
    {
        public void MakeCampaign()
        {
            Console.WriteLine("Tüm oyunculara seçili oyunlara %20 indirim uygulandı.");
        }

        public void MakeCampaign(Gamer gamer)
        {
            Console.WriteLine( gamer.Name+" adlı oyuncuya seçili oyunlara %20 indirim uygulandı.");
        }
    }
}
