public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();


        // Test Cases

        // Test 1
        // Scenario: Can I enqueue a value nad dequeue it?
        // Expected Result: 
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("100", 5);
        string value = priorityQueue.Dequeue();
        Console.WriteLine(value);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Can I enqueue multiple values with the same priority and dequeue to ensure the basic functiontionality of the queue.
        // Expected Result: 
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("100", 5);
        priorityQueue.Enqueue("12", 5);
        priorityQueue.Enqueue("33", 5);
        priorityQueue.Enqueue("44", 5);
        value = priorityQueue.Dequeue();
        Console.WriteLine(value);
        value = priorityQueue.Dequeue();
        Console.WriteLine(value);
        value = priorityQueue.Dequeue();
        Console.WriteLine(value);
        value = priorityQueue.Dequeue();
        Console.WriteLine(value);


        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Can I enqueue multiple values with the different priorities and dequeue to test that the higher priority items are being dequeued first.
        // Expected Result: 
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("100", 1);
        priorityQueue.Enqueue("50", 1);
        priorityQueue.Enqueue("70", 2);
        value = priorityQueue.Dequeue();
        Console.WriteLine(value);
        value = priorityQueue.Dequeue();
        Console.WriteLine(value);
        value = priorityQueue.Dequeue();
        Console.WriteLine(value);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Can I dequeue from an empty queue.
        // Expected Result: 
        Console.WriteLine("Test 4");
        value = priorityQueue.Dequeue();
        Console.WriteLine(value);

        // Defect(s) Found: 

        Console.WriteLine("---------");
    }
}