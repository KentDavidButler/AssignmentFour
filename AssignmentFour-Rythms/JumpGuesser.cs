using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour_Rythms
{
    class JumpGuesser : Guesser
    {
        private int Jump { get; set; }
        public JumpGuesser()
        {
            this.Name = "Jump Guesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = 100;
            this.TimesRoRun = 100;
            this.Min = this.MaxRandomNum;
            this.Jump = MaxRandomNum / 10;
        }

        public JumpGuesser(int MaxRandomNum, int TimesRoRun)
        {
            this.Name = "Jump Guesser";
            this.CurrentCount = 0;
            this.MaxRandomNum = MaxRandomNum;
            this.TimesRoRun = TimesRoRun;
            this.Min = this.MaxRandomNum;
            this.Jump = MaxRandomNum / 10;
        }

        public override int RunOnce(Random random)
        {

            int target = random.Next(1, MaxRandomNum + 1);
            int guess = 1;

            while (guess != target)
            {
                CurrentCount++;
                if (guess < target)
                {
                    guess += Jump;
                }
                else
                {
                    //once we passed the target we reduce the amount being jumped by
                    Jump = 5;
                    guess -= 3;
                }
            }
            if (CurrentCount == 0)
                CurrentCount++;
            return CurrentCount;
        }

    }
}

