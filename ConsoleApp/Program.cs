
using L01;
using MyLibrary;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hej");
Person person = new Person("Rasmus");
Console.WriteLine(person.Fornavn);

MyList myList = new MyList();
myList.addNumber(3);
myList.addNumber(1);
myList.addNumber(13);
myList.addNumber(7);

myList.printList();

Person p1 = new Person("Martin");
Console.WriteLine(p1);
p1.Fornavn = "Benny";
Console.WriteLine(p1);

var fido = new Animal("dog");
Console.WriteLine("Is fido a dog?" + fido.isDog());