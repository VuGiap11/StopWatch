using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class SW
    {
        private DateTime startTime;
        private DateTime endTime;

        public SW(DateTime startTime, DateTime endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }
        public SW()
        {
            startTime = DateTime.Now;
        }

        public DateTime StartTime { get => startTime;}
        public DateTime EndTime { get => endTime;}
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public double GetELapsedTime()
        {
            return(endTime - startTime).TotalMilliseconds;
        }
    }
}
