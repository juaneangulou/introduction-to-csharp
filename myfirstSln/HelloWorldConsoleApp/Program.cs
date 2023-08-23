using HelloWorldConsoleApp;

public static class MyFisrtConsoleApp{

    public static void Main()
    {
        var person= GetPerson();
        Console.WriteLine($"Hola {person.Name} tienes {person.Age} años");
    }

    public static PersonModel GetPerson()
    {
        var person= new PersonModel();
        person.Name = "Jhon";
        person.Age = 18;

        return person;
    }

}