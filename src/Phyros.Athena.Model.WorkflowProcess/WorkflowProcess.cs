using System;

namespace Phyros.Athena.Model.WorkflowProcess
{
	public class WorkflowProcess
	{
		public WorkflowProcessStep[] Steps { get; set; }

		public WorkflowProcessStartAction[] StartActions { get; set; }

		public string Name { get; set; }

		public WorkflowProcessVariable[] WorkflowProcessVariables { get; set; }

		public string[] OnCompletionEvents { get; set; }

		public WorkflowProcessCommonAction[] CommonActions { get; set; }

		public WorkflowProcessParticipantKind[] WorkflowProcessParticipantKinds { get; set; }
	}
}
