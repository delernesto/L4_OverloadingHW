using System;

public class TestRunner
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Running tests for Employee class ---");
        TestEmployee();

        Console.WriteLine("\n--- Running tests for City class ---");
        TestCity();

        Console.WriteLine("\n--- Running tests for CreditCard class ---");
        TestCreditCard();
    }

    public static void TestEmployee()
    {
        Employee emp1 = new Employee("Alex", 30, 50000m);
        Employee emp2 = new Employee("Maria", 25, 60000m);
        Employee emp3 = new Employee("John", 45, 50000m);

        Console.WriteLine($"Salary of {emp1.Name}: {emp1.Salary}");
        emp1 += 5000m;
        Console.WriteLine($"Salary of {emp1.Name} after bonus: {emp1.Salary}");

        Console.WriteLine($"Salary of {emp2.Name}: {emp2.Salary}");
        emp2 -= 15000m;
        Console.WriteLine($"Salary of {emp2.Name} after deduction: {emp2.Salary}");

        try
        {
            emp2 -= 100000m;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nException successfully caught: {ex.Message}");
        }

        Console.WriteLine($"\nSalary comparison:");
        Console.WriteLine($"Is {emp1.Name}'s salary greater than {emp2.Name}'s? {emp1 > emp2}");
        Console.WriteLine($"Is {emp1.Name}'s salary less than {emp2.Name}'s? {emp1 < emp2}");
        Console.WriteLine($"Is {emp1.Name}'s salary equal to {emp3.Name}'s? {emp1 == emp3}");
        Console.WriteLine($"Is {emp1.Name}'s salary not equal to {emp2.Name}'s? {emp1 != emp2}");
    }

    public static void TestCity()
    {
        City kyiv = new City("Kyiv", 2960000);
        City lviv = new City("Lviv", 724000);
        City kharkiv = new City("Kharkiv", 2960000);

        Console.WriteLine($"Population of {kyiv.Name}: {kyiv.Population}");
        kyiv += 40000;
        Console.WriteLine($"Population of {kyiv.Name} after increase: {kyiv.Population}");

        Console.WriteLine($"Population of {lviv.Name}: {lviv.Population}");
        lviv -= 24000;
        Console.WriteLine($"Population of {lviv.Name} after decrease: {lviv.Population}");

        try
        {
            lviv -= 10000000;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nException successfully caught: {ex.Message}");
        }

        Console.WriteLine($"\nPopulation comparison:");
        Console.WriteLine($"Is {kyiv.Name}'s population greater than {lviv.Name}'s? {kyiv > lviv}");
        Console.WriteLine($"Is {kyiv.Name}'s population less than {lviv.Name}'s? {kyiv < lviv}");
        Console.WriteLine($"Is {kyiv.Name}'s population equal to {kharkiv.Name}'s? {kyiv == kharkiv}");
        Console.WriteLine($"Is {kyiv.Name}'s population not equal to {lviv.Name}'s? {kyiv != lviv}");
    }

    public static void TestCreditCard()
    {
        CreditCard card1 = new CreditCard("1234-5678-9012-3456", 1500m);
        CreditCard card2 = new CreditCard("9876-5432-1098-7654", 500m);
        CreditCard card3 = new CreditCard("1234-5678-9012-3456", 1500m);

        Console.WriteLine($"Card 1 info: {card1}");
        card1 += 200m;
        Console.WriteLine($"Card 1 balance after deposit: {card1.Balance}");

        Console.WriteLine($"\nCard 2 info: {card2}");
        card2 -= 300m;
        Console.WriteLine($"Card 2 balance after withdrawal: {card2.Balance}");

        try
        {
            card2 -= 1000m;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nException successfully caught: {ex.Message}");
        }

        Console.WriteLine($"\nBalance comparison:");
        Console.WriteLine($"Is Card 1's balance greater than Card 2's? {card1 > card2}");
        Console.WriteLine($"Is Card 1's balance less than Card 2's? {card1 < card2}");

        Console.WriteLine($"\nObject comparison:");
        Console.WriteLine($"Are card1 and card3 equal? {card1 == card3}");
        Console.WriteLine($"Are card1 and card2 not equal? {card1 != card2}");
    }
}