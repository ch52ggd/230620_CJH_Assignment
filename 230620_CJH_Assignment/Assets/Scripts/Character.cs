using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Character
{
    private string name;
    private string job;
    private int hp;
    private int atk;

    public string Name { get { return name; } set { name = value; } }
    public string Job { get { return job; } set { job = value; } }
    public int Hp { get { return hp; } set { hp = value; } }
    public int Atk { get { return atk; } set { atk = value; } }

    public Character(string name, string job, int hp, int atk)
    {
        Name = name;
        Job = job;
        Hp = hp;
        Atk = atk;
    }



    public void GetInfo()
    {
        Debug.Log($"Name : {this.name} Job : {this.job} HP : {this.hp} Atk : {this.atk}");
    }



    public void CreateCharacter(Character character)
    {
        /*
        character.Name = name;
        character.Job = job;
        character.Hp = hp;
        character.Atk = atk;
        */
    }



    public void RemoveCharacter(int index)
    {
        
    }



    public void PrintAllCharacter()
    {
        int a = 0;
        while (a < 5)
        {
            //GetInfo() ???
            a++;
        }
    }
}
