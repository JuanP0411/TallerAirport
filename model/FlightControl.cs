using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class FlightControl
    {

        public List<Flight> flights
        {
            get
            {
                return flights;
            }

            set
            {
                this.flights = value;
            }
        }
     
        public FlightControl(String dataBasePath)
        {
            flights = ReadDataBase(dataBasePath);
        }

        public List<Flight> SearchByOrigin(String origin)
        {
            List<Flight> nList = new List<Flight>();
           for(int i = 0; i < flights.Count; i++)
            {
                if (flights[i].AirOrigin.Equals(origin))
                {
                    nList.Add(flights[i]);
                }
            }
            return nList;
        }


        public List<Flight> SearchByDestination(String destination)
        {
            List<Flight> nList = new List<Flight>();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].AirDestination.Equals(destination))
                {
                    nList.Add(flights[i]);
                }
            }
            return nList;

        }
        public List<Flight> SearchByDuration(double duration)
        {
            List<Flight> nList = new List<Flight>();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].FlightDuration != " ") {
                    Console.WriteLine(flights[i].FlightDuration);
                    if (Convert.ToDouble(flights[i].FlightDuration) == duration)
                    {
                        nList.Add(flights[i]);
                    }
                }
            }
            return nList;

        }
        public List<Flight> SearchByDistance(double duration)
        {
            List<Flight> nList = new List<Flight>();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].FlightDistance != " ") { 
                    if (Convert.ToDouble(flights[i].FlightDistance) == duration)
                    {
                        nList.Add(flights[i]);
                    }
            }
            }
            return nList;

        }

        public List<Flight> SearchByTailNum(String tailNum)
        {

            List<Flight> nList = new List<Flight>();
            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].TailNum.Equals(tailNum))
                {
                    nList.Add(flights[i]);
                }
            }
            return nList;
        }

        public List<Flight> ReadDataBase(String filename)
        {
            List<Flight> nList = new List<Flight>();
            
            try
            {
                StreamReader sr = new StreamReader(filename);
                String line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {   
                   String[] temp = line.Split(',');
                    Flight tempFlight = new Flight(temp[15].Replace('"',' '), temp[25].Replace('"', ' '), temp[54], temp[56], temp[9]);
                    nList.Add(tempFlight);
                }

            }
            catch (Exception e)
            {

            }
            return nList;
        }

    }

}
