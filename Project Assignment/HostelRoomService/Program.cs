using System;
using System.ServiceProcess;

namespace HostelRoomServiceApp
{
    internal static class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            // Run as console app for debugging
            HostelRoomService service = new HostelRoomService();
            service.TestStartupAndStop(args);
#else
            // Run as Windows Service
            ServiceBase[] ServicesToRun = new ServiceBase[]
            {
                new HostelRoomService()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
