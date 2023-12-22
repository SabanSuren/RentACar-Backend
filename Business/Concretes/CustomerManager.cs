using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CustomerManager : ICustomerService
    {

        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public IResult AddCustomer(Customer customer)
        {
            _customerDal.Add(customer);

            return new SuccessResult(Messages.Addet);
        }

        public IResult DeleteCustomer(Customer customer)
        {
            _customerDal.Delete(customer);
           return new SuccessResult(Messages.Delete);    
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll()); 
        }

        public IDataResult<List<Customer>> GetAllByUserId(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c=>c.UserId==id)); 
        }

        public IDataResult<Customer> GetById(int customerId)
        {
           return new SuccessDataResult<Customer>(_customerDal.Get(c=>c.CustomerId == customerId));
        }

        public IResult UpdateCustomer(Customer customer)
        {
            _customerDal.Update(customer);

            return new SuccessResult(Messages.Update);
        }
    }
}
