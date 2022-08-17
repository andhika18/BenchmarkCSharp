using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BenchmarkIntegerConverters
{
    public class Data
    {
        public int key { get; set; }
        public string value { get; set; }
    }
    public class Collection
    {
        public int Loop;

        public Collection(int loop)
        {
            Loop = loop;
        }

        //Dictionary
        public Dictionary<int, string> SetDictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (var i = 0; i < Loop; i++)
            {
                dictionary.Add(i, $"value {i}");
            }
            return dictionary;
        }
        public string GetDictionaryValue(Dictionary<int, string> dict, int key)
        {
            return dict.GetValueOrDefault(key);
        }
        public bool ContainDictionaryValue(Dictionary<int, string> dict, int key)
        {
            return dict.ContainsKey(key);
        }

        //Hashtable
        public Hashtable SetHashtable()
        {
            Hashtable hashTable = new Hashtable();
            for(var i = 0; i < Loop; i++)
            {
                hashTable.Add(i, $"value {i}");
            }
            return hashTable;
        }
        public string GetHashtableValue(Hashtable hashtable, int key)
        {
            return (string)hashtable[key];
        }
        public int CountHashtableValue(Hashtable hashtable)
        {
            return hashtable.Count;
        }
        public bool ContainHashtableValue(Hashtable hashtable, int key)
        {
            return hashtable.Contains(key);
        }

        //List
        public List<Data> SetList()
        {
            var lists = new List<Data>();
            for (var i = 0; i < Loop; i++)
            {
                lists.Add(new Data { key = i, value = $"value {i}" });
            }
            return lists;
        }
        public string GetListValue(List<Data> list, int key)
        {
            return list.Where(x => x.key == key).First().value;
        }
        public int CountListValue(List<Data> list)
        {
            return list.Count();
        }
        public bool ContainListValue(List<Data> list, Data value)
        {
            return list.Contains(value);
        }

        //HashSet
        public HashSet<Data> SetHashSet()
        {
            var hashSet = new HashSet<Data>();
            for (var i = 0; i < Loop; i++)
            {
                hashSet.Add(new Data { key = i, value = $"value {i}"});
            }
            return hashSet;
        }
        public string GetHashSetValue(HashSet<Data> hs, int key)
        {
            return hs.Where(x => x.key == key).First().value;
        }
        public int CountHashSetValue(HashSet<Data> hs)
        {
            return hs.Count();
        }
        public bool ContainHashSetValue(HashSet<Data> hs, Data value)
        {
            return hs.Contains(value);
        }
        
        //DictionaryObject
        public Dictionary<int, Data> SetDictionaryObject()
        {
            var dictionary = new Dictionary<int, Data>();
            for (var i = 0; i < Loop; i++)
            {
                dictionary.Add(i, new Data { key = i, value = $"value {i}" });
            }
            return dictionary;
        }
        public string GetDictionaryObjectValue(Dictionary<int, Data> dict, int key)
        {
            return dict[key].value;
        }
        public int CountDictionaryObjectValue(Dictionary<int, Data> dictionay)
        {
            return dictionay.Count();
        }
        public bool ContainDictionaryObjectValue(Dictionary<int, Data> dict, Data key)
        {
            return dict.ContainsValue(key);
        }

        //SortedSet
        public SortedList<int, Data> SetSortedList()
        {
            var sortedList = new SortedList<int, Data>();
            for (var i = 0; i < Loop; i++)
            {
                sortedList.Add(i, new Data { key = i, value = $"value {i}" });
            }
            return sortedList;
        }
        public string GetSortedListValue(SortedList<int,Data> sortedList, int key)
        {
            return sortedList[key].value;
        }
        public int CountSortedListValue(SortedList<int, Data> sortedList)
        {
            return sortedList.Count();
        }
        public bool ContainSortedListValue(SortedList<int,Data> sortedList, Data key)
        {
            return sortedList.ContainsValue(key);
        }
        //Stack
        public Stack<Data> SetStack()
        {
            var stack = new Stack<Data>();
            for (var i = 0; i < Loop; i++)
            {
                stack.Push(new Data { key = i, value = $"value {i}" });
            }
            return stack;
        }
        public string GetStackValue(Stack<Data> stack, int key)
        {
            return stack.Where(x => x.key == key).First().value;
        }
        public int CountStackValue(Stack<Data> stack)
        {
            return stack.Count();
        }
        public bool ContainStackValue(Stack<Data> stack, Data key)
        {
            return stack.Contains(key);
        }

        //Queue
        public Queue<Data> SetQueue()
        {
            var queue = new Queue<Data>();
            for (var i = 0; i < Loop; i++)
            {
                queue.Enqueue(new Data { key = i, value = $"value {i}" });
            }
            return queue;
        }
        public string GetQueuetValue(Queue<Data> queue, int key)
        {
            return queue.Where(x => x.key == key).First().value;
        }
        public int CountQueueValue(Queue<Data> queue)
        {
            return queue.Count();
        }
        public bool ContainQueueValue(Queue<Data> queue, Data key)
        {
            return queue.Contains(key);
        }


        //LinkedList
        //SortedDictionary
        //SortedList
    }
}
