using OrderEvents;

public class Program
{
    private static void Main(string[] args)
    {
        Order order = new Order();
        order.OnCreated += Email.Send;
        order.OnCreated += SMS.Send;
        order.Create("pathum@gmail.com", "0718574896");
        Console.ReadKey();
    }
}