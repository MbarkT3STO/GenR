namespace GenR.Interfaces;

/// <summary>
/// Interface for a configurable code generator configuration.
/// </summary>
public interface IConfigurableCodeGeneratorConfiguration
{
	/// <summary>
	/// Gets the character type used in the generated code.
	/// </summary>
	CodeCharacterType CharacterType { get; }
	
	/// <summary>
	/// Gets the source used in the generated code.
	/// </summary>
	string Source { get; }
	
	/// <summary>
	/// Gets the length of the generated code.
	/// </summary>
	int Length { get; }
}

