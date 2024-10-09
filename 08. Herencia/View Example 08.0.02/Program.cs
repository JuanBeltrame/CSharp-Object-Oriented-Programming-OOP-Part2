using Library_Example_08._0._02;

static void Imprimir(Publicacion p)
{
    Console.WriteLine(p.MostrarDatos());
}

Publicacion publicacion = new("Guia de C#", DateTime.Now);

Libro libro = new("Rayuela", "Julio Cortazar", new DateTime(1966, 04, 12));
Revista revista = new("Noticias", new DateTime(2022, 04, 26));

libro.Precio = 125.54f;

List<Publicacion> listaDeLibros = new List<Publicacion>();
listaDeLibros.Add(libro);
listaDeLibros.Add(revista);
listaDeLibros.Add(publicacion);

foreach (Publicacion item in listaDeLibros)
{
    Console.WriteLine(item.MostrarDatos());
    if (item is Libro)
    {
        Console.WriteLine(((Libro)item).MostrarDatos());
        Console.WriteLine($"${((Libro)item).Precio}");
    }
    else
    {
        Console.WriteLine(item.MostrarDatos());
    }
        
}

Imprimir(publicacion);

Console.WriteLine(libro.MostrarDatos());
Console.WriteLine(revista.MostrarDatos());