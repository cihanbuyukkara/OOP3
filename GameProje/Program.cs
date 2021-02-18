using System;

namespace GameProje
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "Cihan",
                LastName = "Büyükkara",
                IdentityNumber = 123456789
            });


            
            
            Campaign campaign1 = new Campaign()
            {
                CampaignId = 1,
                CampaignName = "kampanya 1,",
                CampaignCommet = "yüzde 10 indirim",
                CampaignRate = 0.05
            };

            Campaign campaign2 = new Campaign()
            {
                CampaignId = 2,
                CampaignName = "kanpanya 2",
                CampaignCommet = "yüzde 20",
                CampaignRate = 0.10
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);

            Console.WriteLine("---------------");

            MobileSaleManager mobileSaleManager = new MobileSaleManager();
           
        


        }
    }
}
