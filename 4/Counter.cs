namespace ConsoleApp3
{ 
public class Counter
{
        public event EventHandler Inicialization;
        public void Inicializat()
        {
                int[] a = Enumerable.Range(0, 100).ToArray();
                for (int i = 1; i < 100; i++)
                {
                    Console.WriteLine(i);
                    if (i == 77)
                    {
                        Console.WriteLine(i);
                        Inicialization (this, new EventArgs());
                        break;
                    }
                }
        }
}
} 
