namespace ejercicio9
    {
    public class sueldo
    {
        public static void Main()
        {
            int SS, CH, VH;
            Console.WriteLine("por favor digite las horas trabajadas");
            CH = int.Parse(Console.ReadLine());
            Console.WriteLine("por favor digite el valor de la hora");
            VH = int.Parse(Console.ReadLine());
            SS = CH * VH;
            Console.WriteLine($"el sueldo semanal es {SS}");



        }

    }

    }