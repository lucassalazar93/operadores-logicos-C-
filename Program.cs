﻿// See https://aka.ms/new-console-template for more information


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