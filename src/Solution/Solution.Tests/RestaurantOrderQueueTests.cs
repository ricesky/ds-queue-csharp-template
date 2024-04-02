using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.RestaurantOrderQueue;
using System;

namespace Solution.Tests;

[TestClass]
public class RestaurantOrderQueueTests
{
    [TestMethod]
    public void Enqueue_AddNewOrder_OrderAdded()
    {
        var orderQueue = new OrderQueue();
        var newOrder = new Pesanan("1", "Alice", "Nasi Goreng");
        orderQueue.Enqueue(newOrder);

        Assert.AreEqual(newOrder, orderQueue.Peek());
    }

    [TestMethod]
    public void Dequeue_RemoveOrderFromQueue_OrderRemoved()
    {
        var orderQueue = new OrderQueue();
        var order1 = new Pesanan("1", "Alice", "Nasi Goreng");
        var order2 = new Pesanan("2", "Bob", "Soto Ayam");
        orderQueue.Enqueue(order1);
        orderQueue.Enqueue(order2);

        var removedOrder = orderQueue.Dequeue();

        Assert.AreEqual(order1, removedOrder);
        Assert.AreEqual(order2, orderQueue.Peek());
    }

    [TestMethod]
    public void Dequeue_EmptyQueue_ReturnsNull()
    {
        var orderQueue = new OrderQueue();
        var result = orderQueue.Dequeue();

        Assert.IsNull(result);
    }

    [TestMethod]
    public void Peek_ReturnFirstOrderWithoutRemovingIt_OrderPeeked()
    {
        var orderQueue = new OrderQueue();
        var order1 = new Pesanan("1", "Alice", "Nasi Goreng");
        orderQueue.Enqueue(order1);
        var order2 = new Pesanan("2", "Bob", "Soto Ayam");
        orderQueue.Enqueue(order2);

        var firstOrder = orderQueue.Peek();

        Assert.AreEqual(order1, firstOrder);
        // Ensure the order is not removed from the queue
        Assert.AreEqual(order1, orderQueue.Peek());
    }

    [TestMethod]
    public void Peek_EmptyQueue_ReturnsNull()
    {
        var orderQueue = new OrderQueue();
        var result = orderQueue.Peek();

        Assert.IsNull(result);
    }
}
