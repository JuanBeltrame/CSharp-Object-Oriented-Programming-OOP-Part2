using _09._1._02_Library;
using System.Text;

List<Figura> figuras = new();

figuras.Add(new Circulo(2));
figuras.Add(new Cuadrado(3));
figuras.Add(new Rectangulo(4, 8));

StringBuilder sb = new();

foreach (Figura figura in figuras)
{
    sb.AppendLine();
    sb.AppendFormat("-------- Figura {0:0#} --------\n", figuras.IndexOf(figura) + 1);
    sb.AppendFormat(" Tipo: {0}\n", figura.GetType());
    sb.AppendFormat(" {0}\n", figura.Dibujar());
    sb.AppendFormat(" Area: {0:0.00}\n", figura.CalcularSuperficie());
    sb.AppendFormat(" Perimetro: {0:0.00}\n", figura.CalcularPerimetro());
    sb.AppendLine("---------------------------");
    sb.AppendLine();
}

Console.WriteLine(sb.ToString());
Console.ReadKey();