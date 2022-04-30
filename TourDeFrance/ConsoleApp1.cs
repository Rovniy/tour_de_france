namespace ConsoleApp1;

public class Tour
    {
        public int _cyclers_count = 0;
        public float _distantion = 10f;
        public List<Cycler> cyclers;

        public List<Bicycle> bicycle = new List<Bicycle>()
        {
            new Bicycle("Adriatica", 110, 20, 20000),
            new Bicycle("AGang", 100, 40, 35000),
            new Bicycle("Alpine Bike", 90, 15, 12000),
            new Bicycle("Altair", 80, 10, 8000),
            new Bicycle("Aspect", 95, 30, 35000),
        };
        

        public static void Main()
        {
            string m1 = "\nType a string of text then press Enter. " +
                               "Type '+' anywhere in the text to quit:\n";
            string m2 = "Character '{0}' is hexadecimal 0x{1:x4}.";
            string m3 = "Character     is hexadecimal 0x{0:x4}.";
            char ch;
            int x;
            
           Console.WriteLine(m1);
           do
           {
               x = Console.Read();
               try
               {
                   ch = Convert.ToChar(x);
                   if (Char.IsWhiteSpace(ch))
                   {
                       Console.WriteLine(m3, x);
                       if (ch == 0x0a)
                           Console.WriteLine(m1);
                   }
                   else
                   {
                       Console.WriteLine(m2, ch, x);
                   }
               }
               catch (OverflowException e)
               {
                   Console.WriteLine("{0} Value read = {1}.", e.Message, x);
                   ch = Char.MinValue;
                   Console.WriteLine(m1);
               }
           } while (ch != '+');
        }

        public void AddCycler()
        {
            //cyclers.Add(new Cycler());
        }
        
        public void RemoveCycler()
        {
            cyclers.Remove(cyclers[0]);
        }

        public void Show()
        {
            
        }
    }

    public class Cycler
    {
        public string _firstName;
        public string _lastName;
        public int _age;
        public string _country;
        public List<Bicycle> _bicycles; // max 5
        public int _avrSpeed;

        public Cycler(string firstName, string lastName, int age, string country, Bicycle bicylce, int avrSpeed)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _country = country;
            _bicycles.Add(bicylce);
            _avrSpeed = avrSpeed;
        }

        /**
         * увеличивается количество участников в гонке и возвращается текущее количество участников;
         */
        public void GoIn()
        {
            
        }

        /**
         * уменьшается количество участников в гонке и возвращается текущее количество участников;
         */
        public void GoOut()
        {
            
        } 
        
        /**
         * обновляется список велосипедов, если это возможно
         */
        public void AddBicycle(Bicycle bicycle)
        {
            if (_bicycles.Count >= 5) return;
            
            _bicycles.Add(bicycle);
        }
        
        /**
         * обновляется список велосипедов, если это возможно
         */
        public void Finish()
        {
            
        }
    }

    public class Bicycle
    {
        public string _name;
        public int _maxSpeed;
        public int _averageSpeed;
        public int _cost;
        
        public Bicycle(string name, int maxSpeed, int averageSpeed, int cost)
        {
            _name = name;
            _maxSpeed = maxSpeed;
            _averageSpeed = averageSpeed;
            _cost = cost;
        }
    }