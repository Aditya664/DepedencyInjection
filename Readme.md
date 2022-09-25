### What is Dependency Injection ?


    * Dependency Injection (DI) is a software pattern.
    * In C#, Dependency Injection is basically providing the objects that an object needs, instead of * having it construct the objects themselves.
    * DI is a technique whereby one object supplies the dependencies of another object.
    * With the help of DI, we can write loosely coupled code.
    * DI is achieved by writing loosely couple code.
    * A loosely-coupled code is a code where all your classes can work independently without relying on each other.`

### Types of Depedency Injection 


    * 1) Constructor Injection
    * 2) Setter or Property Injection
    * 3) Method Injection

### Di Using constructor injection

    Constructor injection is nothing but the process of injecting dependent class object through the constructor.

### Dependency Injection Using Property injection in C#



    * Dependency Injection is basically providing the objects that an object needs, instead of having * it construct the objects themselves.
    * Setter or property injection is injecting dependent class object through the property.
    * So setter or property injection means, injecting SavingAccount & CurrentAccount class objects in 
    * Account class using propert

### Dependency Injection Using METHOD injection in c#


    * Method Injection is injecting dependent class object through a class method.
    * What is mean by this?
    * In the given example, Account class has a dependency on SavingAccount and CurrentAccount classes.
    * So the method Injection means, injecting SavingAccount & CurrentAccount class objects directly * into the Account class method using interface.