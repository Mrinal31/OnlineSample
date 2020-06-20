using BillingEngine;
using System;

public class Repository : IRepository
{
    public void ActivateMembership()
    {
        throw new NotImplementedException();
    }

    public void CreateDuplicatePackingSlip()
    {
        throw new NotImplementedException();
    }

    public void GeneratePackingSlip()
    {
        throw new NotImplementedException();
    }

    public void LearningToSki()
    {
        throw new NotImplementedException();
    }

    public void UpgradeMembership()
    {
        throw new NotImplementedException();
    }

    public void UpgradeMembershipAndEmail(int userid)
    {
        //retrieve the User Details from a persistent db

        Helper.sendemail("reciepient", "fromAddress", "replyTo", "subject", "mailBody");
    }
}
