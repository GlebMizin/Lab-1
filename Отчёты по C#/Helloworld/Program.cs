namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG            
            TextReader save_in = Console.In;
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"Output.txt");
            var new_in = new StreamReader(@"Input.txt");
            Console.SetIn(new_in);
            Console.SetOut(new_out);
#endif
            Parametri p = new Parametri();
            p.Load();
            p.Info();

#if !DEBUG 
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif            
        }
    }
    class Parametri
    {
        private double x,y,z;
        public double GetL() {return Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2)); }
        public void Info()
        {
              String str =("                   |\n"+
                    "                   |\n"+
                    "                   |\n"+
                    "                   |         * <--Точка в пространстве\n"+
                    "                   |\n"+
                    "                   |\n"+
                    "                   |\n"+
                    "                   |\n"+
                    "                   . - – – – – – – – -\n"+
                    "                  /\n"+
                    "                 /\n"+
                    "                /\n"+
                    "               /\n"+
                    "              /\n"+
                    "             /\n");
            Console.WriteLine(str);
            Console.WriteLine("Координаты заданной точки: ( {0} ; {1} ; {2} )",x,y,z);
            Console.WriteLine("Расстояние от заданной точки до начала координат {0}",GetL());
        }
        public void Load()
        {
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            z = Convert.ToDouble(Console.ReadLine());
        }
    }
}

