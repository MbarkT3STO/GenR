namespace GenR.Common
{
	/// <summary>
	/// Represents the configuration for a configurable code generator.
	/// </summary>
	public class ConfigurableCodeGeneratorConfiguration : IConfigurableCodeGeneratorConfiguration
	{
		public CodeCharacterType CharacterType { get; set; }
		public string Source { get; set; }
		public int Length { get; set; }
		
		public ConfigurableCodeGeneratorConfiguration(CodeCharacterType characterType, string source, int length)
		{
			CharacterType = characterType;
			Source = source;
			Length = length;
		}
	}
}
