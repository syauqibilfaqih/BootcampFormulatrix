# Day 8 Materials

- Delegate
- Event

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

