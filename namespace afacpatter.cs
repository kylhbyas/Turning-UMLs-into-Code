/// Kyle Byassee
/// 2023-02-03
/// 
/// This program loops over the manufacturers and prints their phones to the screen.
/// 

namespace afacpatter
{
    // The manufacturers are listed here for iteration later.
    enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA,
    }

    // The base interface. The methods are defined so the derived interfaces dont have to overwrite both methods.
    interface IPhoneFactory
    {
        public ISmart? GetSmart()
        {
            return null;
        }

        public IDumb? GetDumb()
        {
            return null;
        }
    }

    // Inherits from IPhoneFactory and declares one additional method.
    interface ISmart : IPhoneFactory
    {
        public string getName();
    }

    // Implements the ISmart interface. Returns its name as a string
    class Lumia : ISmart
    {
        private string name = "Lumia";

        public string getName()
        {
            return name;
        }
    }

    // Implements the ISmart interface. Returns its name as a string
    class GalaxyS2 : ISmart
    {
        private string name = "GalaxyS2";

        public string getName()
        {
            return name;
        }
    }

    // Implements the ISmart interface. Returns its name as a string
    class Titan : ISmart
    {
        private string name = "Titan";

        public string getName()
        {
            return name;
        }
    }

    // Inherits from IPhoneFactory and declares one additional method
    interface IDumb : IPhoneFactory
    {
        public string getName();
    }

    // Implements the IDumb interface. Returns its name as a string
    class Asha : IDumb
    {
        private string name = "Asha";

        public string getName()
        {
            return name;
        }
    }

    // Implements the IDumb interface. Returns its name as a string
    class Genie : IDumb
    {
        private string name = "Genie";

        public string getName()
        {
            return name;
        }
    }

    // Implements the IDumb interface. Returns its name as a string
    class Primo : IDumb
    {
        private string name = "Primo";

        public string getName()
        {
            return name;
        }
    }

    // Implements base interface. Returns their smart or dumb phones
    class SamsungFactory : IPhoneFactory
    {
        public ISmart? GetSmart()
        {
            GalaxyS2 s2 = new GalaxyS2;
            return s2;
        }

        public IDumb? GetDumb()
        {
            Primo primo = new Primo;
            return primo;
        }
    }

    // Implements base interface. Returns their smart or dumb phones
    class HTCFactory : IPhoneFactory
    {
        public ISmart? GetSmart()
        {
            Titan titan = new Titan;
            return titan;
        }

        public IDumb? GetDumb()
        {
            Genie genie = new Genie;
            return genie;
        }
    }

    // Implements base interface. Returns their smart or dumb phones
    class NokiaFactory : IPhoneFactory
    {
        public ISmart? GetSmart()
        {
            Lumia lumia = new Lumia;
            return lumia;
        }

        public IDumb? GetDumb()
        {
            Asha asha = new Asha;
            return asha;
        }
    }

    // Checks the manu for each types of phones (smart and dumb) and writes them to the screen
    class PhoneTypeChecker
    {
        public IPhoneFactory? factory = null;
        public Manufacturers? manu = null;

        // Paramaterized Constructor
        public PhoneTypeChecker(Manufacturers m)
        {
            manu = m;
        }

        public void CheckProducts()
        {
            if(manu = Enum.SAMSUNG)
            {
                factory = new SamsungFactory;
            }
            if(manu = Enum.HTC)
            {
                factory = new HTCFactory;
            }
            if(manu = Enum.NOKIA)
            {
                factory = new NokiaFactory;
            }
            Console.WriteLine(factory.GetSmart.GetName());
            Console.WriteLine(factory.GetDumb.GetName());
        }
    }

    class Program
    {
        static void Main()
        {
            foreach(Manufacturers i in Enum.GetValues(typeof(Manufacturers)))
            {
                PhoneTypeChecker checker = new PhoneTypeChecker(i);
                checker.CheckProducts();
            }
            Console.ReadKey();
        }
    }
}