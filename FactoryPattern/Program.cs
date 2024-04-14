using FactoryPattern;

Console.WriteLine("Hello, World!");

ProductFactory factory = new();

IProduct productA = factory.CreateProduct("A");
productA.Operation();


IProduct productB = factory.CreateProduct("B");
productB.Operation();