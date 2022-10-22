# 00-dotnet-tutorial
.NET tutorial
Goal
The Abstract Factory pattern is used to abstract the creation of a family of objects. It usually implies
the creation of multiple object types within that family. A family is a group of related or dependent
objects (classes).
Design
With Abstract Factory, the consumer asks for an abstract object and gets one. The factory is an
abstraction, and the resulting objects are also abstractions, decoupling the object creation from the
consumers.
That allows adding or removing families of objects produced together without impacting the consumers
(all actors communicate through abstractions).
In our case, the family (the object set the factory can produce) is composed of a car and a bike, and
each factory (family) must produce both of those objects.

![alt text]([https://github.com/9health/00-dotnet-tutorial/blob/DP-Abstract-Factory/DP-Abstract-factory.jpg?raw=true)
