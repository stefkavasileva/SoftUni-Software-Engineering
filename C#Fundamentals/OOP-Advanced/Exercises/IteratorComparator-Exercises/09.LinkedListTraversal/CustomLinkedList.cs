using System.Collections;
using System.Collections.Generic;

public class CustomLinkedList<T> :IEnumerable<T>
{
    public CustomLinkedList()
    {
        this.Count = 0;
        this.HeadNode = null;
    }

    public int Count { get; set; }
    private Node HeadNode { get; set; }

    public void AddToEnd(T data)
    {
        if (this.HeadNode == null)
        {
            this.HeadNode = new Node(data);
        }
        else
        {
            this.HeadNode.AddToEnd(data);
        }

        this.Count++;
    }

    public bool Remove(int item)
    {
        // If the list is empty:
        if (this.HeadNode == null)
        {
            return false;
        }

        Node currentNode = this.HeadNode;
        Node previousNode = null;

        while (currentNode != null)
        {
            if (currentNode.Data.Equals(item))
            {
                // When the current node is not the first one in the list:
                if (previousNode != null)
                {
                    previousNode.Next = currentNode.Next;
                }
                // When the current node is the first one in the list:
                else
                {
                    this.HeadNode = this.HeadNode.Next;
                }

                this.Count--;
                return true;
            }

            previousNode = currentNode;
            currentNode = currentNode.Next;
        }

        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node currentNode = this.HeadNode;

        while (currentNode != null)
        {
            yield return currentNode.Data;
            currentNode = currentNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class Node
    {
        public Node(T inputData)
        {
            this.Data = inputData;
            this.Next = null;
        }

        public T Data { get; }
        public Node Next { get; set; }

        public void AddToEnd(T inputData)
        {
            if (this.Next == null)
            {
                this.Next = new Node(inputData);
            }
            else
            {
                this.Next.AddToEnd(inputData);
            }
        }
    }
}
