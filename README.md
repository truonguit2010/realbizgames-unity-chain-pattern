# RealbizGames Unity Common Chain Pattern

## 1. Introduction
In this repo, we're going to take a look at a widely used behavioral design pattern: Chain of Responsibility.

## 2. Chain of Responsibility
[Wikipedia](https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern) defines Chain of Responsibility as a design pattern consisting of “a source of command objects and a series of processing objects”.

Each processing object in the chain is responsible for a certain type of command, and the processing is done, it forwards the command to the next processor in the chain.

The Chain of Responsibility pattern is handy for:
- Decoupling a sender and receiver of a command
- Picking a processing strategy at processing-time

## 3. Example

So, let’s see a simple example of the pattern in my Unity Game project.

![Alt text](How_To_Use_Chain_Pattern.png?raw=true "Optional Title")

## 4. What does it help?
1. Remove complex logics.
2. Easy to re-order the execution chain.
3. Easy to add-more/remove a Piece to this chain for suppoting more 3rd-party without changing older code.

## 5. Supported Features
- Support Sync Chain.
- Support Async Chain with Coroutine.

## 6. More Design Patterns 

1. Chain of Responsibility pattern
2. Proxy pattern
3. Adapter pattern
4. Facade pattern
5. Decorator pattern
6. Saga pattern (Orchestration-based saga) for distributed transactions
7. Reactive Design Patterns

# References:
1. [How to build a unity package that share through Github](https://github.com/OmiyaGames/template-unity-package)
2. [Java Baeldung SpringBoot Chain of Responsibility Design Pattern](https://www.baeldung.com/chain-of-responsibility-pattern)
