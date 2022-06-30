// // See https://aka.ms/new-console-template for more information
// int reanudar, operacion;
// Calculadora Uno = new Calculadora();
// System.Console.WriteLine("Ingrese el primer operando: ");
// Uno.X = double.Parse(Console.ReadLine());

// do
// {
//     System.Console.WriteLine("Ingrese el segundo operando: ");
//     Uno.Y = double.Parse(Console.ReadLine());
//     System.Console.WriteLine("Ingrese la operacion a realizar: ");
//     System.Console.WriteLine("1.Suma");
//     System.Console.WriteLine("2.Resta");
//     System.Console.WriteLine("3.Multiplicacion");
//     System.Console.WriteLine("4.Division");

//     operacion = Int32.Parse(Console.ReadLine());

//     switch (operacion)
//     {
//         case 1:
//             System.Console.WriteLine("El resultado es: " + Uno.Sumar());
//             Uno.X = Uno.Sumar();
//         break;
//         case 2:
//             System.Console.WriteLine("El resultado es: " + Uno.Restar());
//             Uno.X = Uno.Restar();
//         break;
//         case 3:
//             System.Console.WriteLine("El resultado es: " + Uno.Multiplicar());
//             Uno.X = Uno.Multiplicar();
//         break;
//         case 4:
//             System.Console.WriteLine("El resultado es: " + Uno.Dividir());
//             Uno.X = Uno.Dividir();
//         break;
//     }

//     System.Console.WriteLine("Para realizar otra operacion presione 1. Para empezar de nuevo presione 0.");
//     reanudar = Int32.Parse(Console.ReadLine());
//         if (reanudar == 0)
//         {
//             Uno.Limpiar();
//         }

// } while (reanudar == 1 || reanudar == 0);
// class Calculadora {

//     private double x,y;

//     public double X {

//         get{
//             return x;
//         }
//         set {
//             x = value;
//         }
//     }
//     public double Y {

//         get{
//             return y;
//         }
//         set {
//             y = value;
//         }
//     }

//     public double Sumar() {
//         return x+y;
//     }

//     public double Restar() {
//         return x-y;
//     }

//     public double Multiplicar() {
//         return x*y;
//     }

//     public double Dividir() {
//         return x/y;
//     }

//     public void Limpiar() {
//         x = 0;
//         y = 0;
//     }
// }



    //punto c

    Empleado []empleados = new Empleado[3];
    int dia,mes,anio;
    for (int i = 0; i < 1; i++)
    {
        empleados[i] = new Empleado();
        //pedir datos
        System.Console.WriteLine("--- INGRESO DE DATOS DE EMPLEADO NRO [" + ((short)(i+1)) + "] ---");
        System.Console.WriteLine("Ingrese el nombre");
        empleados[i].Nombre = Console.ReadLine();
        System.Console.WriteLine("Ingrese el apellido");
        empleados[i].Apellido = Console.ReadLine();
        System.Console.WriteLine("Ingrese su fecha de nacimiento: ");
        System.Console.WriteLine("Dia: ");
        dia = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Mes: ");
        mes = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Año: ");
        anio = Int32.Parse(Console.ReadLine());
        empleados[i].FechaNac = new DateTime(anio,mes,dia);
        do
        {
            System.Console.WriteLine("Ingrese su genero: F/M/X");
            empleados[i].Genero = char.Parse(Console.ReadLine());
        } while (empleados[i].Genero != 'F' && empleados[i].Genero != 'M' && empleados[i].Genero != 'X');

        do
        {
            System.Console.WriteLine("Ingrese su estado civil: S/C/V");
            empleados[i].EstadoCivil = char.Parse(Console.ReadLine());
        } while (empleados[i].EstadoCivil != 'S' && empleados[i].EstadoCivil != 'C' && empleados[i].EstadoCivil != 'V');
        
        System.Console.WriteLine("Ingrese su fecha de ingreso a la empresa: ");
        System.Console.WriteLine("Dia: ");
        dia = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Mes: ");
        mes = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Año: ");
        anio = Int32.Parse(Console.ReadLine());
        empleados[i].FechaIng = new DateTime(anio,mes,dia);
        System.Console.WriteLine("Ingrese su sueldo basico");
        empleados[i].SueldoBasico= double.Parse(Console.ReadLine());

        do
        {
             System.Console.WriteLine("Ingrese el cargo que maneja actualmente");
            System.Console.WriteLine("0:Auxiliar, 1.Administrativo, 2. Ingeniero, 3. Especialista, 4.Investigador");
            empleados[i].Cargo =(Cargos)Int32.Parse(Console.ReadLine()); 
        } while (empleados[i].Cargo < 0 || (int)empleados[i].Cargo > 4);
        
       
    }

    int edad;

    for (int j = 0; j < 1; j++)
    {
        System.Console.WriteLine("-- DATOS DE EMPLEADO NRO [" + ((short)(j+1)) + "] --");
        System.Console.WriteLine("Nombre: " + empleados[j].Nombre);
        System.Console.WriteLine("Apellido: " + empleados[j].Apellido);
        System.Console.WriteLine("Fecha de nacimiento: " + empleados[j].FechaNac);
        System.Console.WriteLine("Edad: " + empleados[j].Edad);
        edad = DateTime.Today.AddTicks(-empleados[j].FechaNac.Ticks).Year - 1;
        System.Console.WriteLine("EDAAAAAD: " + edad);
        System.Console.WriteLine("Genero: " + empleados[j].Genero);
        System.Console.WriteLine("Estado Civil: " + empleados[j].EstadoCivil);
        System.Console.WriteLine("Cargo: " + empleados[j].Cargo);
        System.Console.WriteLine("Sueldo Basico: " + empleados[j].SueldoBasico);
        System.Console.WriteLine("Fecha de Ingreso a la empresa: " + empleados[j].FechaIng);
        System.Console.WriteLine("Jubilacion en: " + empleados[j].jubilacionEn() + " años");
        System.Console.WriteLine("Salario: " + empleados[j].Salario);
        System.Console.WriteLine("Adicional: " + empleados[j].Adicional);
        System.Console.WriteLine("Antiguedad: " + empleados[j].Antiguedad);
    }
    

