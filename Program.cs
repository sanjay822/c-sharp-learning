using System;
interface ISanju
{
    void Show();
}
interface IAj:ISanju
{ void Show1(); }
class B: IAj
{
   public void Show()
    {
        Console.WriteLine("interface inter1");
    }
    public void Show1() 
    {
        Console.WriteLine("interface inter2");
    }

}
class A
{
    public static void Main()
    {
        B b = new B();
        b.Show();
        b.Show1();
    }
} 