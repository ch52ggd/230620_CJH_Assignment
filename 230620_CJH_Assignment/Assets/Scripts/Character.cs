using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name;
    private string job;
    private int hp;
    private int atk;

        
    public Character(string name, string job, int hp, int atk)
    {
        Name = name;
        Job = job;
        Hp = hp;
        Atk = atk;
    }

    /*
    public string Name { get { return name; } set { name = value; } }
    public string Job { get { return job; } set { job = value; } }
    public int Hp { get { return hp; } set { hp = value; } }
    public int Atk { get { return atk; } set { atk = value; } }
    */


    public string Name { get { return this.name; } set { } }
    public string Job { get { return this.job; } set { } }
    public int Hp { get { return this.hp; } set { } }
    public int Atk { get { return this.atk; } set { } }


    /*
    public string Name
    {
        get { return this.name; }
    }

    public string Job
    {
        get { return this.job; }
    }

    public int Hp
    {
        get { return this.hp; }
    }

    public int Atk
    {
        get { return this.atk; }
    }
    */


    public void GetInfo()
    {
        Debug.Log($"Name : {this.name} Job : {this.job} HP : {this.hp} Atk : {this.atk}");
    }
}
