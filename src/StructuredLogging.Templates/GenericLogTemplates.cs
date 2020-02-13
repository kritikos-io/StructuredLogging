namespace Kritikos.StructuredLogging.Templates
{
	/// <summary>
	/// Logging templates for generic application usage.
	/// </summary>
	public static class GenericLogTemplates
	{
		/// <summary>
		/// Unexpected exception occurred.
		/// </summary>
		public const string UnhandledExceptionWithTerminate = "Unhandled Exception occured: {Error}. Terminating: {Terminating}";

		public const string UnhandledException = "Unhandled Exception occured: {Error}";

		/// <summary>
		/// Action requires authentication.
		/// </summary>
		public const string UnauthorizedAction = "User has not authenticated or token has expired!";

		/// <summary>
		/// Service is not responding to queries.
		/// </summary>
		public const string ServerUnreachable = "Could not contact service: {$Server}";

		/// <summary>
		/// Action requires authorization and user has not provided any.
		/// </summary>
		public const string ForbiddenAction =
			"Insufficient permissions for requested action! {$User} tried to {@Context}";
	}
}
