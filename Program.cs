using ConsoleLessons;

public class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("","","","");
        Console.WriteLine("Введите Имя:");
        user1.Name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите Фамилию:");
        user1.LastName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите Отчество:");
        user1.MiddleName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Расскажите о себе:");
        user1.Description= Convert.ToString(Console.ReadLine());


        user1.Print();

    }
}