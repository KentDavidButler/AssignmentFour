using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour_Rythms
{
    class BruteGuesser : Guesser
    {
        public BruteGuesser()
        {
            this.Name = "BruteForce-Hight2Low";
            this.CurrentCount = 0;
            this.MaxRandomNum = 100;
            this.TimesRoRun = 100;
            this.Min = this.MaxRandomNum;
        }

        public BruteGuesser(int MaxRandomNum, int TimesRoRun)
        {
            this.Name = "BruteForce-Hight2Low Guesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = MaxRandomNum;
            this.TimesRoRun = TimesRoRun;
            this.Min = 999999999; //for some reason wasn't working like rest of values
            this.Max = 0;
        }


        public override int RunOnce(Random random)
        {
            int target = random.Next(1, MaxRandomNum + 1);

            for (int j = TimesRoRun; j > 0; j--)
            {
                CurrentCount++;
                if (j == target)
                {
                    break;
                }
            }
            return CurrentCount;
        }

        public override void RunNTimes(Random random)
        {
            for (int i = 0; i < TimesRoRun; i++)
            {
                Console.WriteLine(RunOnce(random));
                SetLoopStats();
            }
        }
    }
}
