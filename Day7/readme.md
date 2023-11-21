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

## Exception Handling