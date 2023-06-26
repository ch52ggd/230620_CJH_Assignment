using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Character
{
    private string name;
    private string job;
    private int hp;
    private int atk;

    public string Name { get { return name; } set { } }
    public string Job { get { return job; } set { } }
    public int HP { get { return hp; } set { } }
    public int Atk { get {  return atk; } set { } }

    public Character(string name, string job, int hp, int atk)
    {
        Name = name;
        Job = job;
        HP = hp;
        Atk = atk;
    }

    void GetInfo()
    {
        Debug.Log($"Name : {Name} Job : {Job} HP : {HP} Atk : {Atk}");
    }
}
