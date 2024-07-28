FACADE:
======

It is a Structural Pattern.

It provides a simplified interface to a complex subsystem, making it easier for clients to interact with. 

ECommerce Order Placing:
=======================

Placing an Order involves multiple steps such as
1. Check the product availability
2. Reserve product
3. Validate deliery service availability
4. Validate Payment
5. Calcutate tax
6. Generate Invoice

But to the client we just give PlaceOrder method they no need to worry about our internal activites.