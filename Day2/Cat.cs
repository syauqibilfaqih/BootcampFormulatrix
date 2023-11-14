namespace Animal;

public class Cat
{
	public string colour;
	public int age;
	public bool isMale;
	public float weight;
	
	public Cat(string colour, int age, bool isMale, float weight)
	{
		this.colour = colour;
		this.age = age;
		this.isMale = isMale;
		this.weight = weight;
	}
	public Cat()
	
	{
		this.colour="No parameter inserted";
		this.age=0;
		this.isMale=false;
		this.weight=0.0F;
	} 
	public void Eat(string food)
	{
		Console.WriteLine($"Cat eating {food}");
	} 
	public void Sleep()
	{
		Console.WriteLine("ZZZZZZZ");
	} 
	public void Chaos()
	{
		Console.WriteLine("KJNDCKJNDSKJNDSK");
	} 
	public void Meow()
	{
		Console.WriteLine("Meow");
	} 
}