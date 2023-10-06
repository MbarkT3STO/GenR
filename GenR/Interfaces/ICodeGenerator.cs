namespace GenR.Interfaces;

/// <summary>
/// Represents a code generator that can generate code as a string.
/// </summary>
public interface ICodeGenerator
{

    /// <summary>
    /// Generates the next code.
    /// </summary>
    /// <returns>The generated code.</returns>
    string GenerateNext();
}
