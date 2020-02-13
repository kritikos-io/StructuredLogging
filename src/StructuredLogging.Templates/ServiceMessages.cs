namespace Kritikos.StructuredLogging.Templates
{
	public static class ServiceMessages
	{
		/// <summary>
		/// Service is starting up.
		/// </summary>
		public const string StartingUp = "{Service} starting up!";

		/// <summary>
		/// Service sucessfully started.
		/// </summary>
		public const string Operational = "{Service} is operational";

		/// <summary>
		/// Service shutdown requested.
		/// </summary>
		public const string Stopping = "{Service} is shutting down!";

		/// <summary>
		/// Service detected problems.
		/// </summary>
		public const string IssueDetected = "{Service} detected issues: {Issue}";
	}
}
