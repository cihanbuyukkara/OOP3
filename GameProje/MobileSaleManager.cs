using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje
{
    class MobileSaleManager : ISaleService
    {
        public void Sale(Customer customer)
        {
            Console.WriteLine(" telefondan satın alındı ");
        }

        public void SalesCampaign(Customer customer, Campaign campaign)
        {
            Console.WriteLine(" kampamya ile telefondan satın alındı  ");
        }
    }
}
