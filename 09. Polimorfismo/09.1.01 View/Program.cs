﻿using _09._1._01_View;

SobreSobrescrito sobrecarga = new();

Console.WriteLine(sobrecarga.MiMetodo());
Console.WriteLine("---------------------------------------------");
Console.WriteLine(sobrecarga.ToString());

string objeto = "Este es mi metodo ToString sobreescrito!";

Console.WriteLine("---------------------------------------------");
Console.Write("Comparacion Sobrecarga con String: ");
Console.WriteLine(sobrecarga.Equals(objeto));

Console.WriteLine("---------------------------------------------");
Console.WriteLine(sobrecarga.GetHashCode());