﻿

//Animal animal = new Animal(); 
//Animal perro = new Perro();
//Animal carpincho = new Carpincho(); 
//Perro otroPerro = new Perro(); 

//Console.WriteLine($" Animal: {animal.EmitirSonido()}");
//Console.WriteLine($" Perro: {perro.EmitirSonido()}");
//Console.WriteLine($" Carpincho: {carpincho.EmitirSonido()}");
//Console.WriteLine($" otro Perro: {otroPerro.EmitirSonido()}");

using View_Example_09._0._01;

static void EscucharAnimal(Animal animal)
{
    Console.WriteLine($" Este animal hace... : {animal.EmitirSonido()}");
}


List<Animal> animales = new List<Animal>();
// animales.Add(new Animal()); // Roar // No se puede instanciar animal porque es abstracto
animales.Add(new Perro()); // Woof
animales.Add(new Carpincho()); // Viva la revolucion
animales.Add(new Perro()); // Woof

foreach (Animal animal in animales)
{
    EscucharAnimal(animal);
}





