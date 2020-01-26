using System.Collections.Generic;

namespace Phyros.Athena.Model.WorkflowProcess
{
	public class WorkflowProcessStartAction
	{
		
		public string Name { get; set; }
		
		public IEnumerable<string> CompletionEvents { get; set; }
		public int? ResultingProcessStepId { get; set; }
		
		public IEnumerable<WorkflowClaim> RequiredComponentClaims { get; set; }
		
		public IEnumerable<string> Conditions { get; set; }
		
		public string[] RequiredVariables { get; set; }
	}
}