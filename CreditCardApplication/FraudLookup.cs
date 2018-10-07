using System;
namespace CreditCardApplication
{
    public class FraudLookup
    {
        //public virtual bool IsFraudRisk(CreditCardApplication application)
        //{
        //    if (application.LastName == "Smith")
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        public bool IsFraudRisk(CreditCardApplication application)
        {
            return CheckApplication(application);
        }

        protected virtual bool CheckApplication(CreditCardApplication application)
        {
            if (application.LastName == "Smith")
            {
                return true;
            }

            return false;
        }
    }
}
