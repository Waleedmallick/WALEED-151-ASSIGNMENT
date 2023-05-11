using Microsoft.AspNetCore.Mvc;
using Resturant_System.Model;

namespace Zasham_Enterprises.Controllers
{
    public class Customer_Controller : Controller
    {
        private readonly CustomerDB_Context _customerDB_Context;

        public Customer_Controller(CustomerDB_Context customerDB_Context)
        {
            _customerDB_Context = customerDB_Context;
        }

        [HttpPut("CustomerData")]
        public IActionResult SaveCustomerData([FromBody] Customer customer)
        {
            _customerDB_Context.customer.Add(customer);
            _customerDB_Context.SaveChanges();
            
            return Ok();
        }

        [HttpGet("CustomerDataView")]
        public IEnumerable<Customer> GetCustomers()
        {

            return _customerDB_Context.customer;

        }


    }
}
