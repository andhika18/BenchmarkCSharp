using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;

namespace BenchmarkIntegerConverters
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkCollection
    {
        Random random = new Random();
        private Collection _col;
        private int _randomKey;
        private Data _data;
        private Dictionary<int, Data> _dictionaryObject;
        private List<Data> _list;
        private SortedList<int, Data> _sortedList;
        private Stack<Data> _stack;
        private Queue<Data> _queue;


        //private Dictionary<int, string> _dictionary;
        //private Hashtable _hashTable;
        //private HashSet<Data> _hashSet;
        //private Stopwatch sw;
        
        public BenchmarkCollection()
        {
            _col = new Collection(1000);
            //_randomKey = random.Next(0, 1000);
            //_data = new Data { key = _randomKey, value = "value " + _randomKey };
            //_list = _col.SetList();
            //_dictionaryObject = _col.SetDictionaryObject();
            //_sortedList = _col.SetSortedList();
            //_stack = _col.SetStack();
            //_queue = _col.SetQueue();


            //sw = new Stopwatch();
            //_dictionary = _col.SetDictionary();
            //_hashTable = _col.SetHashtable();
            //_hashSet = _col.SetHashSet();
        }

        //[Benchmark]
        //public void GetFromDictionary()
        //{
        //    _col.GetDictionaryValue(_dictionary, _randomKey);
        //}
        //[Benchmark]
        //public void GetFromHashtable()
        //{
        //    _col.GetHashtableValue(_hashTable, _randomKey);
        //}
        //[Benchmark]
        //public void GetFromHashSetObject()
        //{
        //    _col.GetHashSetValue(_hashSet, _randomKey);
        //}

        //set
        [Benchmark]
        public void SetFromListObject()
        {
            _col.SetList();
        }
        [Benchmark]
        public void SetFromDictionaryObject()
        {
            _col.SetDictionaryObject();
        }
        [Benchmark]
        public void SetFromSortedListObject()
        {
            _col.SetSortedList();
        }
        [Benchmark]
        public void SetFromQueueObject()
        {
            _col.SetQueue();
        }
        [Benchmark]
        public void SetFromStackObject()
        {
            _col.SetStack();
        }
        //get
        //[Benchmark]
        //public void GetFromListObject()
        //{
        //    _col.GetListValue(_list, _randomKey);
        //}
        //[Benchmark]
        //public void GetFromDictionaryObject()
        //{
        //    _col.GetDictionaryObjectValue(_dictionaryObject, _randomKey);
        //}
        //[Benchmark]
        //public void GetFromSortedListObject()
        //{
        //    _col.GetSortedListValue(_sortedList, _randomKey);
        //}
        //[Benchmark]
        //public void GetFromQueueObject()
        //{
        //    _col.GetQueuetValue(_queue, _randomKey);
        //}
        //[Benchmark]
        //public void GetFromStackObject()
        //{
        //    _col.GetStackValue(_stack, _randomKey);
        //}
        //count
        //[Benchmark]
        //public void CountFromListObject()
        //{
        //    _col.CountListValue(_list);
        //}
        //[Benchmark]
        //public void CountFromDictionaryObject()
        //{
        //    _col.CountDictionaryObjectValue(_dictionaryObject);
        //}
        //[Benchmark]
        //public void CountFromSortedListObject()
        //{
        //    _col.CountSortedListValue(_sortedList);
        //}
        //[Benchmark]
        //public void CountFromQueueObject()
        //{
        //    _col.CountQueueValue(_queue);
        //}
        //[Benchmark]
        //public void CountFromStackObject()
        //{
        //    _col.CountStackValue(_stack);
        //}
        ////contains
        //[Benchmark]
        //public void ContainsFromListObject()
        //{
        //    _col.ContainListValue(_list, _data);
        //}
        //[Benchmark]
        //public void ContainsFromDictionaryObject()
        //{
        //    _col.ContainDictionaryObjectValue(_dictionaryObject, _data);
        //}
        //[Benchmark]
        //public void ContainsFromSortedListObject()
        //{
        //    _col.ContainSortedListValue(_sortedList, _data);
        //}
        //[Benchmark]
        //public void ContainsFromQueueObject()
        //{
        //    _col.ContainQueueValue(_queue, _data);
        //}
        //[Benchmark]
        //public void ContainsFromStackObject()
        //{
        //    _col.ContainStackValue(_stack, _data);
        //}






        //[Benchmark]
        //public void ContainsFromDictionary()
        //{
        //    _col.ContainDictionaryValue(_dictionary, _randomKey);
        //}
        //[Benchmark]
        //public void ContainsFromHashtable()
        //{
        //    _col.ContainHashtableValue(_hashTable, _randomKey);
        //}
        //[Benchmark]
        //public void ContainsFromHashSetObject()
        //{
        //    _col.ContainHashSetValue(_hashSet, _data);
        //}


        //public void TestAccess()
        //{
        //    sw.Start();
        //    float startTime, endTime, deltaTime = 0;
        //    var total = 10000000;
        //    int cycles = 10;
        //    int cycle = 0;
        //    string value = "";
        //    cycle = 0;

        //    startTime = sw.ElapsedMilliseconds;
        //    _dictionary = _col.SetDictionary();
        //    endTime = sw.ElapsedMilliseconds;
        //    deltaTime = endTime - startTime;
        //    Console.WriteLine("Time taken to set " + total + " dictionary is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //    startTime = sw.ElapsedMilliseconds;
        //    _hashTable = _col.SetHashtable();
        //    endTime = sw.ElapsedMilliseconds;
        //    deltaTime = endTime - startTime;
        //    Console.WriteLine("Time taken to set " + total + " hashtable is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //    startTime = sw.ElapsedMilliseconds;
        //    _hashSet = _col.SetHashSet();
        //    endTime = sw.ElapsedMilliseconds;
        //    deltaTime = endTime - startTime;
        //    Console.WriteLine("Time taken to set " + total + " hashset is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //    startTime = sw.ElapsedMilliseconds;
        //    _list = _col.SetList();
        //    endTime = sw.ElapsedMilliseconds;
        //    deltaTime = endTime - startTime;
        //    Console.WriteLine("Time taken to set " + total + " list is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //    startTime = sw.ElapsedMilliseconds;
        //    _dictionaryObject = _col.SetDictionaryObject();
        //    endTime = sw.ElapsedMilliseconds;
        //    deltaTime = endTime - startTime;
        //    Console.WriteLine("Time taken to set " + total + " dictionary object is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //    Console.WriteLine();

        //    while (cycle < cycles)
        //    {
        //        _randomKey = random.Next(0, total);
        //        startTime = sw.ElapsedMilliseconds;
        //        value = _col.GetDictionaryValue(_dictionary, _randomKey);
        //        endTime = sw.ElapsedMilliseconds;
        //        deltaTime = endTime - startTime;
        //        Console.WriteLine("Time taken to retrieve " + value + " from " + total + " dictionary is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //        startTime = sw.ElapsedMilliseconds;
        //        value = _col.GetHashtableValue(_hashTable, _randomKey);
        //        endTime = sw.ElapsedMilliseconds;
        //        deltaTime = endTime - startTime;
        //        Console.WriteLine("Time taken to retrieve " + value + " from " + total + " hashtable is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //        startTime = sw.ElapsedMilliseconds;
        //        value = _col.GetHashSetValue(_hashSet, _randomKey);
        //        endTime = sw.ElapsedMilliseconds;
        //        deltaTime = endTime - startTime;
        //        Console.WriteLine("Time taken to retrieve " + value + " from " + total + " hashset is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //        startTime = sw.ElapsedMilliseconds;
        //        value = _col.GetListValue(_list, _randomKey);
        //        endTime = sw.ElapsedMilliseconds;
        //        deltaTime = endTime - startTime;
        //        Console.WriteLine("Time taken to retrieve " + value + " from " + total + " list is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //        startTime = sw.ElapsedMilliseconds;
        //        value = _col.GetDictionaryObjectValue(_dictionaryObject, _randomKey);
        //        endTime = sw.ElapsedMilliseconds;
        //        deltaTime = endTime - startTime;
        //        Console.WriteLine("Time taken to retrieve " + value + " from " + total + " dictionary object is " + string.Format("{0:0.##}", deltaTime + "ms"));

        //        Console.WriteLine();
        //        cycle++;
        //    }
        //}
    }
}
