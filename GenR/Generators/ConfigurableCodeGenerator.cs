using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenR.Generators;

public class ConfigurableCodeGenerator : ICodeGenerator
{
	private readonly string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private readonly string numbers = "0123456789";
	private readonly string symbols = "!@#$%^&*()_+-=[]{};':\",./<>?\\|";
	private readonly string mixed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=[]{};':\",./<>?\\|";
	
	public string GenerateNext()
	{
		throw new NotImplementedException();
	}
	
	
}
