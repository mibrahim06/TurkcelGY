Open/Closed Principle(OCP)
Bertrand Meyer, the person who first wrote the term open/closed principle in 1988, says that:
"Sofware entities (classes, modules, functions, and so on) should be open for extension but closed for modification."
So, you should be capable of modifying the class behaviors externally without modifying the code itself. The most effective approach to achieve this is by constructing the application with numerous well-crafted code units, connected through dependency injection.

In this particular example, the primary goal in this context is to adeptly demonstrate the Open/Closed Principle, and to do so, I have developed a Metin2 item factory. This example thoughtfully incorporates an IItemFactory interface, which is specifically designed to facilitate the creation of new item types in a modular and scalable manner. In this specific implementation, I have chosen to focus on the creation of swords, armors, and shields.

However, the true power of the Open/Closed Principle lies in its flexibility and adaptability, allowing for the seamless integration of additional item types as needed. For example, if one were to expand the range of items in this factory to include helmets or boots, it could be accomplished without difficulty. This is due to the well-structured nature of the code, which adheres to the Open/Closed Principle, ensuring that the item factory remains both maintainable and extensible.

By employing the Open/Closed Principle in this example, we are not only able to demonstrate its practical application but also showcase its ability to improve the overall design of software systems. This principle encourages developers to create code that is both robust and flexible, enabling them to easily adapt to changing requirements and evolving needs.

![Output](output.png)
