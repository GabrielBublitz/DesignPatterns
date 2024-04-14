namespace FactoryPattern
{
    internal interface IProduct
    {
        void Operation();
    }

    class ConcreteProductA : IProduct
    {
        public void Operation() 
        {
            Console.WriteLine("Operation of ConcreteProductA");
        }
    }

    class ConcreteProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operation of ConcreteProductB");
        }
    }

    class ProductFactory
    {
        public IProduct CreateProduct(string type)
        {
            if(type == "A")
            {
                return new ConcreteProductA();
            }
            else if (type == "B")
            {
                return new ConcreteProductB();
            }
            else
            {
                throw new ArgumentException("Invalid product type");
            }
        }
    }
}
