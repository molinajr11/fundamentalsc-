using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLayer.Repositorys
{
    public class AddresRepository
    {
        public Address Retrive(int addressId)
        {
            Address address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Santa Ana";
                address.StreetLine2 = "Serramonte";
                address.City = "Medellin";
                address.State = "Antioquia";
                address.Country = "Colombia";
                address.PostalCode = "50000";
            }
            return address;

        }
        public IEnumerable<Address>RetriveByCustomerId(int customerId)
        {
            var addressList=new List<Address>();
            Address address = new Address(1);
            {
                address.AddressType = 1;
                address.StreetLine1 = "Santa Ana";
                address.StreetLine2 = "Serramonte";
                address.City = "Medellin";
                address.State = "Antioquia";
                address.Country = "Colombia";
                address.PostalCode = "50000";

            };
            addressList.Add(address);

            address= new Address(2);
            {
                address.AddressType = 2;
                address.StreetLine1 = "Aranjuez";
                address.StreetLine2 = "piñuela";
                address.City = "Medellin";
                address.State = "Antioquia";
                address.Country = "Colombia";
                address.PostalCode = "00501";
            };
            addressList.Add(address);
            return addressList;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
