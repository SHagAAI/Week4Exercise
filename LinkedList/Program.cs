using LinkedList;

var myList = new MyLinkedList();
foreach (var n in new[] { 5, 12, 3, 8, 20, 7 }) myList.Append(n);

myList.Print();                                  // 5, 12, 3, 8, 20, 7
myList.SetSorting((a, b) => b.CompareTo(a));
myList.Print();                                  // 20, 12, 8, 7, 5, 3
myList.AddFilter(x => x % 2 == 0);
myList.Print();    