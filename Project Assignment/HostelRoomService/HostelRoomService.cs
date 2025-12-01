using System;
using System.ServiceProcess;
using System.Timers;

namespace HostelRoomServiceApp
{
    public partial class HostelRoomService : ServiceBase
    {
        private Timer _timer;

        // Constructor
        public HostelRoomService()
        {
            // Set the service name here
            base.ServiceName = "HostelRoomService";
        }

        protected override void OnStart(string[] args)
        {
            _timer = new Timer(10000); // 10 seconds interval
            _timer.Elapsed += OnElapsedTime;
            _timer.AutoReset = true;
            _timer.Enabled = true;

            Console.WriteLine("Service started...");
        }

        protected override void OnStop()
        {
            _timer.Stop();
            _timer.Dispose();

            Console.WriteLine("Service stopped...");
        }

        private void OnElapsedTime(object sender, ElapsedEventArgs e)
        {
            // Example recurring task
            Console.WriteLine($"Service running at {DateTime.Now}");
        }

#if DEBUG
        // Run service as console app for debugging
        public void TestStartupAndStop(string[] args)
        {
            OnStart(args);
            Console.WriteLine("Press any key to stop the service...");
            Console.ReadKey();
            OnStop();
        }
#endif
    }
}
