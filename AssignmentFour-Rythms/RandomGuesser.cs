using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour_Rythms
{
    class RandomGuesser : Guesser
    {
        public RandomGuesser()
        {
            this.Name = "RandomGuesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = 100;
            this.TimesRoRun = 100;
            this.Min = this.MaxRandomNum;
        }

        public RandomGuesser(int MaxRandomNum, int TimesRoRun)
        {
            this.Name = "RandomGuesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = MaxRandomNum;
            this.TimesRoRun = TimesRoRun;
            this.Min = this.MaxRandomNum;

        }

        public override int RunOnce(Random random)
        {
            int target = random.Next(1, MaxRandomNum + 1);
            int guess = random.Next(1, MaxRandomNum + 1);
            while (guess != target)
            {
                CurrentCount++;
                guess = random.Next(1, MaxRandomNum + 1);
            }
            if (CurrentCount == 0)
                CurrentCount++;
            return CurrentCount;
        }

        public override void RunNTimes(Random random)
        {
            for (int i = 0; i < TimesRoRun; i++)
            {
                RunOnce(random);
                SetLoopStats();
            }
        }
    }
}
