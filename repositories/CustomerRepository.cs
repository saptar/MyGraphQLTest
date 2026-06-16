using System;
using MyGraphQLDemo.models;

namespace MyGraphQLDemo.repositories;

public class CustomerRepository
{


    private List<Customer> _customers = new()
    {
        new Customer
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Phone = "123-456-7890",
            Address = "123 Main St",
            City = "Anytown",
            State = "CA",
            ZipCode = "12345",
            Country = "USA"
        },
        new Customer
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Smith",
            Email = "jane.smith@example.com",
            Phone = "098-765-4321",
            Address = "456 Oak Ave",
            City = "Somewhere",
            State = "NY",
            ZipCode = "67890",
            Country = "USA"
        }
    };

    public IEnumerable<Customer> GetAllCustomers()
    {
        return _customers;
    }
}
