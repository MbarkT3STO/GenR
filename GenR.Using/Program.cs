// Old School using

using GenR.Generators;
using GenR.Interfaces;

var generator = new RandomCodeGenerator(10, GenR.Enums.CodeCharacterType.Mixed);

var code = generator.GenerateNext();

Console.WriteLine("The generated code is: " + code);

Console.ReadLine();