using System;

namespace GameSalesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(new Gamer { Name="Ahmet",LastName="Çiftçi"});
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);
            gamerManager.GetAll();

            ICampaign BFCcampaign = new BlackFridayCampaign();
            BFCcampaign.MakeCampaign(gamer);//seçili oyunculara
            BFCcampaign.MakeCampaign();//tüm oyunculara

            ICampaign Ccampaign = new ChristmasCampaign();
            Ccampaign.MakeCampaign(gamer);//seçili oyunculara
            Ccampaign.MakeCampaign();//Tüm oyunculara

            //yeni kampanya eklemek için bir class açacağız ve ICampaign interfacesinden implemente edeceğiz.
            
        }
    }
}
