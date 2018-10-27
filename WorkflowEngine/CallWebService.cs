using System;

namespace WorkflowEngine
{
    public class CallWebService : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Web Service Called!");
        }
    }
}