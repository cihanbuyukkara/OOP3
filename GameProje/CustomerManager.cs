using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje
{
    class CustomerManager : ICustomerService
    {
        void ICustomerService.Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi");
        }

        void ICustomerService.Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi");
        }

        void ICustomerService.Update(Customer customer)
        {
            Console.WriteLine("Müşteri güncellendi");
        }

        internal void Delete(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        internal void Add(Gamer gamer1, object gamer2)
        {
            throw new NotImplementedException();
        }

        internal void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        internal void Add(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
