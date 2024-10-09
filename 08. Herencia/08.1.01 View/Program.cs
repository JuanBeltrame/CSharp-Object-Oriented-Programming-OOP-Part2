using _08._1._01_Library;

Camion camioncito = new Camion(8, 2, 8, Colores.Azul, 5000);
Console.WriteLine("Camion camioncito \nCantidad Ruedas: {0}\nCantidadPuertas: {1} \nColor: {2}, \nCantidad Marchas: {3} \nPeso Carga {4}",
                   camioncito.cantidadRuedas, camioncito.cantidadPuertas, camioncito.color, camioncito.cantidadMarchas, camioncito.pesoCarga);
Console.WriteLine("---------------");

Automovil autito = new(4, 5, 5, Colores.Blanco, 3);
Console.WriteLine("Automovil autito \nCantidad Ruedas: {0}\nCantidadPuertas: {1} \nColor: {2}, \nCantidad Marchas: {3} \nCantidad Pasajeros {4}",
                   autito.cantidadRuedas, autito.cantidadPuertas, autito.color, autito.cantidadMarchas , autito.cantidadPasajeros);
Console.WriteLine("---------------");

Moto motito = new(2, 0, Colores.Blanco, 1000);
Console.WriteLine("Moto motito \nCantidad Ruedas: {0}\nCantidadPuertas: {1} \nColor: {2}, \nCilindrada:{3}",
                   motito.cantidadRuedas, motito.cantidadPuertas, motito.color, motito.cilindradas);
Console.WriteLine("---------------");