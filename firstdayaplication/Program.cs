Console.WriteLine("Hello, World!");
Console.WriteLine(1 + 2);
Console.WriteLine("1+2");

string ad = "Berfin";
Console.WriteLine(ad);
int sayi1 = 10;
int sayi2 = 20;
Console.WriteLine(sayi1);
Console.WriteLine(sayi2);
Console.WriteLine("1. sayi" + sayi1);
Console.WriteLine("2. sayi" + sayi2);
// 2. yöntem string interpolation
Console.WriteLine($"1.sayi : {sayi1}");
//double veri tipi
double sayi3 = 25;
Console.WriteLine(sayi3);
// Boolean veri tipi
bool dogruluk = false;
Console.WriteLine(dogruluk);

int number1 = 20;
int number2 = 30;
int sum = number1 + number2;
Console.WriteLine($"{number1} + {number2} = {sum}");
int difference = number2 - number1;
Console.WriteLine($" {number2} - {number1} = {difference}");
int divide = number2 / number1;
Console.WriteLine($"{number2} / {number1}={divide}");
//ondalıklı sayıyla çalışılıyorsa int yerine double kullanılmalı
double divide2 = number1 / number2;
Console.WriteLine($"{number1} / {number2}={divide2}"); //çalışmaz tüm değerler double atanmalı
int multiply = number1 * number2;
Console.WriteLine($"{number1} x {number2}={multiply}");
//mod olarak da kullanılır bu sayıların bölümünden kalandır
// double kullanıldığında sayı ondalıklı olarak da kullanılabilir
int mod = number2 % number1;
Console.WriteLine($"{number2} % {number1}={mod}");
int num3 = 10;
int num4 = 20;
int num5 = 20;
Console.WriteLine($" {num3}, {num4} ten büyük müdür = {num3>num4}");
Console.WriteLine($" {num3}, {num4} ten küçük müdür ={num3 < num4}");
Console.WriteLine($" {num3}, {num4} e eşit midir ? = {num3 == num4}");
Console.WriteLine($" {num3}, {num4} e eşit değil midir ? = {num3 != num4}");
Console.WriteLine($" {num3}, {num4} ten büyük eşit midir ? = {num3 >= num4}");
Console.WriteLine($" {num3}, {num4} ten küçük eşit midir ? = {num3 <= num4}");


Console.WriteLine(" Lütfen adınızı girin :");
string name = Console.ReadLine();
Console.WriteLine(" Lütfen soyadınızı girin :");
string surname = Console.ReadLine();
Console.WriteLine($" Adınız: {name}, Soyadınız: {surname}");


Console.WriteLine(" 1. sayısı giriniz. :");
int topla1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" 2. sayıyı giriniz. ;");
int topla2 = Convert.ToInt32(Console.ReadLine());
int toplam = topla1 + topla2;
Console.WriteLine("2 sayının toplamı= " + toplam);
string deger1 = "Örnek yazı";
string deger2 = "Örnek değer açıklaması";

string sonuc = deger1 + " " + deger2;
Console.WriteLine(sonuc);

int deger4 = 4;
int deger5 = 5;
int degerlerSonucu = deger4 + deger5;
Console.WriteLine("iki sayının toplamı : ", degerlerSonucu); // virgül bırakman lazım yoksa değeri atamaz




