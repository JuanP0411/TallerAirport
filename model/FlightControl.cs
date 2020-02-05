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
            get { return flights; }
        }


        public FlightControl() {}

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


       public List<string> popularDestinations()
        {
            //Count destinations. Used Dictionary data structure, in which the destinations' name are the keys and their frecuency is the value.
            Dictionary<string, int> dests = new Dictionary<string, int>();
            foreach(Flight f in flights)
            {
                if (dests.ContainsKey(f.AirDestination))
                {
                    dests[f.AirDestination]++;
                }
                else
                {
                    dests.Add(f.AirDestination, 1);
                }
            }

            //Sort dicitonary by its values. Code snippet taken from https://stackoverflow.com/questions/289/how-do-you-sort-a-dictionary-by-value
            var list = dests.ToList();
            list.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            //Return sorted key list.
            List<string> ret = new List<string>();
            foreach(KeyValuePair<string, int> k in list)
            {
                ret.Add(k.Key);
            }
            return ret;
        }



    }

    

   


}
