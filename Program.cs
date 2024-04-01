// See https://aka.ms/new-console-template for more information

//birden başa konsoldan girilen sayıya kadar yazdır:

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ---------- ");


int number1 = 1;
while (number1 <= number)
{
    Console.WriteLine(number1);
    number1++;
}

//birden başlayıp girilen sayıya kadar olan sayıların ortalamsını hesapla:

Console.WriteLine("Enter a number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int start = 1;
int sum = 0;

while (start <= number2)
{
    sum = sum + start;
    start++;
}
int average = sum / number2;
Console.WriteLine("Average: "+average);


// a dan z ye kadar olan harfleri konsola yazdıralım:

char character = 'a';
while (character <= 'z')
{
    Console.Write(character + " ");
    character++;
}

Console.WriteLine();
// diziden eleman yazdırma 
string[] cars = { "BMW", "Porsche", "Mercedes", "Skoda" };
foreach (var car in cars)
{
    Console.WriteLine(car);
}