using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje
{
    interface ISaleService
    {
        void Sale(Customer customer);
        void SalesCampaign(Customer customer, Campaign campaign);
    }
}
