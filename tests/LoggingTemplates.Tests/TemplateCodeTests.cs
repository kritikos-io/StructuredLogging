namespace Kritikos.LoggingTemplates.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Threading;
	using System.Threading.Tasks;

	using Kritikos.StructuredLogging.Templates;
	using Kritikos.StructuredLogging.Templates.Helpers;

	using Seq.Api.Client;
	using Seq.Api.Model.Events;

	using Serilog;

	using Xunit;

	public class TemplateCodeTests
	{
		[SkippableFact]
		public async Task Tests()
		{
			var app = Initializer.ApplicationName;
			var then = DateTime.UtcNow;
			Log.Error(
				GenericLogTemplates.UnauthorizedAction);
			Thread.Sleep(5000);

			try
			{
				await Initializer.Seq.EnsureConnected(new TimeSpan(0, 0, 5));
			}
			catch (SeqApiException)
			{
				Skip.If(true);
			}

			var eventId = GenericLogTemplates.UnauthorizedAction.GetTemplateCode();
			var now = DateTime.UtcNow;
			var events = (await Initializer.Seq.Events
				.InSignalAsync(
					filter: $"Application = '{app}' and Environment = 'Unit Testing'",
					fromDateUtc: then,
					toDateUtc: now,
					render: true)).Events;

			var ev = events.FirstOrDefault(x => x.EventType == eventId);
			Assert.NotNull(ev);
			Assert.Equal(GenericLogTemplates.UnauthorizedAction, ev.RenderedMessage);
		}
	}
}
