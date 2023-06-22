using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private string name;
    private int hp;


    public Enemy(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }


    public void GetEnemyInfo()
    {
        UnityEngine.Debug.Log($"Name : {this.name} hp : {this.hp}");
        //Debug.Log($"Name : {this.name} hp : {this.hp} attack : {this.attack}");
    }
}
