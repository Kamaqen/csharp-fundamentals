namespace HelloWorldConsole.Katas
{
    using System;

    public class CanYouGetLoop
    {
        public static int getLoopSize(LoopDetector.Node startNode)
        {
            // Step 1: Detect if there's a loop using Floyd's Cycle Detection algorithm
            LoopDetector.Node slow = startNode;
            LoopDetector.Node fast = startNode;

            // Move slow by 1 and fast by 2 steps
            do
            {
                slow = slow.next;
                fast = fast.next.next;
            } while (slow != fast); // Loop until they meet, confirming the loop exists

            // Step 2: Calculate the loop size
            int loopSize = 0;
            do
            {
                slow = slow.next;
                loopSize++;
            } while (slow != fast); // Keep moving slow until it meets fast again to calculate the loop size

            return loopSize;
        }
    }
}
