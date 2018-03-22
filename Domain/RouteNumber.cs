using System.Collections.Generic;

namespace Domain
{
    public class RouteNumber
    {
        private int hoursOnWeekdays;
        private int numberOfVacationWeeks;
        private int hoursOnWeekends;

        public int HoursOnWeekdays { get { return hoursOnWeekdays; } set { hoursOnWeekdays = value; } }
        public int NumberOfVacationWeeks { get { return numberOfVacationWeeks; } set { numberOfVacationWeeks = value; } }
        public int HoursOnWeekends { get { return hoursOnWeekends; } set { hoursOnWeekends = value; } }
        public int TotalHours { get { return (hoursOnWeekdays + hoursOnWeekends) * (52 - numberOfVacationWeeks); } }

        public List<Offer> offers;

        public int RouteID { get; set; }
        public int RequiredVehicleType { get; set; }
        
        public RouteNumber()
        {
            offers = new List<Offer>(); 
        }
        public RouteNumber(int routeID, int requiredVehicleType) : this()
        {          
            this.RouteID = routeID;
            this.RequiredVehicleType = requiredVehicleType;
        }

        public RouteNumber(int hoursOnWeekdays, int numberOfVacationWeeks, int hoursOnWeekends, int routeID, int requiredVehicleType) : this()
        {
            this.hoursOnWeekends = hoursOnWeekends;
            this.numberOfVacationWeeks = numberOfVacationWeeks;
            this.hoursOnWeekdays = HoursOnWeekdays;
            this.RouteID = routeID;
            this.RequiredVehicleType = requiredVehicleType;
        }
    }
}
