// See https://aka.ms/new-console-template for more information


public class UserInterface
{
    public void GetData()
    {
        Console.WriteLine("Entre com seu username:");
        var userName = Console.ReadLine();

        Console.Write("Entre com seu password:");
        var password = Console.ReadLine();

        IBusiness business = new BusinessV2();
        business.SignUp(userName, password);
    }
}

public class Business : IBusiness
{
    public void SignUp(string userName, string password)
    {
        //Validation
        var dataAccess = new DataAccess();
        dataAccess.Store(userName, password);
    }
}

//Implemento a interface de IBusiness
public class BusinessV2 : IBusiness
{
    public void SignUp(string userName, string password)
    {
        throw new NotImplementedException();
    }
}

public class DataAccess : IDataAccess
{
    public void Store(string userName, string password)
    {
        //Escrevendo no banco de dados
    }
}

public interface IBusiness
{
    void SignUp(string userName, string password);
}

public interface IDataAccess
{
    void Store(string userName, string password);
}
