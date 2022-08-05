using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLayer.Repositorys
{
    public class CustomerRepository
    { 
        public CustomerRepository()
        {
            addresRepository = new AddresRepository();
        }
        private AddresRepository addresRepository { get; set; }
        public Costumer Retrive(int customerId)
        {
            Costumer customer = new Costumer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbi.me";
                customer.FirstName = "frodo";
                customer.LastName = "Molina";
                customer.addresses = addresRepository.RetriveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Costumer customer)
        {
            return true;
        }

    }
}
