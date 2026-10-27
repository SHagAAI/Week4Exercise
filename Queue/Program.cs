using Queue;

// List<QueuePriority> queue = [];
// void Enqueue(char element, int p)
// {
//     Console.WriteLine($"Queued {element} with priority {p}");
//     queue.Add(new QueuePriority(lttr:element, p:p));
// }

// void Process()
// {
//     // loop ? hash ?
//     QueuePriority bigPriority = new QueuePriority('z', -1);
//     for (int i = 0; i < queue.Count; i++)
//     {
//         if (queue[i].priority > bigPriority.priority)
//         {
//             bigPriority = queue[i];
//         }
//     }

//     Console.WriteLine($"Processed {bigPriority.letter}");
//     queue.Remove(bigPriority);

// }


// Enqueue('A', 1);
// Enqueue('D', 50);
// Enqueue('B', 5);
// Enqueue('C', 5);

// Process();
// Process();
// Process();


QueuePriority qp = new();
qp.AddRule("normal", 5);
qp.AddRule("urgent", 15);
qp.AddRule("immediately", 10);
qp.AddRule("asap", 20);



qp.Enqueue("normal but not good");
qp.Enqueue("lunch");
qp.Enqueue("request back up asap");
qp.Enqueue("world");
qp.Enqueue("urgent, please call");
qp.Enqueue("go to headmaster room immediately");
qp.Enqueue("hello");


qp.Process();
qp.Process();
qp.Process();
qp.Process();
qp.Process();
qp.Process();
qp.Process();