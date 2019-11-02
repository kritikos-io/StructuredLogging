namespace Kritikos.StructuredLogging.Templates.Base
{
	using System;
	using System.Text;

	using Murmur;

	/// <summary>
	/// Common extensions for log templates.
	/// </summary>
	internal static class LogTemplateExtensions
	{
		/// <summary>
		/// Hashes event code based on message to group event types.
		/// </summary>
		/// <param name="template">Template to hash.</param>
		/// <returns>The numeric hash used to identify this event type.</returns>
		/// <remarks>Hashing done based on Murmur, compatible with Seq event identification.</remarks>
		internal static uint GetTemplateCode(this LogTemplate template)
		{
			using var murmur = MurmurHash.Create32();
			var bytes = Encoding.UTF8.GetBytes(template?.Template ?? throw new ArgumentNullException(nameof(template)));
			var hash = murmur.ComputeHash(bytes);
			var numerichash = BitConverter.ToUInt32(hash, 0);

			return numerichash;
		}
	}
}
