using System;

namespace WorkflowEngine
{
    public class UploadVideo : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Video Uploaded!");
        }
    }
}