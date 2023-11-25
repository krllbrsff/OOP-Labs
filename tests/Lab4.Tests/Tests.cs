using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;
public class Tests
{
    [Fact]
    public void TreeListTest()
    {
        var consoleMock = new Mock<TextWriter>();
        Console.SetOut(consoleMock.Object);
        var chain = new Chain();
        chain.AddNext(new Connect());
        chain.AddNext(new Disconnect());
        chain.AddNext(new FileCopy());
        chain.AddNext(new FileDelete());
        chain.AddNext(new FileMove());
        chain.AddNext(new FileRename());
        chain.AddNext(new FileShow());
        chain.AddNext(new TreeGoTo());
        chain.AddNext(new TreeList());
        var request = new Command();
        request.SetNewCommand("connect D:\\Test");
        chain.Execute(request);
        request.SetNewCommand("tree list");
        chain.Execute(request);
        string expected1 = " 2level1";
        string expected2 = " Level1";
        consoleMock.Verify(x => x.WriteLine(expected1), Times.Once);
        consoleMock.Verify(x => x.WriteLine(expected2), Times.Once);
    }

    [Fact]
    public void FileShowTest()
    {
        var consoleMock = new Mock<TextWriter>();
        Console.SetOut(consoleMock.Object);
        var chain = new Chain();
        chain.AddNext(new Connect());
        chain.AddNext(new Disconnect());
        chain.AddNext(new FileCopy());
        chain.AddNext(new FileDelete());
        chain.AddNext(new FileMove());
        chain.AddNext(new FileRename());
        chain.AddNext(new FileShow());
        chain.AddNext(new TreeGoTo());
        chain.AddNext(new TreeList());
        var request = new Command();
        request.SetNewCommand("connect D:\\Test");
        chain.Execute(request);
        request.SetNewCommand("file show D:\\Test\\2level1\\2Level2\\Level3.txt");
        chain.Execute(request);
        string expected = "fileshowtest";
        consoleMock.Verify(x => x.WriteLine(expected), Times.Once);
    }
}
