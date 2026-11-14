Console.Write("Gun giriniz: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("Ay giriniz: ");
int month = Convert.ToInt32(Console.ReadLine());
Console.Write("Yıl giriniz: ");
int year = Convert.ToInt32(Console.ReadLine());
int maxGun = 0;

switch (month)
{
    case 4: case 6: case 9: case 11:
        maxGun = 30;
        break;
    case 1 : case 3: case 5: case 7: case 8: case 10: case 12:
        maxGun = 31;
        break;
    case 2 : 
        if(year%400==0 || year%4==0&&

              

}





