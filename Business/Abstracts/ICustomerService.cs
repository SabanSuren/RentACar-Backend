using Core.Utilities.Results.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetById(int customerId);

        IDataResult<List<Customer>> GetAll();


        IResult AddCustomer(Customer customer);

        IResult DeleteCustomer(Customer customer);

        IResult UpdateCustomer(Customer customer);



        IDataResult<List<Customer>> GetAllByUserId(int id);
    }
}
