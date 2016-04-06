using HDDSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDDSimulator
{
     class Simulator
    {

        List<Request> allRequests;
       
        simulationMode currentMode;
        Request currentRequest;
        RequestGenerator generator;

        int totalNuberOfRequests;
        int driveSize;
        public static int finishedCount = 0;
        public int missedDeadline = 0;

        public enum simulationMode {
            FCFS,
            SSTF,
            SCAN,
            CSCAN,
            EDF,
            FDSCAN
        };

        private enum scanDirection
        {
            FORWARD,
            BACKWARD
        };

        public enum RTRServiceModes
        {
            FDSCAN,
            EDF
        };
        Drive drive;
      

        RTRServiceModes RTRmode;
        /*
        static void Main(string[] args)
        {

           // RequestGenerator generator = new RequestGenerator(100, 30, 500, 1500, 1000, 400);
            FileHandler handler = new FileHandler();
            // handler.WriteFile(generator.GetRequests(), "test1");

            Simulator simulation = new Simulator(new Drive(500), handler.ReadFile("test1"),simulationMode.FCFS, RTRServiceModes.EDF);
            simulation.Simulate();
          
           Console.WriteLine(simulation.drive.GetTotalMovement());
            
          
        }
        */
        

        public Simulator(Drive newDrive, RequestGenerator generator, simulationMode simMode, RTRServiceModes newRTRMode)
        {

            currentMode = simMode;
            RTRmode = newRTRMode;
            drive = newDrive;
            driveSize = drive.GetSize();
            currentRequest = null;
            this.generator = generator;
            allRequests = generator.GetRequests();
            totalNuberOfRequests = allRequests.Count;
        }

        public Simulator(Drive newDrive, List<Request> inputRequests, simulationMode simMode, RTRServiceModes newRTRMode)
        {

            currentMode = simMode;
            RTRmode = newRTRMode;
            drive = newDrive;
            driveSize = drive.GetSize();
            currentRequest = null;
            allRequests = inputRequests;
            totalNuberOfRequests = allRequests.Count();
            
        }

        public  void Simulate()
        {
            int time = 0;
            scanDirection direction = scanDirection.FORWARD;
            Request movingTowards = null;
            simulationMode previousMode = currentMode;
            

            
            while (!CheckIfSimulationFinished())
            {
                UpdateQueue(time);
                List<RealTimeRequest> realTimeRequests = FindRealtimeRequests(time);

                if (realTimeRequests.Count > 0)
                {
                    switch (RTRmode)
                    {
                        case RTRServiceModes.FDSCAN:

                            currentMode = simulationMode.FDSCAN;
                            break;

                        case RTRServiceModes.EDF:
                            currentMode = simulationMode.EDF;
                            break;
                    }
                } // Change mode to EDF/FDSCAN if there are any RTR's in the queue.
                else currentMode = previousMode; //Go back to previous mode after serving all RTR

                switch (currentMode)
                {
                    case simulationMode.FCFS:
                        DoFCFS();

                        break;

                    case simulationMode.SSTF:
                        DoSSTF();
                    break;


                    case simulationMode.CSCAN:

                        DoCSCAN(ref direction);
                    break;


                    case simulationMode.SCAN:
                        DoSCAN(ref direction);

                        break;

                    case simulationMode.EDF:
                        DoEDF(time, realTimeRequests);


                    break;


        
                    case simulationMode.FDSCAN:

                        DoFDSCAN(ref direction, ref movingTowards, realTimeRequests, time);
                        break;

                    

                }

                time++;
            }
        }
        private void DoFDSCAN(ref scanDirection direction, ref Request movingTowards, List<RealTimeRequest> RealTimeRequests, int time)
        {
            List<RealTimeRequest> requestsPossible = FindRequestsThatCanBeServed(RealTimeRequests, time);

            if (CheckFDSCANDirection(requestsPossible, time, direction) && movingTowards == null)
            {
                if (direction == scanDirection.FORWARD) direction = scanDirection.BACKWARD;
                else direction = scanDirection.FORWARD;
                movingTowards = requestsPossible.First(); // So that it does not check for new Requests when the head is moving towards the chosen request
                

            }
            Scan(direction);
            foreach (Request req in allRequests)
            {
                if (req.CheckRequestState() == Request.requestState.QUEUED )
                {
                    if (req.GetPosition() == drive.GetPosition())
                    {
                        
                        if (req.Equals(movingTowards)) movingTowards = null;
                        FinishRequest(req);
                    }

                }
            }
        }
        private void DoEDF(int time, List<RealTimeRequest> realTimeRequests)
        {
            if (currentRequest != null)
            {
                MoveHeadTowardsPosition(currentRequest.GetPosition());

                if (CheckIfHeadOverRequest(currentRequest))
                {
                    FinishRequest(currentRequest);
                }
            }
            else if(FindShortestDeadlineRequest(time, realTimeRequests) != null)
            {
                currentRequest = FindShortestDeadlineRequest(time, realTimeRequests);
                //if (currentRequest != -1) allRequests[currentRequest].SetRequestState(Request.requestState.PROCESSING);
            }
        }

        private void DoSCAN(ref scanDirection direction)
        {
            Scan(direction);
            if (!CheckForFartherRequests(direction))
            {
                if (direction == scanDirection.FORWARD) direction = scanDirection.BACKWARD;
                else direction = scanDirection.FORWARD;
            }

            foreach (Request req in allRequests)
            {
                if (req.CheckRequestState() == Request.requestState.QUEUED)
                {
                    if (CheckIfHeadOverRequest(req))
                    {
                        FinishRequest(req);
                        //Console.WriteLine("Process " + allRequests.IndexOf(req) + "finished");
                    }

                }
            }
        }
        private void DoCSCAN(ref scanDirection direction)
        {
            if (drive.GetPosition() == drive.GetSize()) direction = scanDirection.BACKWARD;
            if (drive.GetPosition() <= 0) direction = scanDirection.FORWARD;

            Scan(direction);


            foreach (Request req in allRequests)
            {
                if (req.CheckRequestState() == Request.requestState.QUEUED)
                {
                    if (CheckIfHeadOverRequest(req))
                    {
                        FinishRequest(req);
                    }
                    
                }
            }



        }
        private void DoFCFS()
        {
            if (currentRequest != null)
            {
                MoveHeadTowardsPosition(currentRequest.GetPosition());

                if (CheckIfHeadOverRequest(currentRequest))
                {
                    FinishRequest(currentRequest);
                }
            }
            else
            {
                currentRequest = FindFirstRequest();
                //if (currentRequest != -1) allRequests[currentRequest].SetRequestState(Request.requestState.PROCESSING);
            }
        }

        private void DoSSTF()
        {
            if (currentRequest != null)
            {
                MoveHeadTowardsPosition(currentRequest.GetPosition());
                
                if (CheckIfHeadOverRequest(currentRequest))
                {
                    FinishRequest(currentRequest);
                }
            }
            else
            {
                currentRequest = FindShortestRequest();
                //if (currentRequest != null) currentRequest.SetRequestState(Request.requestState.PROCESSING);
            }
        }
        public RealTimeRequest FindShortestDeadlineRequest(int currentTime, List<RealTimeRequest> realTimeRequests)
        {

            if (FindRequestsThatCanBeServed(realTimeRequests,currentTime).Count() != 0)
            {
                RealTimeRequest shortestDeadlineRequest = FindRequestsThatCanBeServed(realTimeRequests,currentTime).First();
                int shortest = Int32.MaxValue;
                foreach (RealTimeRequest req in realTimeRequests)
                {
                    if ((req.GetTimeToDeadline(currentTime) < shortest) && (req.CheckRequestState() == Request.requestState.QUEUED))
                    {
                        
                            shortestDeadlineRequest = req;
                            shortest = req.GetTimeToDeadline(currentTime);
                        
                    }
                }

                return shortestDeadlineRequest;
            }
            else return null;
        }

        private bool CheckIfHeadOverRequest(Request req)
        {
            if (req.GetPosition() == drive.GetPosition()) return true;
            return false;
        }
        private List<RealTimeRequest> FindRequestsThatCanBeServed(List<RealTimeRequest> requests,int currentTime)
        {
            List<RealTimeRequest> realTimeRequestsThatCanBeServed = new List<RealTimeRequest>();
            
                foreach (RealTimeRequest req in requests)
                {

                    if (req.CheckRequestState() == Request.requestState.QUEUED)
                    {
                        if (drive.CalculateDistanceFromPoint(req.GetPosition()) < req.GetTimeToDeadline(currentTime))
                        {
                            realTimeRequestsThatCanBeServed.Add(req);
                        }
                    }
                }

            if (realTimeRequestsThatCanBeServed.Count != 0)
            {
                int lowestIndex = requests.Count();
                RealTimeRequest shortestDeadlineRequest = realTimeRequestsThatCanBeServed.First();
                foreach (RealTimeRequest req in realTimeRequestsThatCanBeServed) //dumbest sorting EVUR xDDDD
                {
                    if (allRequests.IndexOf(req) < lowestIndex)
                    {
                        lowestIndex = allRequests.IndexOf(req);
                        shortestDeadlineRequest = req;
                    }


                }
                realTimeRequestsThatCanBeServed.Remove(shortestDeadlineRequest);
                realTimeRequestsThatCanBeServed.Insert(0, shortestDeadlineRequest);
            }

            return realTimeRequestsThatCanBeServed;
        }
        
        private bool CheckFDSCANDirection(List<RealTimeRequest> realTimeRequests, int currentTime, scanDirection currentDirection)
        {

            List<RealTimeRequest> realTimeRequestsThatCanBeServed = FindRequestsThatCanBeServed(realTimeRequests, currentTime);

            try {
                RealTimeRequest requestToBeServed = realTimeRequestsThatCanBeServed.First();

                if (currentDirection == scanDirection.FORWARD)
                {
                    if (requestToBeServed.GetPosition() > drive.GetPosition()) return false;
                    else return true;
                }
                else if (currentDirection == scanDirection.BACKWARD)
                {
                    if (requestToBeServed.GetPosition() > drive.GetPosition()) return true;
                    return false;
                }
                else return false;
            }
            catch(NullReferenceException exception)
            {
                return false;
            }
          
        }
        private List<int> CheckForRealTimeRequests()
        {
            List<int> result = new List<int>();
            foreach (Request req in allRequests)
            {
                if(req.CheckRequestState() == Request.requestState.QUEUED)
                {
                    if(req.GetType() == typeof(RealTimeRequest));
                    {
                        result.Add(allRequests.IndexOf(req));
                    }
                }
            }

            return result;
        }

        private List<RealTimeRequest> FindRealtimeRequests(int currentTime)
        {
            List<RealTimeRequest> result = new List<RealTimeRequest>();
            List<RealTimeRequest> missed = new List<RealTimeRequest>();
            foreach(Request req in allRequests)
            {
                if (req.GetType() == typeof(RealTimeRequest) && req.CheckRequestState() == Request.requestState.QUEUED)
                {
                    RealTimeRequest temp = (RealTimeRequest)req;
                    if (temp.GetTimeToDeadline(currentTime) >= 0)
                    {
                        result.Add((RealTimeRequest)req);
                    }
                    else
                    {
                        missed.Add((RealTimeRequest)req);
                    }
                }
            }
            foreach(RealTimeRequest req in missed)
            {
                missedDeadline++;
                allRequests.Remove(req);
                allRequests.Add(req.ToRequest());
            }
            return result;
        }

        private bool CheckForFartherRequests(scanDirection direction)
        {
            if(direction == scanDirection.FORWARD)
            {
                foreach(Request req in allRequests)
                {
                    if (req.GetPosition() > drive.GetPosition()) return true;
                }     
            }

            if (direction == scanDirection.BACKWARD)
            {
                foreach (Request req in allRequests)
                {     
                    if (req.GetPosition() < drive.GetPosition()) return true;
                }
            }

            return false;
        }
        private void Scan(scanDirection direction)
        {

            

            if (direction == scanDirection.BACKWARD)
            {
                drive.MoveHeadBack();

            }
            else
            {
                drive.MoveHeadForward();

            }
        }

        private Request FindFirstRequest()
        {
            foreach (Request req in allRequests)
            {

                if (req.CheckRequestState() == Request.requestState.QUEUED)
                {
                    return req;
                    
                }
            }

            return null;
        }

        private Request FindShortestRequest()
        {
            int shortestDistance = drive.GetSize();
            int index = 0;

            foreach(Request req in allRequests)
            {
                if (req.CheckRequestState() == Request.requestState.QUEUED)
                {
                    if (drive.CalculateDistanceFromPoint(req.GetPosition()) < shortestDistance)
                    {
                        shortestDistance = drive.CalculateDistanceFromPoint(req.GetPosition());
                        index = allRequests.IndexOf(req);
                    }
                }
            }
            return allRequests[index];
        }
        
        private void FinishRequest(Request req)
        {
            req.SetRequestState(Request.requestState.FINISHED);
            currentRequest = null;
            finishedCount++;
        }
        private void MoveHeadTowardsPosition(int position)
        {
            if (position > drive.GetPosition())
            {
                drive.MoveHeadForward();
                
            }
            else if (position < drive.GetPosition())
            {
                drive.MoveHeadBack();
                
            }
           
        }
        private void UpdateQueue(int currentTime)
        {
            foreach(Request req in allRequests)
            {
                if(currentTime >= req.GetAppearTime() && (req.CheckRequestState() == Request.requestState.INVISIBLE))
                {
                    req.SetRequestState(Request.requestState.QUEUED);
                }
            }
        }
        private bool CheckIfSimulationFinished()
        {
            foreach(Request req in allRequests)
            {
                if (req.CheckRequestState() != Request.requestState.FINISHED) return false;
            }

            return true;
        }

        private void CheckForRequestsPastDeadline(int currentTime)
        {
            foreach(RealTimeRequest req in FindRealtimeRequests(currentTime))
            {
                if(req.CheckRequestState() == Request.requestState.QUEUED)
                {
                    if(req.GetTimeToDeadline(currentTime) <= 0)
                    {
                        missedDeadline++;
                        allRequests.Remove(req);
                        allRequests.Add(req as Request);
                    }
                }
            }
        }

        public void SetSimulationMode(simulationMode newMode) { currentMode = newMode; }
        public void SetRTRServiceMode(RTRServiceModes newMode) { RTRmode = newMode; }

        public List<Request> GetAllRequests() { return allRequests; }

        public String GetModeName(bool RTR)
        {
            String mode = "";

            switch (currentMode)
            {
                case simulationMode.FCFS:
                    mode = "FCFS";
                    break;

                case simulationMode.SSTF:
                    mode = "SSTF";
                    break;

                case simulationMode.SCAN:
                    mode = "SCAN";
                    break;

                case simulationMode.CSCAN:
                    mode = "CSCAN";
                    break;


            }

            if (RTR)
            {
                switch (RTRmode)
                {
                    case RTRServiceModes.FDSCAN:
                        mode += "/FDSCAN";
                        break;

                    case RTRServiceModes.EDF:
                        mode += "/EDF";
                        break;

                }
            }
            return mode;
        }

        public static int GetRealTimeReuqestsCount(List<Request> requests)
        {
            int result = 0;
            foreach(Request req in requests)
            {
                if (req.GetType() == typeof(RealTimeRequest)) result++;
            }
            return result;
        }

        public int GetMissedDeadlinesCount()
        {
            return missedDeadline;
        }

        public static int GetNonRealtimeCount(List<Request> requests)
        {
            int result = 0;
            foreach (Request req in requests)
            {
                if (!(req.GetType() == typeof(RealTimeRequest))) result++;
            }
            return result;
        }

        public int GetTotalRequestCount() { return totalNuberOfRequests; }
    }
}
