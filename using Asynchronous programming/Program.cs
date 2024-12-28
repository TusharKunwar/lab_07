using Asynchronous_programming;

AsyncTest AT = new AsyncTest();

// Call methodOne asynchronously and await its completion
var methodOneTask = AT.methodOne();


// Call methodTwo immediately without waiting
AT.methodTwo();

// Await MethodOne to ensure its completion
await methodOneTask;