using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add four items with different priorities.
    // The highest priority item is added last. Dequeue all items.
    // Expected Result: Highest, Middle, Other, Low.
    // Defect(s) Found: The original Dequeue loop skipped the last
    // item when searching for the highest priority. It also failed
    // to remove the returned item from the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Middle", 5);
        priorityQueue.Enqueue("Other", 3);
        priorityQueue.Enqueue("Highest", 10);

        Assert.AreEqual("Highest", priorityQueue.Dequeue());
        Assert.AreEqual("Middle", priorityQueue.Dequeue());
        Assert.AreEqual("Other", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: Items with equal priority are removed in
    // the same order they were added (FIFO).
    // Defect(s) Found: The original implementation used >= when
    // comparing priorities, which could select a later item
    // instead of the first item with the highest priority.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("First", 8);
        priorityQueue.Enqueue("Second", 3);
        priorityQueue.Enqueue("Third", 8);
        priorityQueue.Enqueue("Fourth", 1);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Fourth", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to remove an item from an empty priority queue.
    // Expected Result: InvalidOperationException with the message
    // "The queue is empty."
    // Defect(s) Found: None. The original implementation already
    // handles an empty queue correctly.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }

    // Add more test cases as needed below.
}