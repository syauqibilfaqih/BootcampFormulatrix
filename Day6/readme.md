# Day 6 Material

- Object (Boxing & Unboxing + Pattern Matching)
- Dynamic
- Ref, in, out
- Static
- Properties
- Generic + Constraint
- Exception & Handling


## Object
### Object
        |-Boxing
        |-Unboxing
    
    int x = 3;
    object obj = 3; // Refine type. Boxing.

    object a = 3;
    object b = 5;

    (int)a + (int)b // Unboxing

    if(a is int inta) // Pattern Matching

## Dynamic
Dynamic will check a type of a variable at the runtime, whereas var check it at compile time. It's better to avoid the usage
of Dynamic since it would be heavier and longer for the runtime process.


