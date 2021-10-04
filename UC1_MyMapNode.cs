﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_HashTable_Assignment
{
    class UC1_MyMapNode<K, V> //Key-Value Pair HashTable
    {
        //Variables
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items; //Passing the Keyvalue object to the Linkedlist
        public UC1_MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);  
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
    }
        //Class KeyValue
        public struct KeyValue<k, v>
        {
        public k Key { get; set; }
        public v Value { get; set; }
        }
}

