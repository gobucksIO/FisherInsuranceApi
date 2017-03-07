using System;

    namespace FisherInsuranceApi.Model{
    public class Quote{
    public int Id {get; set;} 

    public string Product {get; set;} 

    public DateTime ExpireDate {get; set;} 

    public decimal Price {get; set;} 

    }
}