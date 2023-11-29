# Day 8 Materials

- Delegate
- Event
- Tuple

## Delegate 
- Custom Delegate
- .Net C# -> Event Handler, Func, Action

### Action
Provided delegate void with parameters

### Func
It's delegate with return type

## Event
As precaution when using delegate so the data will be kept properly.
```
public event EventHandler subs;
```
After this, the instance won't get any new data unless using "+=" operator instead of "=".

## Tuple
Data structure that contains a sequence of elements of different data types.
```
class Calculator {
	public static (bool, int) Add(int a, int b) {
		if (a+b > 0) {
			return (true, a+b);
		}
		return (false, 0);
	}
}
```
