using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour_Rythms
{
    class BinaryGuess : Guesser
    {
        public BinaryGuess()
        {
            this.Name = "Binary Guesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = 100;
            this.TimesRoRun = 100;
            this.Min = this.MaxRandomNum;
        }

        public BinaryGuess(int MaxRandomNum, int TimesRoRun)
        {
            this.Name = "Binary Guesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = MaxRandomNum;
            this.TimesRoRun = TimesRoRun;
            this.Min = this.MaxRandomNum;

        }

        public override int RunOnce(Random random)
        {
            int target = random.Next(1, MaxRandomNum + 1);
            return BinarySearchRecursive(target, 1, MaxRandomNum);
        }

        public override void RunNTimes(Random random)
        {
            for (int i = 0; i < TimesRoRun; i++)
            {
                RunOnce(random);
                SetLoopStats();
            }
        }

        public int BinarySearchRecursive( int target, int min, int max)
        {
            CurrentCount++;
            if (min > max)
            {
                return 1;
            }
            else
            {
                int mid = (min + max) / 2;
                if (target == mid)
                    return ++mid;
                else if (target < mid)
                    return BinarySearchRecursive(target, min, mid - 1);
                else
                    return BinarySearchRecursive(target, mid + 1, max);
            }
        }
    }

}

