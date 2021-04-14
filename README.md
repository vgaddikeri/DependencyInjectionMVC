# DependencyInjectionMVC

Implementation using .NET MVC
To implement dependency injection in MVC, I have used the container framework Unity.Mvc5.
The dependency mappings are registered in RegisterComponents () method in Unity.Config class, which is installed with the framework. The default route is set to CustomerController, GetCustomer () method.


The CustomerController class constructor takes interface variable as parameter to initialize the private member. ICustomerService is mapped to CustomerService concrete class and hence the CustomerService class gets initialized.
CustomerService class accepts ICustomerRepository, an interface variable mapped to CustomerRepository concrete class.This CustomerRepository class returns the data in JSON format, which can be read with either Postman or Fiddler.
