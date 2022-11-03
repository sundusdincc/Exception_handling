using System;
internal class Program
{
    private static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Bir sayı giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int z = a + b;//Toplama
            int y = a / b; //Bölme

            Console.WriteLine("Toplam: {0} Bölme: {1}", z, y);
            
        }
        catch (Exception ex)
        {

            if (ex is FormatException || ex is OverflowException || ex is ArgumentNullException || ex is DivideByZeroException)
            {
                // write to a log, whatever...
                Console.WriteLine(ex.Message);

                return;
            }
            throw;
        }

        finally
        {
            Console.WriteLine("Executed");
        }

        Console.ReadKey();



    }




}
