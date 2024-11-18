using System.Globalization;
using Domain.Models;
using Domain.Ports;

namespace App;
public class Service
{
    private IRepository _repo;
    private bool _isAdmin;
    public Service(IRepository repo)
    {
        _repo = repo;
    }

    public void LogAsAdmin(IList<string> request)
    {
        Admin? currentAdmin = _repo.GetAdminByUsername(request[1]);
        if (request[2] != currentAdmin.Password) Environment.Exit(0);

        _isAdmin = true;
        while (_isAdmin)
        {
            Console.WriteLine("1 - Выйти");
            int choose = Convert.ToInt32(Console.ReadLine(), CultureInfo.CurrentCulture);
            if (choose == 1)
            {
                _isAdmin = false;
                break;
            }
        }
    }

    public void ChangeBalance(IList<string> request)
    {
        Account? user = _repo.GetAccountById(Convert.ToInt32(request[1], CultureInfo.CurrentCulture));
        if (Convert.ToInt32(request[2], CultureInfo.CurrentCulture) == user.Pin)
        {
            var transaction = new Domain.Models.Transaction(user.AccountId, Convert.ToDecimal(request[3], default));
            _repo.HandleTransaction(transaction);
        }
    }

    public void History(IList<string> request)
    {
        Account? user = _repo.GetAccountById(Convert.ToInt32(request[1], CultureInfo.CurrentCulture));
        if (Convert.ToInt32(request[2], CultureInfo.CurrentCulture) == user.Pin)
        {
            foreach (Domain.Models.Transaction transaction in _repo.GetAllTransactions(user.AccountId))
            {
                Console.WriteLine($"{transaction.Sum}");
            }
        }
    }

    public void CheckBalance(IList<string> request)
    {
        Account? user = _repo.GetAccountById(Convert.ToInt32(request[1], CultureInfo.CurrentCulture));
        if (Convert.ToInt32(request[2], CultureInfo.CurrentCulture) == user.Pin)
        {
            Console.WriteLine(user.Balance);
        }
    }

    public void CreateAccount(IList<string> request)
    {
        _repo.CreateAccount(Convert.ToInt32(request[1], CultureInfo.CurrentCulture));
    }
}