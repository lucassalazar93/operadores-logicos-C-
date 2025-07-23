// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var (valor1, valor2, valor3) = (10, 9, 30);
Console.WriteLine("los valores son:" + valor1 + " " + valor2 + " " + valor3);

/*
== igual a 
!= diferente a
> mayor que
< menor que
<= menor o igual
*/


bool resultado1 = valor1 == valor2;
Console.WriteLine("El resultado de la comparacion valor1 == valor2 es: " + resultado1);

bool resultado2 = valor1 != valor2;
Console.WriteLine("El resultado de la comparacion valor1 != valor2 es: " + resultado2);

bool resultado3 = valor1 > valor2;
Console.WriteLine("El resultado de la comparacion valor1 > valor2 es: " + resultado3);

bool resultado4 = valor1 < valor2;
Console.WriteLine("El resultado de la comparacion valor1 < valor2 es: " + resultado4);

bool resultado5 = valor1 <= valor2;
Console.WriteLine("El resultado de la comparacion valor1 <= valor2 es: " + resultado5);

