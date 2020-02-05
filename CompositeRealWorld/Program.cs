using System;

namespace CompositeRealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));
            CompositeElement comp =
                new CompositeElement("Two circles");
            comp.Add(new PrimitiveElement("Black circle"));
            comp.Add(new PrimitiveElement("White circle"));
            root.Add(comp);
            PrimitiveElement pe = new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);
            root.Display(1);
            Console.ReadKey();
        }
    }
}
