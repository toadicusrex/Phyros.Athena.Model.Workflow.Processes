namespace Phyros.Athena.Model.WorkflowProcess
{
	public class WorkflowProcessStep
	{
		public int ProcessStepId { get; set; }
		
		public WorkflowProcessStepAction[] Actions { get; set; }
		
		public string[] ExitEvents { get; set; }
		
		public string[] EntryEvents { get; set; }
		
		public string Name { get; set; }
		
		public WorkflowProcessStepView[] Views { get; set; }
	}
}