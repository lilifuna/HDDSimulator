using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDDSimulator
{
    class Request
    {
        public  enum requestState
        {
            INVISIBLE,
            QUEUED,
            PROCESSING,
            FINISHED
            
        };

        protected int location;
        
        protected int appearTime;
        protected requestState state;

        public Request(int newLocation, int newAppearTime)
        {
            location = newLocation;
            appearTime = newAppearTime;
            state = requestState.INVISIBLE;

        }

        public Request() { }

        public requestState CheckRequestState(){ return state; }
        public void SetRequestState(requestState newState) { state = newState; }
        public int GetAppearTime() { return appearTime; }
        public int GetPosition() { return location; }

        public bool IsRealTime() { return false; }

        
    }
}
