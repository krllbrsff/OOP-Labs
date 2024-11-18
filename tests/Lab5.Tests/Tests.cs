using App;
using Domain.Models;
using Domain.Ports;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class Tests
{
    [Fact]
    public void AddsTransactionAndUpdatesBalance()
    {
        var repositoryMock = new Mock<IRepository>();
        var client = new ConsoleClient(repositoryMock.Object);
        int accountId = 1;
        int pin = 1234;
        var account = new Account(accountId, pin, 0);
        repositoryMock.Setup(repo => repo.GetAccountById(accountId)).Returns(account);
        var transaction = new Transaction(accountId, 100);

        client.ChangeBalance(new List<string> { "2", "1", "1234", "100" });

        repositoryMock.Verify(repo => repo.HandleTransaction(It.IsAny<Transaction>()), Times.Once);
    }
}