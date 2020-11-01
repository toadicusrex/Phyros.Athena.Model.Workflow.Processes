using Phyros.Athena.Model.Workflow.EventTriggers;

namespace Phyros.Athena.Model.WorkflowProcess
{
	public class WorkflowProcessStep
	{
		public int ProcessStepId { get; set; }
		
		public WorkflowProcessStepAction[] Actions { get; set; }
		
		public IEventTrigger[] ExitEvents { get; set; }
		
		public IEventTrigger[] EntryEvents { get; set; }
		
		public string Name { get; set; }
		
		public WorkflowProcessStepView[] Views { get; set; }
	}
}