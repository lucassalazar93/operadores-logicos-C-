// See https://aka.ms/new-console-template for more information
<<<<<<< HEAD
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

=======


var (valor1, valor2, valor3) = (true, true, false);

bool resultAnd = valor1 && valor2 && valor3;
Console.WriteLine(resultAnd);

bool resultOr = valor1 || valor2 || valor3;
Console.WriteLine(resultOr);


bool resultAndOr = (valor1 && valor2) || valor3; // si tienes las dos primeras da true, si no, da el valor de la tercera
Console.WriteLine(resultAndOr);

bool resultNot = !valor1; // operador de negacion
Console.WriteLine(resultNot);

bool resultXor = valor1 ^ valor2 ^ valor3; // operador exclusivo, da true si son diferentes
Console.WriteLine(resultXor); 
>>>>>>> b0b1389685812054a974dee02f1587ff6fdc6e36
