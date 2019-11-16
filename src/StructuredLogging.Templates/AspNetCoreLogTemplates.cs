namespace Kritikos.StructuredLogging.Templates
{
	/// <summary>
	/// Logging templates for ASP.NET Core.
	/// </summary>
	public static class AspNetCoreLogTemplates
	{
		/// <summary>
		/// List of migrations about to be applied to database.
		/// </summary>
		public const string ApplyingMigrations = "Applying migrations to database: {@Migrations}";

		/// <summary>
		/// Client requested unavailable entity.
		/// </summary>
		public const string EntityNotFound = "{Entity} {Identifier} not found or not accessible for requesting user";

		/// <summary>
		/// Entity to be updated has been altered by someone else.
		/// </summary>
		public const string ConcurrencyError = "Concurrency error while updating {@Entity}";

		/// <summary>
		/// Entity to be updated has been altered by someone else, with conflicting properties listed.
		/// </summary>
		public const string ConcurrencyErrorVerbose = "Concurrency error while updating {@Entity}: {@Conflict}";

		/// <summary>
		/// A hard delete is about to occur.
		/// </summary>
		public const string PermanentDeletion = "Permanent deletion of {@Entity} requested by {User}";

		/// <summary>
		/// Invalid transition requested.
		/// </summary>
		public const string InvalidTransition = "Invalid transition requested for {@Entity}: {$Status}";

		/// <summary>
		/// Invalid transition requested, with supported transitions listed.
		/// </summary>
		public const string InvalidTransitionVerbose =
			"Invalid transition requested for {@Entity}: {$Status}. Supported transitions: {@Transitions}";
	}
}
