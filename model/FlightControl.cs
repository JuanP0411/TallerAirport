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
     
      


        public FlightControl()
        {
            
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
                if (tempList[i].FlightDuration != " ") {
                    Console.WriteLine(tempList[i].FlightDuration);
                    if (Convert.ToDouble(tempList[i].FlightDuration) == destinacion)
                    {
                        nList.Add(tempList[i]);
                    }
                }
            }
            return nList;

        }
        public List<Flight> SearchByDistance(List<Flight> tempList, double destinacion)
        {
            List<Flight> nList = new List<Flight>();
            for (int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i].FlightDistance != " ") { 
                    if (Convert.ToDouble(tempList[i].FlightDistance) == destinacion)
                    {
                        nList.Add(tempList[i]);
                    }
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
