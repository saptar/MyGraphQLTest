using System;
using MyGraphQLDemo.models;
using MyGraphQLDemo.repositories;

namespace MyGraphQLDemo.Queries;

public class CustomerQuery
{
    public IEnumerable<Customer> GetCustomers([Service] CustomerRepository customerRepository)
    {
        return customerRepository.GetAllCustomers();
    }

}
