
//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

int i = 0;

while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}

Console.WriteLine("-------------------------------------------------------------------------");

//2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

int j = 1;

while (j < 21)
{

    Console.WriteLine(j);
    j++;
}

Console.WriteLine("-------------------------------------------------------------------------");

//3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

int i = 1;

while (i < 21)
{

    if (i % 2 == 0)
    {
        Console.WriteLine(i);

    }

    i++;
}

Console.WriteLine("-------------------------------------------------------------------------");

//4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int i = 50;

int toplam = 0;

while (i < 151)

{

    toplam += i;
    i++;

}

Console.WriteLine(toplam);


Console.WriteLine("-------------------------------------------------------------------------");

//-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int i = 1;

int tekToplam = 0;

int ciftToplam = 0;

while (i < 121)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
        i++;
    }
    else
    {
        tekToplam += i;
        i++;
    }
}
Console.WriteLine(ciftToplam);
Console.WriteLine(tekToplam);