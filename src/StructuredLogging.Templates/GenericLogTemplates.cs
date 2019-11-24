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
		public const string UnhandledException = "Unhandled Exception occured: {$Error}. Terminating: {Terminating}";

		/// <summary>
		/// Action requires authentication.
		/// </summary>
		public const string UnauthorizedAction = "User has not authenticated or token has expired!";

		/// <summary>
		/// Service is not responding to queries.
		/// </summary>
		public const string ServiceUnreachable = "Could not contact service: {$Error}";

		/// <summary>
		/// Action requires authorization and user has not provided any.
		/// </summary>
		public const string ForbiddenAction =
			"Insufficient permissions for requested action! {@User} tried to {@Context}";
	}
}
