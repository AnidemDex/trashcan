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
using System;

[Serializable]
private class PetInfo {
	public int number;
	public string name;
	public int level;
	public int nature;

	public PetStats baseStats;
	public Stats stats;
	public PetIndividualValues ivs;
	public PetEffortValues evs;

	public float weight;
	public float height;

	public int base_experience;

	// El pokemon puede tener una sola habilidad segun las reglas. Lo que hace de esta lista
	// algo inutil
	public PetAbility[] ability; 
	public PetForm[] forms;
	public HeldItem item;

	public string[] location_areas;
	public string[] moves;

	// La pagina especifica que es una lista, pero un pokemon puede ser de uno o dos tipos
	public int type;
}

[Serializable]
private class Stats {
	public float hitPoints;
	public int attack;
	public int defense;
	public int specialAttack;
	public int specialDefense; 
	public int speed;
}

[Serializable]
private class PetStats {
	public Stats stats;
}

[Serializable]
private class PetIndividualValues {
	public Stats stats;
}

[Serializable]
private class PetEffortValues {
	public Stats stats;
}

/////////////////
// FIXME Añadir un mejor separador
// FIXME Implementar los valores de esta lista de clase
// https://pokeapi.co/docs/v2.html#pokemonability
[Serializable]
public class PetAbility {}

// FIXME Implementar los valores de esta lista de clase
// https://pokeapi.co/docs/v2.html#pokemonform
[Serializable]
public class PetForm {}

// FIXME Implementar los valores de esta lista de clase
// https://pokeapi.co/docs/v2.html#pokemonhelditem
[Serializable]
public class HeldItem {}

public class PetClass {
	private int defaultAccuracy = 100;
	private int defaultEvasion = 100;
	
	#In-Battle Stats
	public int evasion { get; set;}
	public int accuracy { get; set;}

	public PetInfo info;
	public GameObject model;
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