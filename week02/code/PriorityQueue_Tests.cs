using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with varying priorities, including two with the same highest priority.
    // Expected Result: Items are dequeued in order of priority (highest first). For tied priorities, FIFO is used.
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        // Enqueue items
        priorityQueue.Enqueue("Apple", 1);
        priorityQueue.Enqueue("Banana", 5);
        priorityQueue.Enqueue("Orange", 3);
        priorityQueue.Enqueue("Pear", 5);

        // Expected order: Banana (5), Pear (5), Orange (3), Apple (1)
        Assert.AreEqual("Banana", priorityQueue.Dequeue());
        Assert.AreEqual("Pear", priorityQueue.Dequeue());
        Assert.AreEqual("Orange", priorityQueue.Dequeue());
        Assert.AreEqual("Apple", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: An InvalidOperationException is thrown with the message "The queue is empty."
    // Defect(s) Found: None (The exception handling in the provided code actually works correctly for this requirement).
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail($"Unexpected exception of type {e.GetType()} caught: {e.Message}");
        }
    }

    // Add more test cases as needed below.
}