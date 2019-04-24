

using System;

class Program
{

    private static string resultado ="Hola CSharp";

    static void Main(string[] args)
    {
        int dato;
        string dato0;
        bool dato1;

        //Tupla
        (dato, dato0, dato1) = metodoUno();

        (long dato2, bool dato3) data = metodoDos();

        Console.WriteLine(data.dato2);
        Console.WriteLine(data.dato3);
        saludar();
        resultado = "Hola Noah";
        saludar();
        Console.ReadLine();

    }

    static (int, string, bool) metodoUno()
    {
        return (0,"Dato",false);
    }

    static (long, bool) metodoDos() => (22, true);
    
    static string metodoTres() => "Hola Mundo";
        
    static void saludar() => Console.WriteLine(resultado);
}

