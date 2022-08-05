using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLayer
{
    public class Costumer
    {
        public Costumer():this(0)
        {

        }
        public Costumer(int costumerID)
        {
            this.CustomerID = costumerID;
            addresses = new List<Address>();
        }

        public List<Address> addresses { get; set; }   
        public int CustomerID { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerType { get; set; }
        
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }  
        }

        public bool validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            return isValid;
        }
    }
}