enum Cargos {
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
partial class Empleado {
    private string nombre, apellido;
    private DateTime fechaNac, fechaIng;

    private char estadoCivil, genero;
    private double sueldoBasico;
    private Cargos cargo;

    public string Nombre { 
        get {
            return nombre;
        } set {
            nombre = value;
        }
    }

    public string Apellido { 
        get {
            return apellido;
        } set {
            apellido = value;
        }
    }
    public DateTime FechaNac { 
        get {
            return fechaNac;
        } set {
            fechaNac = value;
            calcularEdad();
        }
    }

    public DateTime FechaIng{ 
        get {
            return fechaIng;
        } set {
            fechaIng = value;
            calcularAntiguedad();
        }
    }

    public char EstadoCivil {
        get{
            return estadoCivil;
        } set {
            estadoCivil = value;
        }
    }
    public char Genero {
        get{
            return genero;
        } set {
            genero = value;
        }
    }

    public Cargos Cargo {
        get{
            return cargo;
        } set {
            cargo = value;
        }
    }

    public double SueldoBasico {
        get {
            return sueldoBasico;
        } set{ 
            sueldoBasico = value;
        }
    }

   

 }

    partial class Empleado {
         private int antiguedad, edad;

        public void calcularAntiguedad() {
            this.antiguedad = DateTime.Today.AddTicks(-this.fechaIng.Ticks).Year - 1;
        }
        public int Antiguedad {
            get {
                return antiguedad;
            }
        }

        public void calcularEdad() {
            this.edad =  DateTime.Today.AddTicks(-this.FechaNac.Ticks).Year - 1;
        }
        public int Edad {
            get {
                return edad;
            } 

        }
        public int jubilacionEn() {
            if (genero == 'F')
            {
                return 60 - this.antiguedad;
            } else {
                return 65 - this.antiguedad;
            }
        }

        private double adicional;
        public void calcularAdicional() {
            
                    if (this.antiguedad <= 20)
                    {
                        
                        this.adicional = this.sueldoBasico * this.antiguedad/100;

                    } else {
                        this.adicional = this.sueldoBasico * 20/100;

                    }

                    if ((int)this.cargo == 2 || (int)this.cargo == 3)
                    {
                        this.adicional = this.adicional * 50/100;

                    }

                    if (this.estadoCivil == 'C')
                    {
                        this.adicional += 15000;
                    }
                }
        public double Adicional {
            get {
                calcularAdicional();
                return adicional;
            }

        }
        
        private double salario;
        
        public void calcularSalario() {
            this.salario = this.sueldoBasico + this.adicional;
        }
        public double Salario {
            get{
                calcularSalario();
                return salario;
            } 
        }

        

    }








 