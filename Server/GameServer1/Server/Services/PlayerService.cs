namespace Server.Services;

public interface IPlayerService
{
    void Do();
}
public class PlayerService : IPlayerService
{
    
    public void Do()
    {
        Console.WriteLine("service");
    }
}

public class MockPlayerService : IPlayerService
{
    public void Do()
    {
        Console.WriteLine("mock Service");
    }
}