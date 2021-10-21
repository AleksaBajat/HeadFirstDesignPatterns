# Head First Design Patterns
I'm going through the book and adding examples for said patterns.

1. Strategy Pattern - Identify the aspects of your application that vary and separate them from what stays the same.
2. Observer Pattern - Since we strive for loosely coupled designs between objects that interact, this pattern defines a one-to-many dependency between objects so that when one object changes the state, all its dependents are notified and updated automatically.
3. Decorator Pattern - This allows us to attach additional responsibilities to an object dynamically. Decorators in its core make our code open for extension but closed for modification, which is very useful for extending functionality.
4. Factory Pattern - Defines an interface for creating an object, but lets subclasses decide which class to instantiate. Practically speaking, it provides a certain class to relinquish its obligation to instantiate and delegate it to subclasses.
5. Singleton Pattern - Usually, when there is a class whose instantiation is expensive, and we only need one instance of it, we can use this pattern to ensure a class only has one instance and a global point of access.
6. Command Pattern - Essentially, this pattern gives us the ability to decouple an object making the requests from the objects that know how to perform the requests. For example, the remote is making a request, and items are performing the requested task, but we use commands, that encapsulate the request as an object, as an intermediary between them. Those commands let us apart from the obvious execution of the base item methods to create more complex interactions such as macros, undo, store, load, etc.
