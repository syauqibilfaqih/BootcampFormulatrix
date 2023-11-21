# Day 7 Materials

- Generic + Constraint
- Exception & Handling

## Generic 
Make a place-holder so a class's data type can be customized by the user. Typically using < T > (without space).
```
public class SetGet<T>{
    private T _data;
    public T value{
		get
	    {
	        return this._data;
	    }
	    set
	    {
	        this._data = value;
	    } 
	}
}
```

## Generic Constrain
There would be a problem if the generic is too general. For example:
```
public class Calculator<T>{

	public T Add(T a, T b)
	{
	 return a + b;
	}
}
```
T has too much probability, it could be string, which is a problem to have operator "add". As solution, we can
make a constrain for it:
```
class Calculator<T> where T : IAdditionOperators<T,T,T>
{
	public static T Add(T a, T b)
	{
	 return a + b;
	}
}
```
IAdditionOperators is an interface to make a constraint for which data types compatile to the class and method.

## Exception Handling