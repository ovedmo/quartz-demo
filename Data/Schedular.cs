using Quartz;
using Quartz.Impl;
using System;
using Microsoft.AspNetCore.Components;
using System.Threading;

namespace SchedularPrac
{
    public class Scheduler
    {
        //[Inject] public ISchedulerFactory _scd { get; set; }
        public async System.Threading.Tasks.Task Start(DateTime date)

        {
            
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler( );

            scheduler.Start( );
            IJobDetail job = JobBuilder.Create<Job>( ).Build( );
            ITrigger trigger = TriggerBuilder.Create( )
             .WithIdentity("IDGJob", "IDG")
             .StartNow( )
                .WithSimpleSchedule(x => x
                    .WithIntervalInSeconds(15)
                     .RepeatForever( ))
                        .Build( );
            scheduler.ScheduleJob(job, trigger);

        }

    }
}