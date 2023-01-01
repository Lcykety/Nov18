using Nov18;

 static Kare karekle(sekil s1)
{
    Kare kare = new Kare();
    kare.x = s1.x - 20;
    kare.y = s1.y;

    return kare;
}
static void main(String[] args)
{
    sekil[] sekiller = new sekil[10];
    sekiller[0] = new üçgen();
    sekiller[0].x = 50;
    sekiller[0].y = 70;

    sekiller[1] = new Kare();
    sekiller[1].x = 40;
    sekiller[1].y = 40;


    sekiller[2] = new paralelkenarcs();
    sekiller[2].x = 30;
    sekiller[2].y = 10;

    sekiller[3] = new yamuk();
    sekiller[3].x = 90;
    sekiller[3].y = 80;

    sekiller[3] = new üçgen();
    sekiller[3].x = 70;
    sekiller[3].y = 30;
    for (int i = 0; i < 4; i++)
    {
        sekiller[5 + i] = karekle(sekiller[i]);
    }
    for (int i = 0; i < 9; i++)
    {
        if (sekiller[i] is üçgen)
        {
            Console.WriteLine("BU BİR ÜÇGENDİR");
            sekiller[i].print();
        }
        else if (sekiller[i] is Kare)
        {
            Console.WriteLine("BU BİR KAREDİR");
            sekiller[i].print();
            if (i >= 5 ) {
                Console.WriteLine("bu bir üretilmiş kardeir");
                Console.WriteLine("KARENİN ALANI = "+(sekiller[i].x/2*5));
            }
        }
        else if (sekiller[i] is paralelkenarcs)
        {
            Console.WriteLine("BU BİR PARALELKENARDIR");
            sekiller[i].print();
        }
        
    }
  
}