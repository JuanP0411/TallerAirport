using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class FlightControl
    {public  List<Flight> flightList;
      


        public FlightControl()
        {
            flightList = new List<Flight>();
        }

        public List<Flight> SearchByOrigin(List<Flight> tempList, String destinacion)
        {
         
            List<Flight> nList = new List<Flight>();
           for(int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i].AirOrigin.Equals(destinacion))
                {
                    nList.Add(tempList[i]);
                }
            }
            return nList;
        }


        public List<Flight> SearchByDestination(List<Flight> tempList, String destinacion)
        {
            List<Flight> nList = new List<Flight>();
            for (int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i].AirDestination.Equals(destinacion))
                {
                    nList.Add(tempList[i]);
                }
            }
            return nList;

        }
        public List<Flight> SearchByDuration(List<Flight> tempList, double destinacion)
        {
            List<Flight> nList = new List<Flight>();
            for (int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i].FlightDuration == destinacion)
                {
                    nList.Add(tempList[i]);
                }
            }
            return nList;

        }
        public List<Flight> SearchByDistance(List<Flight> tempList, double destinacion)
        {
            List<Flight> nList = new List<Flight>();
            for (int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i].FlightDistance == destinacion)
                {
                    nList.Add(tempList[i]);
                }
            }
            return nList;

        }

        public List<Flight> SearchByTailNum(List<Flight> tempList, String destinacion)
        {

            List<Flight> nList = new List<Flight>();
            for (int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i].TailNum.Equals(destinacion))
                {
                    nList.Add(tempList[i]);
                }
            }
            return nList;
        }
    }


}
