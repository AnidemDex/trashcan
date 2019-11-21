/*
Made with a taste of love

Based on https://bulbapedia.bulbagarden.net/wiki/Statistic

{
	"PetInfo":
	{
		"number": ,
		"name": ,
		"level": ,
		"nature": ,
		"baseStats":
		{
			"stats":
			{
				...
			}
		},
		"stats":
		{
			"hitPoints":,
			"attack":,
			"defense":,
			"specialAttack":,
			"specialDefense":,
			"speed":
		},
		"ivs":
		{
			"stats":
			{
				...
			}
		},
		"evs":
		{
			"stats":
			{
				...
			}
		}
	}
}
*/
// FIXME esta sin acabar. Es probable que se vayan a añadir mas cosas

private class PetInfo {
	public int number;
	public string name;
	public int level;
	public int nature;

	public PetStats baseStats;
	public Stats stats;
	public PetIndividualValues ivs;
	public PetEffortValues evs;
}

private class Stats {
	public float hitPoints;
	public int attack;
	public int defense;
	public int specialAttack;
	public int specialDefense; 
	public int speed;
}

private class PetStats {
	public Stats stats;
}

private class PetIndividualValues {
	public Stats stats;
}

private class PetEffortValues {
	public Stats stats;
}

public class PetClass {
	private int defaultAccuracy = 100;
	private int defaultEvasion = 100;
	
	#In-Battle Stats
	public int evasion { get; set;}
	public int accuracy { get; set;}

	public PetInfo info;
}

class Pet: PetClass {

	public Pet () {
		info = new PetInfo()
	}

	public override string ToString()
	{
		return this.GetType().Name
	}
}