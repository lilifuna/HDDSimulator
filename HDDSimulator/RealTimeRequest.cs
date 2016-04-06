using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDDSimulator
{
    class RealTimeRequest : Request
    {

        int deadline;
    

        public RealTimeRequest(int newLocation, int newAppearTime, int newDeadline)
        {
            location = newLocation;
            appearTime = newAppearTime;
            deadline = newDeadline;
            state = requestState.INVISIBLE;
        }

        public int GetTimeToDeadline(int currentTime)
        {
            return (appearTime + deadline) - currentTime;
        }

        public bool IsRealTime()
        {
            return true;
        }

        public int GetDeadline() { return deadline; }
        
        public Request ToRequest()
        {
            return new Request(location, appearTime);
        }
        
    }
}
