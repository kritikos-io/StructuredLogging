namespace Kritikos.StructuredLogging.Templates
{
	using Kritikos.StructuredLogging.Templates.Base;

	/// <summary>
	/// Logging templates for generic application usage.
	/// </summary>
	public static class GenericLogTemplates
	{
		/// <summary>
		/// Unexpected exception occurred.
		/// </summary>
		public static LogTemplate UnhandledException
			=> new LogTemplate("Unhandled Exception occured: {$Error}. Terminating: {Terminating}");

		/// <summary>
		/// Action requires authentication.
		/// </summary>
		public static LogTemplate UnauthorizedAction
			=> new LogTemplate("User has not authenticated or token has expired! {@Error}");

		/// <summary>
		/// Action requires authorization and user has not provided any.
		/// </summary>
		public static LogTemplate ForbiddenAction
			=> new LogTemplate("Insufficient permissions for requested action! {@Context}");
	}
}
