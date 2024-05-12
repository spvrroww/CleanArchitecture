using SchoolManagementApp.Domain.Primitives;

namespace SchoolManagementApp.Domain.Entities;

public class School : Entity
{
    public School()
    {
        
    }

    public School(string name, string country, string stateorCity, string address)
    {
        Name = name;
        Country = country;
        StateorCity = stateorCity;
        Address = address;
    }

    public string Name { get; private set; }
    public string Country { get; private set; }
    public string StateorCity { get; private set; }
    public string Address { get; private set; }
}