using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExercise
{
    public delegate bool SendCoffeeCups(List<CustomerAddress> customerAddresses);
    public delegate bool SendBallpens(List<CustomerAddress> customerAddresses);

    public class MarketingDepertment
    {
        public bool RunMarketingCampaign(decimal budget)
        {
            bool success = false;
            AddressProvider AddressProvider = new AddressProvider();
            List<CustomerAddress> listOfCustomersAddresses = AddressProvider.GetAddressesOfNewProspects();

            // Handler campaignHandler; // initialize delegate class

            if (budget > 10000)
            {
                success = AddressProvider.MySendCoffeeCups(listOfCustomersAddresses);
            }
            else
            {
                success = AddressProvider.MySendBallpens(listOfCustomersAddresses);
            }
            return success;
        }
    }

    public class AddressProvider
    {
        private CoffeeCupCompany CoffeeCupCompany;
        private BallpenCompany BallpenCompany;

        // initiate delegates
        public SendBallpens MySendBallpens;
        public SendCoffeeCups MySendCoffeeCups;

        public List<CustomerAddress> GetAddressesOfNewProspects()
        {
            List < CustomerAddress > listOfCustomerAddresses = new List<CustomerAddress>();
            return listOfCustomerAddresses;
        }

        public AddressProvider()
        {
            CoffeeCupCompany = new CoffeeCupCompany();
            BallpenCompany = new BallpenCompany();
            // wrap handling in delagates
            MySendBallpens = BallpenCompany.SendBallPens;
            MySendCoffeeCups = CoffeeCupCompany.SendCoffeeCups;
        }
    }

    public class BallpenCompany
    {
        public bool SendBallPens(List<CustomerAddress> listOfCustomerAddresses)
        {
            // for each address send ballpen
            return true;
        }
    }

    public class CoffeeCupCompany
    {
        public bool SendCoffeeCups(List<CustomerAddress> listOfCustomerAddresses)
        {
            // for each address send coffee cup
            return true;
        }
    }

    public class CustomerAddress
    {
        // nothing now
    }
}
