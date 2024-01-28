using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Customers;
    public int Id { get; set; };
    public decimal Balance { get; set; };
    public string Name { get; set; };
    public int AccountNumber { get; set; };

    public Customers (int id, decimal balance, string name, int accountNumber)
    {
        Id = id;
        Balance = balance;
        Name = name;
        AccountNumber = accountNumber;
    }
}
