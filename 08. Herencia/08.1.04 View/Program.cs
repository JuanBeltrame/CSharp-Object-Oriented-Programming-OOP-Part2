using _08._1._04_Library;

// Mi central
Centralita c = new("Fede Center");

// Mis 4 llamadas
Local l1 = new("Bernal", 30, "Rosario", 2.65f);
Provincial l2 = new Provincial("Moron", Provincial.Franja.Franja_1, 21, "Bernal");
Local l3 = new("Lanus", 45, "San Rafael", 1.99f);
Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

// Las llamadas se irán registrando en la Centralita.
// La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

c.llamadas.Add(l1);
Console.WriteLine(c.Mostrar());
Console.ReadKey();
Console.Clear();
c.llamadas.Add(l2);
Console.WriteLine(c.Mostrar());
Console.ReadKey();
Console.Clear();
c.llamadas.Add(l3);
Console.WriteLine(c.Mostrar());
Console.ReadKey();
Console.Clear();
c.llamadas.Add(l4);
Console.WriteLine(c.Mostrar());
Console.ReadKey();
Console.Clear();

c.OrdenarLlamadas();
Console.WriteLine(c.Mostrar());