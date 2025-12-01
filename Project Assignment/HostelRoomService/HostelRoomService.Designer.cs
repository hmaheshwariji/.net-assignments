using System.ComponentModel;
using System.ServiceProcess;

namespace HostelRoomService
{
    partial class HostelRoomService : ServiceBase  // ✅ Inherit ServiceBase
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing); // ✅ Calls ServiceBase.Dispose
        }

        private void InitializeComponent()
        {
            components = new Container();
            this.ServiceName = "HostelRoomService"; // ✅ Works because of ServiceBase
        }
    }
}
