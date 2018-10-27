using System;

namespace WorkflowEngine
{
    public class ChangeVideoStatus : IExecute
    {
        public void Execute()
        {
            Console.WriteLine(@"Video Status Has Been Changed To 'Processing'");
        }
    }
}