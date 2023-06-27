using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public enum EnemyType{
        Basic = 0, //�׳� �������� ��
        Range, //�������鼭 �����ϴ� ��
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

    /* Hit�� bool�� �����Ѱ� �갡 �׾��ٴ°� �Ǵ��ϱ� ����
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
