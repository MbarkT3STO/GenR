// Old School using

using GenR.Common;
using GenR.Enums;
using GenR.Generators;

// ------------------------------------------------------------
// Random code generator Example
// ------------------------------------------------------------

// var generator = new RandomCodeGenerator(10, GenR.Enums.CodeCharacterType.Mixed);

// var code = generator.GenerateNext();

// Console.WriteLine("The generated code is: " + code);



// --------------------------------------------------------------
// Configurable code generator Example 1 - Using default sources
// --------------------------------------------------------------

// var generator = new ConfigurableCodeGenerator();

// // A part consisting of only letters
// generator.AddPart(new ConfigurableCodeGeneratorConfiguration(CodeCharacterType.OnlyLetters, 5));

// // A separator part
// generator.AddPart(new ConfigurableCodeGeneratorConfiguration(CodeCharacterType.OnlyLetters, "-", 1));

// // A part consisting of only numbers
// generator.AddPart(new ConfigurableCodeGeneratorConfiguration(CodeCharacterType.OnlyNumbers, 3));

// var code = generator.GenerateNext();

// Console.WriteLine("The generated code is: " + code.ToUpper());


// --------------------------------------------------------------
// Configurable code generator Example 2 - Using custom sources
// --------------------------------------------------------------

var generator = new ConfigurableCodeGenerator();

// A part consisting of only letters
var part1Source = "TRUMP";
var part1Config = new ConfigurableCodeGeneratorConfiguration(CodeCharacterType.OnlyLetters, part1Source, 5);

generator.AddPart(part1Config);

// A separator part
generator.AddPart(new ConfigurableCodeGeneratorConfiguration(CodeCharacterType.OnlyLetters, "-", 1));

// A part consisting of only numbers
var part2Source = "2024";
var part2Config = new ConfigurableCodeGeneratorConfiguration(CodeCharacterType.OnlyNumbers, part2Source, 5);

generator.AddPart(part2Config);

// A separator part
generator.AddPart(new ConfigurableCodeGeneratorConfiguration(CodeCharacterType.OnlyLetters, "-", 1));

// A part consisting of only letters
var part3Source = "MAGA";
var part3Config = new ConfigurableCodeGeneratorConfiguration(CodeCharacterType.OnlyLetters, part3Source, 5);

generator.AddPart(part3Config);


var code = generator.GenerateNext();

Console.WriteLine("The generated code is: " + code.ToUpper());




Console.ReadLine();


