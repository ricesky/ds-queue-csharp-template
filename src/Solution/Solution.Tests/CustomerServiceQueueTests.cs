using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.CustomerServiceQueue;

namespace Solution.Tests;

[TestClass]
public class CustomerServiceQueueTests
{
    [TestMethod]
    public void Enqueue_PelangganAdded_PelangganInQueue()
    {
        var queue = new CustomerQueue();
        var pelanggan = new Pelanggan("Alice", "A001");
        queue.Enqueue(pelanggan);

        Assert.AreEqual("Alice", queue.Peek().Nama);
        Assert.AreEqual("A001", queue.Peek().ID);
    }

    [TestMethod]
    public void Dequeue_PelangganRemoved_ReturnsCorrectPelanggan()
    {
        var queue = new CustomerQueue();
        var pelanggan1 = new Pelanggan("Alice", "A001");
        var pelanggan2 = new Pelanggan("Bob", "B002");
        queue.Enqueue(pelanggan1);
        queue.Enqueue(pelanggan2);

        var removedPelanggan = queue.Dequeue();
        Assert.AreEqual("Alice", removedPelanggan.Nama);
        Assert.AreEqual("A001", removedPelanggan.ID);
        Assert.AreEqual("Bob", queue.Peek().Nama);
    }

    [TestMethod]
    public void Peek_EmptyQueue_ReturnsNull()
    {
        var queue = new CustomerQueue();
        var result = queue.Peek();

        Assert.IsNull(result);
    }

    [TestMethod]
    public void Dequeue_EmptyQueue_ReturnsNull()
    {
        var queue = new CustomerQueue();
        var result = queue.Dequeue();

        Assert.IsNull(result);
    }

    [TestMethod]
    public void EnqueueDequeue_MultiplePelanggans_CorrectOrderMaintained()
    {
        var queue = new CustomerQueue();
        queue.Enqueue(new Pelanggan("Alice", "A001"));
        queue.Enqueue(new Pelanggan("Bob", "B002"));
        queue.Enqueue(new Pelanggan("Charlie", "C003"));

        Assert.AreEqual("Alice", queue.Dequeue().Nama);
        Assert.AreEqual("Bob", queue.Dequeue().Nama);
        Assert.AreEqual("Charlie", queue.Peek().Nama);
    }
}
