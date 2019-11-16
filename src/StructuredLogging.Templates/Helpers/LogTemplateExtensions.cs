namespace Kritikos.StructuredLogging.Templates.Helpers
{
	using System;
	using System.Text;

	using Murmur;

	/// <summary>
	/// Common extensions for log templates.
	/// </summary>
	public static class LogTemplateExtensions
	{
		/// <summary>
		/// Hashes event code based on message to group event types.
		/// </summary>
		/// <param name="messageTemplate">Message Template to hash.</param>
		/// <returns>The numeric hash (in hex) used to identify this event type.</returns>
		/// <remarks>Hashing done based on Murmur, compatible with Seq event identification.</remarks>
		public static string GetTemplateCode(this string messageTemplate)
		{
			using var murmur = MurmurHash.Create32();
			var bytes = Encoding.UTF8.GetBytes(messageTemplate
												?? throw new ArgumentNullException(nameof(messageTemplate)));
			var hash = murmur.ComputeHash(bytes);
			var numerichash = BitConverter.ToUInt32(hash, 0);

			return $"${numerichash:X}";
		}
	}
}
