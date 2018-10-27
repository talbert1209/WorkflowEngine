using System;

namespace WorkflowEngine
{
    public class SendEmail : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Email Has Been Sent!");
        }
    }
}