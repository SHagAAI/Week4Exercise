using CircularQueue;

CircularQWeek4 cq = new CircularQWeek4(); 


cq.SetCapacity(3);
cq.SetOverwritePolicy(true);


cq.Log(3);
cq.Log(4);
cq.Log(5);
cq.Log(7);
cq.Log(10);
cq.Read();
cq.Read();
cq.Read();
