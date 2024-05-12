using System;

public class Candidate
{
    public int number {  get; private set; }
    public string name { get; private set; }
    public string party { get; private set; }
    public Position position { get; private set; }

    public Candidate(int number, string name, string party, Position position)
	{
        this.number = number;
        this.name = name;
        this.party = party;
        this.position = position;
	}
}
