namespace Domain
{
    public class Offer
    {
        public string OfferReferenceNumber { get; set; }
        public float OperationPrice { get; set; }
        public bool IsEligible { get; set; }     
        public int RequiredVehicleType { get; set; }
        public int RouteID { get; set; }
        public string UserID { get; set; }
        public float DifferenceToNextOffer { get; set; }
        public string CreateRouteNumberPriority { get; set; }
        public string CreateContractorPriority { get; set; }
        public int RouteNumberPriority { get; set; }
        public int ContractorPriority { get; set; }
        public Contractor Contractor {get;set;}
        public float TotalYearlyPrice { get; set; }

        public Offer() { }    

        public Offer(string referenceNumber, float operationPrice, int routeID, string userID, int routeNumberPriority, int contractorPriority, Contractor contractor, int requiredVehicleType = 0)
        {
            OfferReferenceNumber = referenceNumber;
            OperationPrice = operationPrice;
            RouteID = routeID;
            UserID = userID;
            RouteNumberPriority = routeNumberPriority;
            ContractorPriority = contractorPriority;
            Contractor = contractor;
            RequiredVehicleType = requiredVehicleType;
            IsEligible = true;            
        }
    }
}
