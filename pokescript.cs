/*
Made with a taste of love

Based on https://bulbapedia.bulbagarden.net/wiki/Statistic
*/
// Acaba este programa
public class PokemonClass
{	
	#Information
	private int _number;
	private string _name;
	private int defaultAccuracy = 100;
	private int defaultEvasion = 100;
	
	#Permanent stats
	public float hitPoints { get; set;}
	public int defense { get; set;}
	public int attack { get; set;}
	public int specialAttack { get; set;}
	public int specialDefense { get; set;}
	public int speed { get; set;}
	#In-Battle Stats
	public int evasion { get; set;}
	public int accuracy { get; set;}
	
	#Base stats
	public int level;
	public int nature;
	public Dictionary<int, int> individualValues;
	public Dictionary<int, int> effortValues;
	
	private enum permanentStatName
	{
		hitPoints,
		defense,
		attack,
		specialAttack,
		specialDefense,
		speed
	}
	
	public int number
	{
		get { return _number;}		
		set { _number = value}		
	}
	
	public int name
	{
		get { return _name;}		
		set { _name = value}
	}
	
	public void defineValues()
	{
		_number = -1
		
		hitPoints = 0.0f
		attack = 0
		defense = 0
		specialAttack = 0
		specialDefense = 0
		speed = 1
		
		evasion = defaultEvasion
		accuracy = defaultAccuracy
		
		individualValues = new Dictionary<int, int>(){
			{permanentStatName.hitPoints , 1},
			{permanentStatName.attack, 1},
			{permanentStatName.defense, 1},
			{permanentStatName.specialAttack, 1},
			{permanentStatName.specialDefense, 1},
			{permanentStatName.speed, 1}
		}
		
		effortValues = new Dictionary<int, int>(){
			{permanentStatName.hitPoints , 1},
			{permanentStatName.attack, 1},
			{permanentStatName.defense, 1},
			{permanentStatName.specialAttack, 1},
			{permanentStatName.specialDefense, 1},
			{permanentStatName.speed, 1}
		}
	}
	
	public PokemonClass(){
		defineValues()
	}
}

class Pokemon: PokemonClass
{
	public override string ToString()
	{
		return this.GetType().Name
	}
}