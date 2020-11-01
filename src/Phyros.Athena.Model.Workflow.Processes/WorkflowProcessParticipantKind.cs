namespace Phyros.Athena.Model.WorkflowProcess
{
	public class WorkflowProcessParticipantKind
	{
		public WorkflowClaim[] AllowedAssignments { get; set; }
		public string ClaimKind { get; set; }
		public string ClaimValue { get; set; }
	}
}