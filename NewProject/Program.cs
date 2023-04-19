internal class Program
{
    int a = 10;
    int b = 20;

    public void addNumbers()
    {
        Console.WriteLine(a + b);
    }

    public void subnumbders()
    { Console.WriteLine(a - b);
    }
    public void multinumbers()
    { Console.WriteLine(a * b); }
    public void divinumbers() 
    { Console.WriteLine(a / b); }
private static void Main(string[] args)
    {

        Program program = new Program();
        program.addNumbers();
        program.subnumbders();
        program.multinumbers();
        program.divinumbers(); 
    }   

}
