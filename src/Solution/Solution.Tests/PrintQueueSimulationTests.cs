using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.PrintQueueSimulation;
using System.Collections.Generic;
using System.IO;
using System;

namespace Solution.Tests;

[TestClass]
public class PrintQueueSimulationTests
{
    private StringWriter consoleOutput;

    [TestInitialize]
    public void Initialize()
    {
        consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
    }

    [TestCleanup]
    public void Cleanup()
    {
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        consoleOutput.Dispose();
    }

    [TestMethod]
    public void TambahDokumen_ShouldAddDocumentToQueue()
    {
        // Arrange
        var printQueue = new PrintQueue();
        var dokumen = new Dokumen("Test.pdf", 5);

        // Act
        printQueue.TambahDokumen(dokumen);

        // Use reflection to access private queue field if necessary
        var field = typeof(PrintQueue).GetField("queue", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var queueValue = (Queue<Dokumen>)field.GetValue(printQueue);

        // Assert
        Assert.IsNotNull(queueValue);
        Assert.AreEqual(1, queueValue.Count);
        Assert.AreEqual("Test.pdf", queueValue.Peek().NamaFile);
        Assert.AreEqual(5, queueValue.Peek().JumlahHalaman);
    }

    [TestMethod]
    public void ProsesPencetakan_ShouldPrintAndRemoveFirstDocument()
    {
        // Arrange
        var printQueue = new PrintQueue();
        printQueue.TambahDokumen(new Dokumen("Test.pdf", 5));
        printQueue.TambahDokumen(new Dokumen("AnotherTest.pdf", 10));

        // Act
        printQueue.ProsesPencetakan();

        // Use reflection to access private queue field if necessary
        var field = typeof(PrintQueue).GetField("queue", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var queueValue = (Queue<Dokumen>)field.GetValue(printQueue);

        // Assert
        Assert.AreEqual(1, queueValue.Count);
        Assert.AreEqual("AnotherTest.pdf", queueValue.Peek().NamaFile);
    }

    [TestMethod]
    public void LihatAntrian_ShouldDisplayAllDocumentsWithoutRemoving()
    {
        // Arrange
        var printQueue = new PrintQueue();
        printQueue.TambahDokumen(new Dokumen("Test.pdf", 5));
        printQueue.TambahDokumen(new Dokumen("AnotherTest.pdf", 10));

        // Act
        printQueue.LihatAntrian();

        // Use reflection to access private queue field if necessary
        var field = typeof(PrintQueue).GetField("queue", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var queueValue = (Queue<Dokumen>)field.GetValue(printQueue);

        // Assert (checking console output)
        var output = consoleOutput.ToString();
        Assert.IsTrue(output.Contains("Test.pdf, 5 halaman"));
        Assert.IsTrue(output.Contains("AnotherTest.pdf, 10 halaman"));
        Assert.AreEqual(2, queueValue.Count);
    }
}
