using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Joro_The_Rabbit
{
    class Program
    {
        private static List<short> FindIndex(short[] terrainDigits)
        {
            List<short> indexOfBeginning = new List<short>(2);
            indexOfBeginning.Add(terrainDigits.Min());
            for (short place = 0; place < terrainDigits.Length; place++)
            {
                if (indexOfBeginning[0] == terrainDigits[place])
                {
                    indexOfBeginning.Add(place);
                }
            }
            return indexOfBeginning;
        }

        static void Main(string[] args)
        {
            string terrain = Console.ReadLine();
            char separator = ',';
            string[] terrainArray = terrain.Split(separator);
            short[] terrainDigits = new short[terrainArray.Length];
            for (int index = 0; index < terrainArray.Length; index++)
            {
                terrainDigits[index] = short.Parse(terrainArray[index]);
            }
            //short beginnig = terrainDigits.Min();
            List<short> indexOfBeginning = FindIndex(terrainDigits);
            int count = 1;
            int maxCount = 0;
            short after;
            for (int scenario = 1; scenario < indexOfBeginning.Count; scenario++)
            {
                short before = indexOfBeginning[scenario];
                //for (short step = 1; step < terrainDigits.Length; step++)
                //{
                short step = 1;
                    if ((before + step) >= terrainDigits.Length)
                    {
		                before = (short)((-before)-1);
                    }
                    if (terrainDigits[before] < terrainDigits[before + step])
                    {
                        count++;
                        before = (short)(before + step);
                    }
                    if (terrainDigits[indexOfBeginning[scenario]] >= terrainDigits[indexOfBeginning[scenario] + step])
                    {
                        if (maxCount < count)
                        {
                            maxCount = count;
                        }
                        count = 1;
                        break;
                    }
                    
                //}
            }
            Console.WriteLine(maxCount);
        }
    }
}
