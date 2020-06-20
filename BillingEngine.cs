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
                    repo.CreateDuplicatePackingSlip();
                    break;
                case 3://Membership
                    repo.ActivateMembership();
                    break;
                case 4://Upgrade membership
                    repo.UpgradeMembership();
                    break;
                case 5://Upgrade and Email owner
                    repo.UpgradeMembershipAndEmail(PaymentModel.UserId);
                    break;
                case 6://Learning To Ski
                    repo.LearningToSki();
                    break;
                case 7://Physical Book

                    break;

                default:
                    break;



            }

        }


    }
}
