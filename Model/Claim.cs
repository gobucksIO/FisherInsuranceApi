using System;

namespace FisherInsuranceApi.Model{

    public class Claim{
        public int Id;

        public string PolicyNumber;

        public DateTime LossDate;

        public decimal LossAmount;

        public string Status;
    }

}