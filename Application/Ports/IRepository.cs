using System.Collections.ObjectModel;
using Domain.Models;

namespace Domain.Ports;
public interface IRepository
{
    Account? GetAccountById(int id);
    Collection<Transaction> GetAllTransactions(int id);
    void HandleTransaction(Transaction transaction);
    int CreateAccount(int pin);
    Admin? GetAdminByUsername(string username);
}
