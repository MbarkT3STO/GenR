namespace GenR.Generators;

/// <summary>
/// Represents a random code generator.
/// </summary>
public class RandomCodeGenerator : ICodeGenerator
{
	private readonly string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private readonly string numbers = "0123456789";
	private readonly string symbols = "!@#$%^&*()_+-=[]{};':\",./<>?\\|";
	private readonly string mixed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{};':\",./<>?\\|";

	private readonly Random random = new Random();

	private readonly int length;
	private readonly CodeCharacterType characterType;


	public RandomCodeGenerator(int length, CodeCharacterType characterType)
	{
		this.length = length;
		this.characterType = characterType;
	}

	//<inheritdoc />
	public string GenerateNext()
	{
		return characterType switch
		{
			CodeCharacterType.OnlyLetters => GenerateOnlyLetters(),
			CodeCharacterType.OnlyNumbers => GenerateOnlyNumbers(),
			CodeCharacterType.LettersAndNumbers => GenerateLettersAndNumbers(),
			CodeCharacterType.Mixed => GenerateMixed(),
			_ => throw new ArgumentOutOfRangeException(nameof(characterType), characterType, null),
		};
	}
	

	/// <summary>
	/// Generates a random string of letters with the specified length.
	/// </summary>
	/// <returns>A string of random letters.</returns>
	private string GenerateOnlyLetters()
	{
		var code = "";

		for (var i = 0; i < length; i++)
		{
			code += letters[random.Next(letters.Length)];
		}

		return code;
	}

	/// <summary>
	/// Generates a random code consisting of only numbers.
	/// </summary>
	/// <returns>A string representing the generated code.</returns>
	private string GenerateOnlyNumbers()
	{
		var code = "";

		for (var i = 0; i < length; i++)
		{
			code += numbers[random.Next(numbers.Length)];
		}

		return code;
	}

	/// <summary>
	/// Generates a random string consisting of letters and numbers.
	/// </summary>
	/// <returns>A string containing randomly generated letters and numbers.</returns>
	private string GenerateLettersAndNumbers()
	{
		var code = "";

		const byte letterIndex = 0;
		const byte numberIndex = 1;


		for (var i = 0; i < length; i++)
		{
			var nextIndex = random.Next(letterIndex, numberIndex+1);

			if (nextIndex == letterIndex)
			{
				code += letters[random.Next(letters.Length-1)];
			}
			else
			{
				code += numbers[random.Next(numbers.Length-1)];
			}
		}


		return code;
	}

	/// <summary>
	/// Generates a random string consisting of letters, numbers and symbols.
	/// </summary>
	/// <returns>A string containing randomly generated letters, numbers and symbols.</returns>
	private string GenerateMixed()
	{
		var code = "";

		const byte letterIndex = 0;
		const byte numberIndex = 1;
		const byte symbolIndex = 2;

		for (var i = 0; i < length; i++)
		{
			var nextIndex = random.Next(letterIndex, symbolIndex+1);

			if (nextIndex == letterIndex)
			{
				code += letters[random.Next(letters.Length-1)];
			}
			else if (nextIndex == numberIndex)
			{
				code += numbers[random.Next(numbers.Length-1)];
			}
			else
			{
				code += symbols[random.Next(symbols.Length-1)];
			}
		}

		return code;
	}
}
