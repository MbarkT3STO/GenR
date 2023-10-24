namespace GenR.Common
{
	/// <summary>
	/// Represents the configuration for a configurable code generator.
	/// </summary>
	public class ConfigurableCodeGeneratorConfiguration: IConfigurableCodeGeneratorConfiguration
	{
		public CodeCharacterType CharacterType { get; set; }
		public string Source { get; set; }
		public int Length { get; set; }
		
		private (string OnlyLetters, string OnlyNumbers, string LettersAndNumbers, string Mixed) defaultSources = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", "0123456789", "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{};':\",./<>?\\|");
		
		public ConfigurableCodeGeneratorConfiguration(CodeCharacterType characterType, int length)
		{
			CharacterType = characterType;
			Length        = length;
			
			Source = characterType switch
			{
				CodeCharacterType.OnlyLetters => defaultSources.OnlyLetters,
				CodeCharacterType.OnlyNumbers => defaultSources.OnlyNumbers,
				CodeCharacterType.LettersAndNumbers => defaultSources.LettersAndNumbers,
				CodeCharacterType.Mixed => defaultSources.Mixed,
				_ => throw new ArgumentOutOfRangeException(nameof(characterType), characterType, null),
			};
		}
		public ConfigurableCodeGeneratorConfiguration(CodeCharacterType characterType, string source, int length)
		{
			CharacterType = characterType;
			Source        = source;
			Length        = length;
		}
		
	}
}
