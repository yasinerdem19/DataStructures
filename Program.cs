// See https://aka.ms/new-console-template for more information
//value&reference types

int sayi1 = 1,  sayi2 = 2;
string string1 = "1 ", string2 = "2 ";
string[] dizi1 = { "11111", "2222", "Elephant" };
string[] dizi2 ;

sayi2 = sayi1;
string2 = string1;
dizi2 = dizi1;


Console.WriteLine(sayi1 + "" + sayi2);
Console.WriteLine(string1 + "" + string2);
Console.WriteLine(dizi1[0] + dizi2[0]);


sayi1 = 9;
string1 = "99";
dizi1[0] = "qqqq";


Console.WriteLine(sayi1 + "" + sayi2);
Console.WriteLine(string1 + "" + string2);
Console.WriteLine(dizi1[0] + dizi2[0]);

