using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDDSimulator
{
    class Drive
    {

        int currentHeadPosition;
        int size;
        int totalMovement;

        public Drive(int newSize, int newPosition)
        {
          
            size = newSize;
            currentHeadPosition = newPosition;
            totalMovement = 0;
        }

        public Drive(int newSize)
        {
            size = newSize;
            currentHeadPosition = 0;
            totalMovement = 0;
        }

        public int GetPosition() { return currentHeadPosition; }
        public void MoveHeadForward()
        {
            currentHeadPosition++;
            totalMovement++;
        }

        public int CalculateDistanceFromPoint(int location)
        {
            return Math.Abs(location - currentHeadPosition);
        }
        public void MoveHeadBack()
        {
            currentHeadPosition--;
            totalMovement++;
        }

        public int GetSize() { return size; }

        public int GetTotalMovement() { return totalMovement; }
    }
}
