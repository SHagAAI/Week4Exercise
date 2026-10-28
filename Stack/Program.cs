using Stack;

StackWeek4 myStack = new StackWeek4();

myStack.AddRule(word => !string.IsNullOrWhiteSpace(word));
myStack.AddRule(word => word.Length <= 10);

myStack.TypeV2("hello");
myStack.TypeV2("");
