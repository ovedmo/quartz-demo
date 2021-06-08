using Quartz;
using System;
using System.Threading.Tasks;

namespace SchedularPrac
{
    public class Job : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine("My debug output."+DateTime.UtcNow);
            return null;
        }

        /*Task IJob.Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException( );
        }*/
    }
}