using View_Example_09._0._02;

Persona persona = new("Marta", 'x', "1111");
Persona otraPersona = new("Juan Perez", 'x', "1111");
Persona unaPersonaMas = new("Juan Perez", 'x', "1234");

Console.WriteLine("Primera Comparacion");
Console.WriteLine(persona == otraPersona); // True
Console.WriteLine(persona.Equals(otraPersona)); // True
Console.WriteLine(ReferenceEquals(persona , otraPersona)); // False
Console.WriteLine($"Persona: {persona.GetHashCode()}");
Console.WriteLine($"Otra Persona: {otraPersona.GetHashCode()}");

Console.WriteLine("\n Segunda Comparacion");
Console.WriteLine(persona == unaPersonaMas); // False
Console.WriteLine(persona.Equals(unaPersonaMas)); // False
Console.WriteLine($"Persona: {persona.GetHashCode()}");
Console.WriteLine($"Otra Persona: {unaPersonaMas.GetHashCode()}");
