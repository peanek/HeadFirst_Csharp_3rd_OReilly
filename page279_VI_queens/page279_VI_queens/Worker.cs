using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page279_VI_queens
{
    class Worker
    {
        private string currentJob;
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
            set
            {
                currentJob = value;
            }
        }

        private int shiftsLeft;
        public int ShiftsLeft
        {
            get
            {
                return shiftsLeft;
            }
            set
            {
                shiftsLeft = ShiftsToWork - ShiftsWorked;

            }
        }


        private string[] jobsICanDo;

        public int ShiftsToWork;



        public int ShiftsWorked;


        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;

        }
        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                if (jobsICanDo.Contains(job))
                {
                    this.currentJob = job;
                    this.ShiftsToWork = numberOfShifts;
                    this.ShiftsLeft = ShiftsToWork - ShiftsWorked;


                    return true;
                }
            }
            else
            {
                return false;
            }

            return false;
        }

        public bool DidYouFinish()
        {

            if (shiftsLeft > 0  )
            {
                return false;
            }

            if (shiftsLeft == 0 && !String.IsNullOrEmpty(currentJob))
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

    }
}
