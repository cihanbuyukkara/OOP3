using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool Check(Customer customer)
        {
            return true;
        }
    }
}
