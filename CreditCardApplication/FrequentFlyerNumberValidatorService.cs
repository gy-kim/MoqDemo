using System;
namespace CreditCardApplication
{
    public class FrequentFlyerNumberValidatorService : IFrequentFlyerNumberValidator
    {
        public IServiceInformation ServiceInformation 
        {
            get
            {
                throw new NotImplementedException("For demo purposes");
            }
        }

        public ValidationMode ValidationMode
        {
            get => throw new NotImplementedException("For demo purposes");
            set => throw new NotImplementedException("For demo purposes");
        }

        public bool IsValid(string frequentFlyerNumber)
        {
            throw new NotImplementedException("For demo purposes");
        }

        public void IsValid(string frequentFlyerNumber, out bool isValid)
        {
            throw new NotImplementedException("For demo purposes");
        }

        public event EventHandler ValidatorLookupPerformed;
    }
}
