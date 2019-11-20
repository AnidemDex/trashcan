/*
Made with a taste of love

Based on https://bulbapedia.bulbagarden.net/wiki/Statistic
*/
// Acaba este programa
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

public class PetClass
{	
	private int defaultAccuracy = 100;
	private int defaultEvasion = 100;
	
	#In-Battle Stats
	public int evasion { get; set;}
	public int accuracy { get; set;}
	
	#Base stats
	
	private enum permanentStatName
	{
		hitPoints,
		defense,
		attack,
		specialAttack,
		specialDefense,
		speed
	}
}

class Pet: PokemonClass
{
	public override string ToString()
	{
		return this.GetType().Name
	}
}