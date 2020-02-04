using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Flight
    {
        private String airDestination;
        private String airOrigin;
        private String flightDuration;
        private String flightDistance;
        private String tailNum;

        public Flight(String airporB, String airportD, String flightDuration, String flightDistance, String tailID)
        {
            AirDestination = airportD;
            AirOrigin = airporB;
            FlightDuration = flightDuration;
            FlightDistance = flightDistance;
            TailNum = tailID;
        }
        public String AirDestination
        {
            get
            {
                return this.airDestination;
            }
            set
            {
                this.airDestination = value;
            }
        }

        public String AirOrigin
        {
            get
            {
                return this.airOrigin;
            }
            set
            {
                this.airOrigin = value;
            }
        }

        public String FlightDuration
        {
            get
            {
                return this.flightDuration;
            }
            set
            {
               this.flightDuration = value;
            }
        }
        public String FlightDistance
        {
            get
            {
                return this.flightDistance;
            }
            set
            {
                this.flightDistance = value;
            }
        }
        public String TailNum
        {
            get
            {
                return this.tailNum;
            }
            set
            {
                this.tailNum = value;
            }
        }
    }
}
