using BillingEngine.Model;
using System;

namespace BillingEngine
{
    public class BillingEngineDoStuff
    {
        public void GenerateBill(Payment PaymentModel)
        {
            int type = 0;
            Repository repo = new Repository();
            switch (type)
            {
                case 1: //Physical product

                    repo.GeneratePackingSlip();
                    break;

                case 2://Book

                    break;
                case 3://Membership

                    break;
                case 4://Upgrade membership

                    break;
                case 5://Upgrade and Email owner

                    break;
                case 6://Learning To Ski

                    break;
                case 7://Physical Book

                    break;

                default:
                    break;



            }

        }


    }
}
