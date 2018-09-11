using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagatesExercise
{
    public delegate bool Handler(List<CustomerAddress> listOfCustomerAddresses);

    public class MarketingDepertment
    {
        public bool RunMarketingCampaign(decimal budget)
        {
            bool success = false;
            AddressProvider addressProvider = new AddressProvider();
            Handler campaignHandler; // initialize delegate class

            if (budget > 10000)
            {
                CoffeeCupCompany coffeeCupCompany = new CoffeeCupCompany();
                campaignHandler = coffeeCupCompany.SendCoffeeCups;
            }
            else
            {
                BallpenCompany ballpenCompany = new BallpenCompany();
                campaignHandler = ballpenCompany.SendBallPens;
            }
            success = addressProvider.HandleCampaign(campaignHandler); // wrap the actual method in delegate and let the AddressProvider do the work

            return success;
        }
    }

    public class AddressProvider
    {
        public List<CustomerAddress> GetAddressesOfNewProspects()
        {
            List < CustomerAddress > listOfCustomerAddresses = new List<CustomerAddress>();
            return listOfCustomerAddresses;
        }

        public bool HandleCampaign(Handler campaignHandler)
        {
            bool success = false;
            success = campaignHandler(this.GetAddressesOfNewProspects());
            return success;
        }

        // this is addition I have made to the file during a review    
        // new addition
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
