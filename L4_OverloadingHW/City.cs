internal class City
{

    public string Name { get; private set; }


    private int _population;


    public int Population
    {
        get { return _population; }
        set
        {
            if (value >= 0)
            {
                _population = value;
            }
            else
            {
                throw new ArgumentException("Population cannot be negative.");
            }
        }
    }


    public City(string name, int population)
    {
        Name = name;
        Population = population;
    }


    public static City operator +(City city, int populationIncrease)
    {
        city.Population += populationIncrease;
        return city;
    }


    public static City operator -(City city, int populationDecrease)
    {
        if (city.Population - populationDecrease < 0)
        {
            throw new ArgumentException("Resulting population cannot be negative.");
        }
        city.Population -= populationDecrease;
        return city;
    }


    public static bool operator >(City city1, City city2)
    {
        return city1.Population > city2.Population;
    }

    public static bool operator <(City city1, City city2)
    {
        return city1.Population < city2.Population;
    }


    public static bool operator ==(City city1, City city2)
    {
        if (ReferenceEquals(city1, city2))
        {
            return true;
        }

        if (ReferenceEquals(city1, null) || ReferenceEquals(city2, null))
        {
            return false;
        }

        return city1.Population == city2.Population;
    }

    public static bool operator !=(City city1, City city2)
    {
        return !(city1 == city2);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not City otherCity)
        {
            return false;
        }
        return this == otherCity;
    }

    public override int GetHashCode()
    {
        return Population.GetHashCode();
    }
}