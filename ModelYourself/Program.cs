namespace ModelYourself
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ørjan", 34, "Rødt", "Nå spiser jeg sjelene til syndere.");
            person.printInfo();
        }
    }
}
