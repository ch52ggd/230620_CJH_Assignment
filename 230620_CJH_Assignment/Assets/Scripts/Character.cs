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

    public Character(string name, string job, int hp, int atk)
    {
        name = this.name;
        job = this.job;
        hp = this.hp;
        atk = this.atk;
    }

    public void GetInfo()
    {
        Debug.Log($"Name : {this.name} Job : {this.job} HP : {this.hp} Atk : {this.atk}");
    }
}
