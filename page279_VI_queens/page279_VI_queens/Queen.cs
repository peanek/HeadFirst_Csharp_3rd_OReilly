using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page279_VI_queens
{
    class Queen
    {
        private Worker[] workers;
        private int shiftNumber;
        public int ShiftNumber
        {
            get
            {
                return shiftNumber;
            }
        }

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int numberOfShifts)
        {
            foreach (Worker wor in workers)
            {
                if (wor.DoThisJob(job, numberOfShifts))
                {
                    return true;
                }
            }

            return false;

        }

        public string WorkTheNextShift()
        {
            string output;
            output = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (!string.IsNullOrEmpty(workers[i].CurrentJob) && workers[i].ShiftsLeft == 1)
                {
                    output += "Worker #" + (i + 1) + " will be done with " + workers[i].CurrentJob + " after this shift. \r\n";
                }
                if (workers[i].ShiftsLeft>1)
                {
                    output += "Worker #" + (i + 1) + " is doing " + workers[i].CurrentJob + " for "
                        + workers[i].ShiftsLeft + " more shifts. \r\n";
                }

                if (workers[i].DidYouFinish())
                {
                    output += "Worker #" + (i + 1) + " finished the job. \r\n";
                }

                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    output += "Worker #" + (i + 1) + " is not working. \r\n";
                }


                if (workers[i].ShiftsLeft>0)
                {
                    workers[i].ShiftsWorked++;
                    workers[i].ShiftsLeft = workers[i].ShiftsToWork - workers[i].ShiftsWorked;

                }
                else
                {
                    workers[i].ShiftsLeft = 0;
                    workers[i].ShiftsToWork = 0;
                    workers[i].ShiftsWorked = 0;
                    workers[i].CurrentJob = "";
                }





            }

            this.shiftNumber++;
            return output;
        }

    }
}
