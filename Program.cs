
Console.WriteLine("Comparacion y validacion de cadenas!\n\n\n");
////Vamos a ver una parte importante de  los Strings, comparacion y validacion con funciones
////ya integradas en C#

//String miVariableString = string.Empty;   //Podemos pensar q la inicicializacion "" es igual a Empty pero no es asi

//miVariableString = "Mi cadena a mostrar en pantalla";

//Console.WriteLine($"Paso 1: {miVariableString}");

//var separacionPorEspacio = miVariableString.Split(' '); //esto nos devuelve un array

//foreach (var item in separacionPorEspacio)
//{
//    Console.WriteLine($"Paso 2: {item}");
//}

////  Ahora veamos  como buscar cadenas, podemos usar equals o contains
//Console.WriteLine("\n\n\n");
//var miString = "Esta es la fuente de strings q usaremos para buscar palabras";

//var encuentraStrings = miString.Contains("string");

//Console.WriteLine($"Encontro 'strings': {encuentraStrings}\n\n\n");

//encuentraStrings = miString.Contains("String");//Es sencible a mayusculas y minusculas

//Console.WriteLine($"Encontro 'strings': {encuentraStrings}");

////Usaremos equals

//var miString = "Mi variable";

//var comparaigual = miString.Equals("Mi variable");

//Console.WriteLine($"Son iguales los Strings: {comparaigual}");

//var comparaStrings = string.Compare(miString, "Mi Variable", true);

////String.compare es muy util cuando deseas comparar valores sin importar si son mayusculas o minusculas
////o viceversa

//Console.WriteLine($"Usando Compare son iguales: {comparaStrings}");


//var comparaStrings2 = string.Compare(miString, "Mi Variable", StringComparison.OrdinalIgnoreCase);


//Console.WriteLine($"Usando Compare son iguales: {comparaStrings2}");


//  Ahora veamos como se usa el padleft y padright, es para rellenar lso espacios

var miStrins = "Homa mundo";

Console.WriteLine(miStrins.PadLeft(20, '-'));


Console.WriteLine(miStrins.PadRight(20, '-'));
Console.WriteLine();
Console.WriteLine();
//  ahora veamos como se usa el @ para usar nombres de funciones o nombres reservados en C#

var @string = "Quiero usar string como variable";

Console.WriteLine($"Anteponemos la @ para poder usar ese nombre reservado {@string}");

var @for = "Esta es mi nueva variable";


Console.WriteLine(@for);

//Estos tips y trucos pueden ahorrar mucho tiempo


Console.WriteLine("\n\n\n\n");