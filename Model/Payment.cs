using System;
using System.Collections.Generic;
using System.Text;

namespace BillingEngine.Model
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public string PaymentType { get; set; }

        public int   PaymentFor { get; set; }
      
    }
}
