
using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Burçin";
person1.LastName = "Aksu";
person1.DateOfBirthYear = 1990;
person1.NationalIdentity = 38362590556;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
