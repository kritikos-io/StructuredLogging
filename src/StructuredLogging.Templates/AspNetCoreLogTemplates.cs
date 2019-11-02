namespace Kritikos.StructuredLogging.Templates
{
	using Kritikos.StructuredLogging.Templates.Base;

	/// <summary>
	/// Logging templates for ASP.NET Core.
	/// </summary>
	public static class AspNetCoreLogTemplates
	{
		/// <summary>
		/// List of migrations about to be applied to database.
		/// </summary>
		public static LogTemplate ApplyingMigrations
			=> new LogTemplate("Applying migrations to database: {@Migrations}");

		/// <summary>
		/// Client requested unavailable entity.
		/// </summary>
		public static LogTemplate EntityNotFound
			=> new LogTemplate("{Entity} {Identifier} not found or not accessible for requesting user");

		/// <summary>
		/// Entity to be updated has been altered by someone else.
		/// </summary>
		public static LogTemplate ConcurrencyError
			=> new LogTemplate("Concurrency error while updating {@Entity}");

		/// <summary>
		/// Entity to be updated has been altered by someone else, with conflicting properties listed.
		/// </summary>
		public static LogTemplate ConcurrencyErrorVerbose
			=> new LogTemplate("Concurrency error while updating {@Entity}: {@Conflicts}");

		/// <summary>
		/// A hard delete is about to occur.
		/// </summary>
		public static LogTemplate PermanentDeletion
			=> new LogTemplate("Permanent deletion of {@Entity} requested by {User}");

		/// <summary>
		/// Invalid transition requested.
		/// </summary>
		public static LogTemplate InvalidTransition
			=> new LogTemplate("Invalid transition requested for {@Entity}: {$Status}");

		/// <summary>
		/// Invalid transition requested, with supported transitions listed.
		/// </summary>
		public static LogTemplate InvalidTransitionVerbose
			=> new LogTemplate(
				"Invalid transition requested for {@Entity}: {$Status}. Supported transitions: {@Transitions}");
	}
}
