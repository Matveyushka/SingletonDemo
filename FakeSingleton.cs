public class FakeSingleton
{
    private static int counter = 0;

    public int Number { get; set; } = counter++;
}