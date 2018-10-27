using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Engine
    {
        public void Run(List<IExecute> activities)
        {
            foreach (var activity in activities)
            {
                activity.Execute();
            }
        }
    }
}