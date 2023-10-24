using System.Text;
using GenR.Common;

namespace GenR.Generators;

public class ConfigurableCodeGenerator : ICodeGenerator
{
	private List<ConfigurableCodeGeneratorConfiguration> configurations = new();
	
	
	/// <summary>
	/// Generates the next code based on the configurations provided.
	/// </summary>
	/// <returns>The generated code as a string.</returns>
	public string GenerateNext()
	{
		var result = new StringBuilder();

		foreach (var configuration in configurations)
		{
			if(configuration.CharacterType == CodeCharacterType.OnlyLetters)
				result.Append(GenerateOnlyLetters(configuration.Source, configuration.Length));
				
			else if(configuration.CharacterType == CodeCharacterType.OnlyNumbers)
				result.Append(GenerateOnlyNumbers(configuration.Source, configuration.Length));
				
			else if(configuration.CharacterType == CodeCharacterType.LettersAndNumbers)
				result.Append(GenerateLettersAndNumbers(configuration.Source, configuration.Length));
				
			else if(configuration.CharacterType == CodeCharacterType.Mixed)
				result.Append(GenerateMixed(configuration.Source, configuration.Length));
				
			else
				throw new ArgumentOutOfRangeException(nameof(configuration.CharacterType), configuration.CharacterType, null);
		}
		
		return result.ToString();
			
	}


	/// <summary>
	/// Adds a new part to the configurable code generator.
	/// <br/>
	/// Every part means a new part that will be added to the the generated code.
	/// <br/>
	/// For example, if you add 3 parts, the generated code will contain 3 parts (separated by a chosen separator).
	/// <br/>
	/// A part can be a separator.
	/// </summary>
	/// <param name="characterType">The type of character to generate.</param>
	/// <param name="source">The source of the characters to generate.</param>
	/// <param name="length">The length of the characters to generate.</param>
	/// <returns>The configurable code generator instance.</returns>
	public ConfigurableCodeGenerator AddPart(CodeCharacterType characterType, string source, int length)
	{
		var configuration = new ConfigurableCodeGeneratorConfiguration(characterType, source, length);
		configurations.Add(configuration);
		
		return this;
	}


	/// <summary>
	/// Adds a new part to the configurable code generator.
	/// <br/>
	/// Every part means a new part that will be added to the the generated code.
	/// <br/>
	/// For example, if you add 3 parts, the generated code will contain 3 parts (separated by a chosen separator).
	/// <br/>
	/// A part can be a separator.
	/// </summary>
	/// <param name="characterType">The type of character to generate.</param>
	/// <param name="source">The source of the characters to generate.</param>
	/// <param name="length">The length of the characters to generate.</param>
	/// <returns>The configurable code generator instance.</returns>
	public ConfigurableCodeGenerator AddPart(CodeCharacterType characterType, int length)
	{
		var configuration = new ConfigurableCodeGeneratorConfiguration(characterType, length);
		configurations.Add(configuration);
		
		return this;
	}


	/// <summary>
	/// Adds a new configuration part to the generator.
	/// <br/>
	/// Every configuration part means a new part that will be added to the generated code.
	/// <br/>
	/// For example, if you add 3 configuration parts, the generated code will contain 3 parts (separated by a chosen separator).
	/// <br/>
	/// A part can be a separator.
	/// </summary>
	/// <param name="configuration">The configuration to add.</param>
	/// <returns>The updated generator instance.</returns>
	public ConfigurableCodeGenerator AddPart(ConfigurableCodeGeneratorConfiguration configuration)
	{
		configurations.Add(configuration);
		return this;
	}
	
	

	/// <summary>
	/// Generates a random string of specified length using only letters from the source string.
	/// </summary>
	/// <param name="source">The source string to generate letters from.</param>
	/// <param name="length">The length of the generated string.</param>
	/// <returns>A random string of specified length using only letters from the source string.</returns>
	private string GenerateOnlyLetters(string source, int length)
	{
		var code = "";
		var random = new Random();

		for (var i = 0; i < length; i++)
		{
			code += source[random.Next(source.Length-1)];
		}

		return code;
	}
	
	
	/// <summary>
	/// Generates a random string of specified length using only numbers from the source string.
	/// </summary>
	/// <param name="source">The source string to generate numbers from.</param>
	/// <param name="length">The length of the generated string.</param>
	/// <returns>A random string of specified length using only numbers from the source string.</returns>
	private string GenerateOnlyNumbers(string source, int length)
	{
		var code = "";
		var random = new Random();

		for (var i = 0; i < length; i++)
		{
			code += source[random.Next(source.Length-1)];
		}

		return code;
	}
	
	
	/// <summary>
	/// Generates a random string of specified length using letters and numbers from the source string.
	/// </summary>
	/// <param name="source">The source string to generate letters and numbers from.</param>
	/// <param name="length">The length of the generated string.</param>
	/// <returns>A random string of specified length using letters and numbers from the source string.</returns>
	private string GenerateLettersAndNumbers(string source, int length)
	{
		var code = "";
		var random = new Random();

		for (var i = 0; i < length; i++)
		{
			code += source[random.Next(source.Length-1)];
		}

		return code;
	}
	
	
	/// <summary>
	/// Generates a random string of specified length using letters, numbers and symbols from the source string.
	/// </summary>
	/// <param name="source">The source string to generate letters, numbers and symbols from.</param>
	/// <param name="length">The length of the generated string.</param>
	/// <returns>A random string of specified length using letters, numbers and symbols from the source string.</returns>
	private string GenerateMixed(string source, int length)
	{
		var code = "";
		var random = new Random();

		for (var i = 0; i < length; i++)
		{
			code += source[random.Next(source.Length-1)];
		}

		return code;
	}
	
	
	

}
