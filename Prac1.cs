using System.IO.Pipes;

class Sumclass
{
    public int a;
    public int b;

    public int addmethod()
    {
         Console.WriteLine("Hi, Do you want to add two number:");
         Console.WriteLine("Enter two integer:");
         a=int.Parse(Console.ReadLine());
         b=int.Parse(Console.ReadLine());
         int y=a+b;
         return y;
    }

}

class MainClass
{
    
    public  static void Main(string[] args)
    {
        Console.WriteLine("I am Jamil Hasan Nayem");
        Sumclass a= new Sumclass();
        int h=a.addmethod();
        Console.WriteLine(h);
    }
}