using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDDSimulator
{
    class RequestGenerator
    {

        public int maxDeadline;
        int numberOfRequests;
        int chanceOfRealTimeRequest;
        int driveSize;
        int maxAppearTime;
        int minDeadline;
        List<Request> requests;

        public RequestGenerator(int nRequests, int chanceOfRTR, int driveSize, int maxAppearTime, int maxDeadline, int minDeadline)
        {
            numberOfRequests = nRequests;
            chanceOfRealTimeRequest = chanceOfRTR;
            this.driveSize = driveSize;
            this.maxAppearTime = maxAppearTime;
            this.maxDeadline = maxDeadline;
            this.minDeadline = minDeadline;
            requests = Generate(numberOfRequests, chanceOfRealTimeRequest, driveSize);

        }
        private List<Request> Generate(int n, int chanceOfRealTime, int driveSize)
        {
            Random rand = new Random();
            List<Request> result = new List<Request>();
            List<int> appearTimes = GenerateAppearTimes(5000, n);
            for(int i =0; i < n; i++)
            {
                if (rand.Next(0, 100) < chanceOfRealTime) result.Add(new RealTimeRequest(rand.Next(1, driveSize), appearTimes[i], rand.Next(minDeadline, maxDeadline)));
                else
                {
                    result.Add(new Request(rand.Next(1, driveSize), appearTimes[i]));
                }
            }

            return result;
        }

        public static List<int> GenerateAppearTimes(int maxTime, int n)
        {
            Random rand = new Random();
            List<int> res = new List<int>();
            int first = 1;
                res.Add(first);
            for(int i = 1; i < n; i++)
            {

                res.Add(rand.Next((res[i - 1]), maxTime));
            }
            
            res.Sort();
            return res;
        }

        public List<Request> GetRequests() { return requests; }
        


            


    }
}
