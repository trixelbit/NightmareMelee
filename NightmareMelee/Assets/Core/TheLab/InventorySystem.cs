using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem
{
    private CircularItemList ItemList = new CircularItemList();

    public void SelectItem()
    {
        ItemList.CurrentItem.ExecuteAffect();
    }

    public void NextItem()
    {
        ItemList.GoToNext();
    }

    public void PreviousItem() 
    {
        ItemList.GoToPrevious();
    }

    public void AddItem(Item item) 
    {
        ItemList.Add(item);
    }
    private class CircularItemList
    { 
        public int Count = 0;

        public Item CurrentItem 
        {
            get { return _selected.Item; }
        }

        private Node _selected;

        public void GoToNext()
        {
            if (_selected == null)
                return;

            _selected = _selected.Next;
        }

        public void GoToPrevious()
        {
            if (_selected == null)
                return;

            _selected = _selected.Previous;
        }

        public void Add(Item item)
        {
            if (_selected == null)
            { 
                _selected = new Node(item);
                return;
            }
            Node newNode;

            if (Count == 1)
            {
                newNode = new Node()
                {
                    Item = item,
                    Next = _selected,
                    Previous = _selected
                };
                _selected.Next = newNode;
                _selected.Previous = newNode;
                return;
            }

            newNode = new Node() 
            { 
                Item = item,
                Next = _selected,
                Previous = _selected.Previous
            };

            _selected.Previous.Next = newNode;
            _selected.Previous = newNode;
            Count++;
        }

        public void RemoveCurrent()
        {
            if (Count == 0)
                return;

            _selected.Previous.Next = _selected.Next;
            _selected.Next.Previous = _selected.Previous;
            GoToNext();

            Count--;
        }

        private class Node
        {
            public Node()
            { }

            public Node(Item item)
            {
                Item = item;
            }

            public Item Item;
            public Node Next;
            public Node Previous;
        }

    }
}



