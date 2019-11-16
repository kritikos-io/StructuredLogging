namespace Kritikos.LoggingTemplates.Tests
{
	using System;
	using System.Reflection;

	using Kritikos.StructuredLogging.Templates;

	using Seq.Api;

	using Serilog;
	using Serilog.Core;

	public static class Initializer
	{
		internal static readonly string ApplicationName = Assembly
															.GetAssembly(typeof(GenericLogTemplates))
															?
															.GetName()
															.Name ?? string.Empty;

		static Initializer()
		{
			var switchLevel = new LoggingLevelSwitch();
			var seqUri = Environment.GetEnvironmentVariable("Seq:Uri");
			var seqKey = Environment.GetEnvironmentVariable("Seq:ApiKey");

			Log.Logger = new LoggerConfiguration()
				.Enrich.FromLogContext()
				.Enrich.WithProperty("Application", ApplicationName)
				.Enrich.WithProperty("Environment", "Unit Testing")
				.WriteTo.Seq(
					seqUri,
					apiKey: seqKey,
					controlLevelSwitch: switchLevel)
				.CreateLogger();

			Seq = new SeqConnection(
				seqUri,
				apiKey: seqKey,
				true);
		}

		internal static SeqConnection Seq { get; }
	}
}
