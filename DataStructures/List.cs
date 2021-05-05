using System.Collections.Generic;

namespace DataStructures
{
    class List
    {
        public List()
        {
            List<string> Ids = new List<string>();
            Ids.Add("Sunwarul");
            Ids.Add("Rashed");
            Ids.Add("Pulok");
            Ids.Add("Sujohn");

            foreach (string Id in Ids)
            {
                System.Console.WriteLine(Id);
            }
        }
    }
}
