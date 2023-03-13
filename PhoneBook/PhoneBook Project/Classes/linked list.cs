using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    [Serializable]
    public class Nodes<t>
    {
        public t data{set;get;}
        public Nodes<t> next { set;get; }

        public Nodes(t inputData, Nodes<t> next)
        {
            data = inputData;
            this.next = next;
        }


        public void updateData(t inputData)
        {
            this.data = inputData;
        }

        public void updateNext(Nodes<t> next)
        {
            this.next = next;
        }


        

        
    }

    [Serializable]
    public class linked_list<t> : IEnumerable<t>
    {
        Nodes<t> head;
        Nodes<t> tail;
        int counter = 0;

        public void addNodeToFirst(t Data)
        {
            if (counter == 0)
            {
                Nodes<t> temp = new Nodes<t>(Data, null);
                head = temp;
                tail = head;
                counter++;
            }
            else
            {
                Nodes<t> temp = new Nodes<t>(Data, head);
                head = temp;
                counter++;

            }
        }

        public void DeletFromFirst()
        {
            head = head.next;
            counter--;
        }
        public void AddLast(t Data)
        {
            if (counter == 0)
            {
                Nodes<t> temp = new Nodes<t>(Data, null);
                head = temp;
                tail = head;
                counter++;
            }
            else
            {
                Nodes<t> temp = new Nodes<t>(Data, null);
                tail.next = temp;
                tail = temp;
                counter++;

            }
        }
        public void deletFromEnd()
        {
            Nodes<t> temp = head;
            for (int i = 1; i < counter - 1; i++)
            {
                temp = temp.next;
            }
            tail = temp;
            temp.next = null;
            counter--;
        }




        public int indexOf(t Data)
        {
            Nodes<t> temp = head;
            int index = 0;
            while (temp != null)
            {
                if (string.Compare(temp.data.ToString(), Data.ToString()) == 0)
                {
                    return index;
                }
                temp = temp.next;
                index++;
            }

            throw new Exception("Data not found!");

        }

        public void addAfter(t AddThis, t AfterThis)
        {
            int index = indexOf(AfterThis);

            Nodes<t> temp = head;

            for (int i = 0; i < index; i++)
            {
                temp = temp.next;
            }

            Nodes<t> newNode = new Nodes<t>(AddThis, temp.next);
            temp.next = newNode;
            counter++;
        }

        public void addBefore(t AddThis, t AfterThis)
        {
            int index = indexOf(AfterThis);
            Nodes<t> temp = head;

            for (int i = 0; i < index - 1; i++)
            {
                temp = temp.next;
            }

            Nodes<t> newNode = new Nodes<t>(AddThis, temp.next);
            temp.next = newNode;
            counter++;
        }

        public void Remove(t DeletThis)
        {
            int index = indexOf(DeletThis);
            Nodes<t> temp = head;

            for (int i = 0; i < index-1 ; i++)
            {
                temp = temp.next;
            }
            //first node
            if (index==0)
            {
                head = head.next;
            }
                //last node
            else if (index == counter)
            {
                for (int i = 0; i < counter - 1; i++)
                {
                    temp = temp.next;
                }
                temp.next = temp.next.next;
                tail = temp;
            }
                //others node
            else
            {
                temp.next = temp.next.next;
            }

            counter--;
        }

        public IEnumerator<t> GetEnumerator()
        {
            Nodes<t> currentNode = head;
            while (currentNode != null)
            {
                yield return currentNode.data;
                currentNode = currentNode.next;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
         
         
}
