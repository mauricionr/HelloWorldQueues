using Microsoft.Azure.Jobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebJobs
{
    // To learn more about Windows Azure WebJobs start here http://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connectionstring values in app.config
        // AzureJobsRuntime and AzureJobsData
        static void Main()
        {
            JobHost host = new JobHost();
            host.RunAndBlock();
        }

        public static void ProcessQueueMessage([QueueTrigger("inputqueue")] string inputText)
        {
            // Process Queue Message
        }
    }
}
