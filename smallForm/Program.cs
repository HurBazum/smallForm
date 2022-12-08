string myName = null;
byte myAge = 0;
bool beingPet = false;
float footSize = 0;

GetAnswers(myName, myAge, beingPet, footSize);

static void GetAnswers(string s, byte by, bool bo, float fl)
{
    Console.Write("Как Вас зовут? ");
    s = Console.ReadLine();
    Console.Write("Сколько Вам лет? ");
    by = byte.Parse(Console.ReadLine());
    Console.Write("Есть ли у Вас питомец?(н/д) ");
    if (Console.ReadLine() == "н")
    {
        bo = false; 
    }
    else
    {
        bo = true;
    }
    Console.Write("Какой у Вас размер ноги? ");
    fl = float.Parse(Console.ReadLine());
}
