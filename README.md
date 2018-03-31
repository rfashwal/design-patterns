# Design Patterns Simplified

## Introduction

As a developer, when you hear the term Design Patterns you get overwhelmed and frustrated.
In this series of stories, we will try together to emphasize and explain Design Patterns in a simplified way where you will discover through this journey that Design Patterns in not complicated as it sounds.
In nutshell, What is a Design Pattern?
Design pattern is not a framework or a ready to implement code. However, it is a solution for software design problems. In other words, it is a template that can be used in different situations to solve software design problem.

### Design Patterns Founders — GoF

GoF or Gang of Four are the founders of Design Patterns and the authors of book Design Patterns: Elements of Reusable Object-Oriented Software.
The founders are Erich Gamma, Richard Helm, Ralph Johnson and John Vlissides. 
Why learn and use Design Patterns
They act as a universal language that developers and technical experts can use to communicate at a high level software design.
They are proven solutions for software design problems. So you don’t need to reinvent the wheel.
By using design patterns, you are building software solutions with maintainable code and high level architecture.
Finally, it will change your way of thinking when designing and building software applications. Also, you will upgrade and improve your object oriented skills.
```
```
### Prerequisites 
Before you dive into the concepts and start learning about Design Patterns, you should have: 
Knowledge with at least one Object Oriented Programming language (C++, Java, C#, etc…)
A good grasp and foundation in Object Oriented Concepts.
A will to make mistakes and learn.

Check my story for Object Oriented Concepts Refresher.


## Design Patterns Categories

There are 23 Design Patterns as defined by GoF that are divided into three main categories depending on their intention and usage.
Don’t be overwhelmed by their count. We will cover only the most used patterns. Some patterns are rarely if not barely used. 

### Behavioral Patterns

* **Strategy:** Encapsulate algorithms within a class and make them interchangeable
* **Observer:** Notify dependent objects of state changes
* **State:** Change object behavior depending on its state
* **Iterator:** Give sequential access to elements in a collection
* **Chain of Responsibility:** Pass requests between command and processing objects within a chain of objects
* **Command:** Encapsulate a method call as an object containing all necessary information
* **Interpreter:** Include language elements and evaluate sentences in a given language
* **Mediator:** Encapsulates and simplifies communication between objects
* **Memento:** Undo modifications and restore an object to its initial state
* **Template Method:** Define an algorithm skeleton and delegate algorithm steps to subclasses so that they may be overridden
* **Visitor:** Add new operations to classes without modifying them

### Creational Patterns

* **Abstract Factory Pattern:** Create instances of classes belonging to different families
* **Singleton Pattern:** Class with only one single possible instance
* **Builder Pattern:** Separate representation and object construction
* **Factory Method Pattern:** Create instances of derived classes
* **Prototype Pattern:** Clone or copy initialized instances

### Structural Patterns
* **Adapter Pattern:** Match interfaces of classes with different interfaces
* **Bridge Pattern:** Separate implementation and object interfaces
* **Composite:** Simple and composite objects tree
* **Decorator:** Dynamically add responsibilities to objects
* **Facade:** Class that represents sub-classes and subsystems
* **Flyweight:** Minimize memory usage by sharing as much data as possible with similar objects
* **Proxy:** Object that represents another object
