//using Business.Concretes;
//using Business.Constants;
//using DataAccess.Concretes.EntityFramework;
//using Entities.Concretes;
//using System;

//namespace UIConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //UserTEST();

//            //BrantADDTEST();


//            //UserAddTest();


//            //CustomerAddTEST();

//            RentalAddTEST();

//            //RentalDetailTEST();

//        }

//        private static void RentalDetailTEST()
//        {
//            RentalManager rentalManager = new RentalManager(new EfRentalDal());

//            var result = rentalManager.GetRentalDetails();

//            if (result.Success == true)
//            {
//                foreach (var rental in rentalManager.GetRentalDetails().Data)
//                {
//                    Console.WriteLine(rental.CustomerName + " / " + rental.UserId);
//                }


//            }
//        }

//        private static void RentalAddTEST()
//        {
//            RentalManager rentalManager = new RentalManager(new EfRentalDal());

//            try
//            {
//                rentalManager.AddRental(new Rental
//                {
//                    RentalId = 2,

//                    CarId = 2,

//                    CustomerId = 2,

//                    RentDate = DateTime.Now,

//                    //ReturnDate = new DateTime(2023, 11, 16, 5, 50, 6)

//                });

//            }
//            catch (Exception)
//            {

//                throw;
//            }
//        }

//        private static void UserAddTest()
//        {
//            UserManager userManager = new UserManager(new EfUserDal());

//            try
//            {
//                userManager.AddUser(new User
//                {
//                    UserId = 3,
//                    FirstName = "Süren",
//                    LastName = "Şaban",
//                    Email = "dsfdsfsdf",
//                    Password = "123456789"


//                });

//            }
//            catch (DuplicateWaitObjectException exception)
//            {

//                Console.WriteLine(Messages.Addet);
//            }
//        }

//        private static void CustomerAddTEST()
//        {
//            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

//            try
//            {
//                customerManager.AddCustomer(new Customer
//                {
//                    CustomerId = 3,
//                    CustomerName = "Süren Şaban",
//                    CustomerEmail = "dasdasdas",
//                    CompanyName = "asdasdasd",
//                    CustomerCity = "Ankara",
//                    UserId = 3,
//                    CustomerPhone = "4465454564"
                   
//                });
//            }
//            catch (DuplicateWaitObjectException exception)
//            {

//                Console.WriteLine(exception.Message);
//            }
//        }

//        private static void BrantADDTEST()
//        {
//            BrandManager brandManager = new BrandManager(new EfBrandDal());






//            try
//            {
//                brandManager.AddBrand(new Brand
//                {
//                    BrandId = 10,
//                    BrandName = "TOFAŞ"

//                });

//            }
//            catch (DuplicateWaitObjectException exception)
//            {

//                Console.WriteLine(exception.Message);
//            }
//        }

//        private static void UserTEST()
//        {
//            UserManager userManager = new UserManager(new EfUserDal());


//            foreach (var user in userManager.GetAll().Data)
//            {
//                Console.WriteLine(user.FirstName);
//            }
//        }

//        //foreach (var brand in brandManager.GetAll())
//        //{
//        //    Console.WriteLine(brand.BrandName);
//        //}

//        //Console.WriteLine(brandManager.GetById(1).BrandName);

//        //foreach (var color in colorManager.GetAll())
//        //{
//        //    Console.WriteLine(color.ColorName);
//        //}

//        //foreach (var car in carManager.GetAll())
//        //{
//        //    Console.WriteLine(car.CarName);
//        //}

//        //Console.WriteLine(carManager.GetById(1).CarName);

//        //try
//        //{
//        //    carManager.Add(new Car
//        //    {
//        //        CarId = 4,
//        //        CarName = "BMW Q5",
//        //        BrandId = 4,
//        //        ColorId = 5,
//        //        DailyPrice =1500,
//        //        Description = "Çok Güzel",
//        //        ModelYear = new DateTime(2023, 5, 16, 5, 50, 6)
//        //    });
//        //}
//        //catch (DuplicateWaitObjectException exception)
//        //{
//        //    Console.WriteLine(exception.Message);

//        //}

//        //foreach (var car in carManager.GetByDailyPrice(1850,2000))
//        //{
//        //    Console.WriteLine(car.CarName);
//        //}
//    }
//}
