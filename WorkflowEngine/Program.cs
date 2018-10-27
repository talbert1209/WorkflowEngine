using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            IExecute callWebService = new CallWebService();
            IExecute changeVideoStatus = new ChangeVideoStatus();
            IExecute uploadVideo = new UploadVideo();
            IExecute sendEmail = new SendEmail();

            var activities = new List<IExecute>() {callWebService, changeVideoStatus, uploadVideo, sendEmail};

            var activityEngine = new Engine();

            activityEngine.Run(activities);
        }
    }
}
