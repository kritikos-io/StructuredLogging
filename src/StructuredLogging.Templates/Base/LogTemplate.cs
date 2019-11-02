namespace Kritikos.StructuredLogging.Templates.Base
{
	/// <summary>
	/// Simple wrapper for structured logging templates.
	/// </summary>
	public class LogTemplate
	{
		/// <summary>
		/// Creates a new log template with the suppied message.
		/// </summary>
		/// <param name="template">Message to be logged.</param>
		public LogTemplate(string template)
			=> Template = template;

		/// <summary>
		/// Message Template.
		/// </summary>
		public string Template { get; }

		/// <summary>
		/// Template hash code used to identify events.
		/// </summary>
		public uint TemplateCode
			=> this.GetTemplateCode();

		/// <summary>
		/// Implicit string conversion to message template.
		/// </summary>
		/// <param name="template">LogTemplate to convert.</param>
		public static implicit operator string(LogTemplate template)
			=> template?.Template ?? string.Empty;

		/// <inheritdoc />
		public override string ToString() => Template;
	}
}
