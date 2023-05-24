namespace HomeWork1;

class Program
{
    static void Main(string[] args)
    {
        CheckValue();
        /*GetDataStudent();*/
        Console.ReadLine();
    }

    static void GetDataStudent()
    {
        Console.WriteLine("Введите Имя");
        string Name = Console.ReadLine();
        Console.WriteLine("Введите Фамилию");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Введите Возраст");
        int Age = CheckValue();
        Console.WriteLine("Есть ли у вас питомец");
        string Pet = Console.ReadLine();
        var StudentPets = Pets(Pet);
        Console.WriteLine("Количество любимых цветов");
        int Color = CheckValue();
        var StudentColors = Colors(Color);
        var DataStudent = (Name, FirstName, Age, StudentPets, StudentColors);

        ShowDataStudent();
    }
    static void ShowDataStudent()
    {



    }
    static string[] Pets(string Pet)
    {
        if (Pet == "Да")
        {
            Console.WriteLine("Сколько?");
            int PetCount = CheckValue();
            string[] Pets = new string[PetCount];
            for (int i = 0; i < PetCount; i++)
            {
                Console.WriteLine($"Кличка {i + 1} питомца");
                Pets[i] = Console.ReadLine();
            }
            return Pets;


        }
        else
        {
            Console.WriteLine("очень жаль");
            string[] Pets = new string[] { "Питомцев нет" };
            return Pets;
        }
    }
    static string[] Colors(int ColorCount)
    {
        string[] Colors = new string[ColorCount];
        for (int i = 0; i < ColorCount; i++)
        {
            Console.WriteLine($"Ваш {i + 1} любимый цвет");
            Colors[i] = Console.ReadLine();
        }
        return Colors;

    }

    static int CheckValue()
    {
        Console.WriteLine("значение");
        string? input = Console.ReadLine();
        bool result = int.TryParse(input, out var number);
        while (!result)
        {
            Console.WriteLine("Значение не число");
        }
        /*if (result == true)
            Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
        else
            Console.WriteLine("Преобразование завершилось неудачно");

        int Value = Convert.ToInt32(Console.ReadLine());
        if (Value > 0)
        {
            return Value;

        }
        else
        {
            Console.WriteLine("Значение должно быть больше 0");
            return CheckValue();
        }*/
    }

}
