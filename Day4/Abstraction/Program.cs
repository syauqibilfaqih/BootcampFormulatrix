class Program {
	static void Main() {
		RumahMewah rm = new RumahMewah();
		RumahBiasa rb = new RumahBiasa();
		RumahSederhana rs = new RumahSederhana();
		
		Rumah rumah = rb;
		rumah.BukaPintu();
		
		RumahDuaLantai rdl = new RumahDuaLantai();
		Rumah rumahbaru = rdl;
		rumahbaru.BukaPintu();
		rumahbaru.TutupPintu();
		
		// RumahSatuLantai rsl = new RumahSatuLantai();
		// rsl.TutupPintu();
	}
}
abstract class Rumah
{
	public readonly int i;
	public void BukaJendela() {
		"Buka jendela".Dump();
	}
	public virtual void BukaGarasi() {
		"Keatas".Dump();
	}
	public abstract void BukaPintu();
	public abstract void TutupPintu();
}

abstract class RumahSatuLantai:Rumah
{
	public override void TutupPintu()
	{
		"Putar Kanan".Dump();
	}
}

class RumahDuaLantai : RumahSatuLantai
{
	public override void TutupPintu()
	{
		"Putar Dua Arah".Dump();
	}
	
	public override void BukaPintu()
	{
		"Putar Kiri".Dump();
	}
}

class RumahMewah : Rumah
{
	public override void BukaPintu() {
		"Keatas".Dump();
	}

	public override void TutupPintu()
	{
		"Kebawah".Dump();
	}
}
class RumahBiasa : Rumah
{
	public override void BukaPintu()
	{
		"Kedepan".Dump();
	}

	public override void TutupPintu()
	{
		"Kebelakang".Dump();
	}
}
class RumahSederhana : Rumah
{
	public override void BukaPintu()
	{
		"Gorden".Dump();
	}

	public override void TutupPintu()
	{
	   "Geser".Dump();
	}
}

public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}