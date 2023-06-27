using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public enum EnemyType{
        Basic = 0, //그냥 내려오는 애
        Range, //내려오면서 공격하는 애
    }

    EnemyType enemyType;

    //private string name;
    private int hp;
    private int atk;
    private float speed;


    public Enemy(EnemyType type, int hp, int atk, float speed)
    {
        this.enemyType = type;
        //this.name = name;
        this.hp = hp;
        this.atk = atk;
        this.speed = speed;
    }


    public void GetEnemyInfo()
    {
        //Debug.Log($"Name : {this.name} hp : {this.hp}");
    }


    public int HP
    {
        get { return hp; }
    }

    public int ATK
    {
        get { return atk; }
    }

    public float Speed
    {
        get { return speed; }
    }

    /* Hit를 bool로 선언한건 얘가 죽었다는걸 판단하기 위해
     * 
     */
    public bool Hit(int dmg)
    {
        if(this.hp - dmg <= 0)
        {
            return false;
        }

        this.hp -= dmg;

        return true;
    }
}
