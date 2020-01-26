using System.Collections.Generic;

namespace Phyros.Athena.Model.WorkflowProcess
{
	public class WorkflowProcessStepView
	{
		public IEnumerable<WorkflowClaim> RequiredComponentClaims { get; set; }
		
		public string Name { get; set; }
	}
}