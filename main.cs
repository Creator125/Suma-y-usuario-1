using System;

class MainClass {
  public static void Main (string[] args) {
    int a,b,c;

    Console.WriteLine("Ingrese los valores para la suma");
    
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
   
    c = a + b;

   Console.WriteLine("El resultado de tu suma es: "+ c);

  Console.WriteLine("El resultado del metodo es: "+ Producto(a,b));

  }

  public static int Producto (int num1, int num2){
    int resultado =0;
    return num1 * num2;
  }
}