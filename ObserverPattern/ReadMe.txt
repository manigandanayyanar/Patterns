The Observer Pattern is a behavioral design pattern in which an object, known as the subject, maintains a list of its dependents, called observers, 
and notifies them automatically of any state changes, usually by calling one of their methods. This pattern is mainly used to implement distributed event-handling systems.

Real-Time Example: Stock Price Updates
In this example, we'll demonstrate the Observer Pattern using a stock price update system where 
multiple observers (e.g., different clients) get notified whenever a stock price changes.