internal class Employee
{
   
    public string Name { get; private set; }

    
    public int Age { get; private set; }

    
    private decimal _salary;

   
    public decimal Salary
    {
        get { return _salary; }
        set
        {
            if (value >= 0)
            {
                _salary = value;
            }
            else
            {
                throw new ArgumentException("Salary cannot be negative.");
            }
        }
    }

   
    public Employee(string name, int age, decimal salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

 

    
    public static Employee operator +(Employee emp, decimal bonus)
    {
        emp.Salary += bonus;
        return emp;
    }

    
    public static Employee operator -(Employee emp, decimal deduction)
    {
       
        if (emp.Salary - deduction < 0)
        {
            throw new ArgumentException("Resulting salary cannot be negative.");
        }
        emp.Salary -= deduction;
        return emp;
    }

    
    public static bool operator >(Employee emp1, Employee emp2)
    {
        return emp1.Salary > emp2.Salary;
    }

    public static bool operator <(Employee emp1, Employee emp2)
    {
        return emp1.Salary < emp2.Salary;
    }

    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, emp2))
        {
            return true;
        }

        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
        {
            return false;
        }

        return emp1.Salary == emp2.Salary;
    }

    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Employee otherEmployee)
        {
            return false;
        }
        return this == otherEmployee;
    }

    public override int GetHashCode()
    {
        return Salary.GetHashCode();
    }
}
