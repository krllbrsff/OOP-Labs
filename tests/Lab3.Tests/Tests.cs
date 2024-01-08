using System;
using System.IO;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Tests
{
    [Fact]
    public void NewMessageToUserTest()
    {
        var user = new UserAddressee();
        var topic = new Topic("Test user", user);
        Message message = new Message.MessageBuilder()
            .SetTitle("Test message")
            .SetText("Hello world!!!")
            .SetLevel(ImportanceLevels.Medium)
            .Build();

        topic.Send(message);

        Assert.Contains(message, user.NewMessages);
    }

    [Fact]
    public void MarkMessageAsReadTest()
    {
        var user = new UserAddressee();
        var topic = new Topic("Test user", user);
        Message message = new Message.MessageBuilder()
            .SetTitle("Test message")
            .SetText("Hello world!!!")
            .SetLevel(ImportanceLevels.Medium)
            .Build();

        topic.Send(message);
        user.MarkAsRead(message);

        Assert.Contains(message, user.Archive);
    }

    [Fact]
    public void MarkReadMessageTest()
    {
        var user = new UserAddressee();
        var topic = new Topic("Test user", user);
        Message message = new Message.MessageBuilder()
            .SetTitle("Test message")
            .SetText("Hello world!!!")
            .SetLevel(ImportanceLevels.Medium)
            .Build();

        topic.Send(message);
        user.MarkAsRead(message);

        Assert.Throws<ArgumentException>(() => user.MarkAsRead(message));
    }

    [Fact]
    public void FilterTest()
    {
        var addresseeMock = new Mock<Addressee>();
        Message lowPriorityMessage = new Message.MessageBuilder()
            .SetTitle("Test message")
            .SetText("Hello world!!!")
            .SetLevel(ImportanceLevels.Low)
            .Build();
        var filter = new Filter(addresseeMock.Object, ImportanceLevels.High);
        var topic = new Topic("User with high priority filter", filter);

        topic.Send(lowPriorityMessage);

        addresseeMock.Verify(x => x.ReceiveMessage(It.IsAny<Message>()), Times.Never);
    }

    [Fact]
    public void LoggerTest()
    {
        var user = new UserAddressee();
        Message message = new Message.MessageBuilder()
            .SetTitle("Test message")
            .SetText("Hello world!!!")
            .SetLevel(ImportanceLevels.Low)
            .Build();
        var loggerMock = new Mock<Logger>();
        var topic = new Topic("Test user", loggerMock.Object);

        topic.Send(message);

        loggerMock.Verify(x => x.ReceiveMessage(It.IsAny<Message>()), Times.Once);
    }

    [Fact]
    public void MessengerTest()
    {
        var user = new Messenger("Telegram");
        var addressee = new MessengerAddressee(user);
        Message message = new Message.MessageBuilder()
            .SetTitle("Test message")
            .SetText("Hello world!!!")
            .SetLevel(ImportanceLevels.High)
            .Build();
        var topic = new Topic("User messenger", addressee);
        var consoleMock = new Mock<TextWriter>();
        Console.SetOut(consoleMock.Object);
        string expectedOutput = "Test message\nHello world!!!\nvia Telegram";
        topic.Send(message);

        consoleMock.Verify(x => x.WriteLine(expectedOutput), Times.Once);
    }
}