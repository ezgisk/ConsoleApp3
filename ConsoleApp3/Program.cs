Console.WriteLine("Lutfen bir sayi giriniz:");
int number = int.Parse(Console.ReadLine());
if (number == 10)//Girilen sayinin 10 esit oldugu durum kontrolu

{
    Console.WriteLine("Girdiginiz sayi 10 esittir.");


}
else if (number < 10) //Girilen sayinin 10 kucuk oldugu durum kontrolu
{
    Console.WriteLine("Girdiginiz sayi 10'dan kucuktur");

}
else//Girilen sayinin 10 buyuk oldugudu durum kontrolu
{
    Console.WriteLine("Girdiginiz sayi 10'dan buyuktur");

}
//Girilen sayinin cift mi tek mi oldugunu kontrol eden if/else
if (number % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}