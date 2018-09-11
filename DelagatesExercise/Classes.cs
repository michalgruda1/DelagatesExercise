using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExercise
{
    // public delegate bool SendGifts(List<CustomerAddress>);

    public class MarketingDepertment
    {
        public bool RunMarketingCampaign(decimal budget)
        {
            // SendGifts CampaignHandler;
            bool success = false;
            AddressProvider addressProvider = new AddressProvider();
            List<CustomerAddress> customerAddresses = addressProvider.GetAddressesOfNewProspects();
            if (budget > 10000)
            {
                CoffeeCupCompany someCoffeeCupCompany = new CoffeeCupCompany(); 
                success = someCoffeeCupCompany.SendCoffeeCups(customerAddresses);
                return success;
            }
            else
            {
                BallpenCompany someBallpenCompany = new BallpenCompany();
                success = someBallpenCompany.SendBallPens(customerAddresses);
                return success;
            }
        }
    }

    public class AddressProvider
    {
        public List<CustomerAddress> GetAddressesOfNewProspects()
        {
            List < CustomerAddress > listOfCustomerAddresses = new List<CustomerAddress>();
            return listOfCustomerAddresses;
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
