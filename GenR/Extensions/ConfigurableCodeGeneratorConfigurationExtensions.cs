using GenR.Common;

namespace GenR.Extensions;

public static class ConfigurableCodeGeneratorConfigurationExtensions
{
	/// <summary>
	/// Creates a new instance of <see cref="ConfigurableCodeGenerator"/> with the specified <paramref name="configuration"/>.
	/// </summary>
	/// <param name="configuration">The configuration to use for the code generator.</param>
	/// <returns>A new instance of <see cref="ConfigurableCodeGenerator"/> with the specified <paramref name="configuration"/>.</returns>
	public static ConfigurableCodeGenerator CreateConfigurableCodeGenerator(this ConfigurableCodeGeneratorConfiguration configuration)
	{
		var generator = new ConfigurableCodeGenerator();

		generator.AddPart(configuration);

		return generator;
	}


	/// <summary>
	/// Creates a new instance of <see cref="ConfigurableCodeGenerator"/> and adds the specified <see cref="ConfigurableCodeGeneratorConfiguration"/> instances to it.
	/// </summary>
	/// <param name="configurations">The collection of <see cref="ConfigurableCodeGeneratorConfiguration"/> instances to add to the generator.</param>
	/// <returns>A new instance of <see cref="ConfigurableCodeGenerator"/> with the specified configurations added to it.</returns>
	public static ConfigurableCodeGenerator CreateConfigurableCodeGenerator(this IEnumerable<ConfigurableCodeGeneratorConfiguration> configurations)
	{
		var generator = new ConfigurableCodeGenerator();
		
		foreach (var configuration in configurations)
		{
			generator.AddPart(configuration);
		}

		return generator;
	}
}