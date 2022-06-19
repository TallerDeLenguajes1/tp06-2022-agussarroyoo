// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int reanudar, operacion;
Calculadora Uno = new Calculadora();
System.Console.WriteLine("Ingrese el primer operando: ");
Uno.X = double.Parse(Console.ReadLine());

do
{
    System.Console.WriteLine("Ingrese el segundo operando: ");
    Uno.Y = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Ingrese la operacion a realizar: ");
    System.Console.WriteLine("1.Suma");
    System.Console.WriteLine("2.Resta");
    System.Console.WriteLine("3.Multiplicacion");
    System.Console.WriteLine("4.Division");

    operacion = Int32.Parse(Console.ReadLine());

    switch (operacion)
    {
        case 1:
            System.Console.WriteLine("El resultado es: " + Uno.Sumar());
            Uno.X = Uno.Sumar();
        break;
        case 2:
            System.Console.WriteLine("El resultado es: " + Uno.Restar());
            Uno.X = Uno.Restar();
        break;
        case 3:
            System.Console.WriteLine("El resultado es: " + Uno.Multiplicar());
            Uno.X = Uno.Multiplicar();
        break;
        case 4:
            System.Console.WriteLine("El resultado es: " + Uno.Dividir());
            Uno.X = Uno.Dividir();
        break;
    }

    System.Console.WriteLine("Para realizar otra operacion presione 1");
    reanudar = Int32.Parse(Console.ReadLine());

} while (reanudar == 1);
class Calculadora {

    private double x,y;

    public double X {

        get{
            return x;
        }
        set {
            x = value;
        }
    }
    public double Y {

        get{
            return y;
        }
        set {
            y = value;
        }
    }

    public double Sumar() {
        return x+y;
    }

    public double Restar() {
        return x-y;
    }

    public double Multiplicar() {
        return x*y;
    }

    public double Dividir() {
        return x/y;
    }

    void Limpiar() {
        x = 0;
        y = 0;
    }
}


