// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Test 1.

class I
{
    public const string myName = "Kosimhan";

    public string want;

    public int howPices;

    public string Want { get; set; } = "Pizza";

    public I()
    {
        Console.WriteLine("Сколько штук");
    }
    public I(int howPices)
    {
        this.howPices = howPices;
    }
}
class Delivery : I
{
    public int colvo;

    public string deliver; 

    public Delivery(int howPices, int colvo, string askSumm) :base(howPices)
    {
        this.colvo = colvo;
        deliver = askSumm;
    }
}
class Program
{
    static void Main()
    {
        Delivery trix = new Delivery(10, 300, "Сказал сумму")
        {
            want = "Хочу 10 Pizza"
        };
        Console.WriteLine(trix.Want);
        Console.WriteLine(trix.want);
    }
}























































































