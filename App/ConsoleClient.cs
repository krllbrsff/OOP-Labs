using System.Globalization;

namespace App;
public class ConsoleClient
{
    private Service _service;

    public ConsoleClient(Service service)
    {
        _service = service;
    }

    public void Execute()
    {
        Console.WriteLine("Choose option");
        Console.WriteLine("1 - войти как админ '1 [username] [password]'\r\n2 - изменение баланса счёта '2 [account] [pin] [sum]'\r\n3 - просмотр истории операций '3 [account] [pin]'\r\n4 - добавление счёта '4 [pin]\r\n5 - просмотр баланса '5 [account] [pin]'");

        while (true)
        {
            IList<string>? request = Console.ReadLine()?.Split(' ');
            switch (Convert.ToInt32(request[0], CultureInfo.CurrentCulture))
            {
                case 1:
                    {
                        _service.LogAsAdmin(request);
                        break;
                    }

                case 2:
                    {
                        _service.ChangeBalance(request);

                        break;
                    }

                case 3:
                    {
                        _service.History(request);

                        break;
                    }

                case 4:
                    {
                        _service.CreateAccount(request);
                        break;
                    }

                case 5:
                    {
                        _service.CheckBalance(request);

                        break;
                    }
            }
        }
    }
}