using System;

class MainClass {
  public static void Main (string[] args) {
  double num1,num2,num3;
  Console.WriteLine("Primer numero: ");
  num1=Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Segundo numero: ");
  num2=Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("Tercer numero: ");
  num3=Convert.ToDouble(Console.ReadLine());
    if(num1>num2&&num1<num3);
    Console.WriteLine("El intermedio es: {0}" ,num1);
    if(num1<num2&&num1>num3);
    Console.WriteLine("El intermedio es: {0}" ,num1);
    if(num2<num1&&num2>num3);
    Console.WriteLine("El intermedio es: {0}" ,num2);
    if(num2>num1&&num2<num3);
    Console.WriteLine("El intermedio es: {0}" ,num2);
    if(num3<num1&&num3>num2);
    Console.WriteLine("El intermedio es: {0}" ,num3);
    if(num3>num1&&num3<num2);
    Console.WriteLine("El intermedio es: {0}" ,num3);
    
  }
}