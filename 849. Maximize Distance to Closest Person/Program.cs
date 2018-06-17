using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _849.Maximize_Distance_to_Closest_Person
{

    public class Solution
    {
        public int MaxDistToClosest(int[] seats)
        {
            //Case1
            int l1 = 0;
            while (1 != seats[l1]) l1++;
            //Case2
            int r1 = seats.Length-1;
            while (1 != seats[r1]) r1--;
            //Case3
            int maxDistance = 0;
            int tmp0=0;
            for (int i=l1+1;i<=r1;i++)
            {
                if (0==seats[i])
                {
                    tmp0++;
                }
                else
                {
                    int ceilingTmp0 = (int)Math.Ceiling(tmp0 / 2.0);
                    maxDistance = maxDistance > ceilingTmp0 ? maxDistance : ceilingTmp0;
                    tmp0 = 0;
                }
            }
            //MaxDistance
            return Math.Max(Math.Max(l1, (seats.Length - 1) - r1), maxDistance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
