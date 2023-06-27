using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyObject : MonoBehaviour
{
    [SerializeField] private Sprite[] enemyImg;
    [SerializeField] private Slider hpbar;

    Enemy enemy;


    public void SetEnemy(Enemy e)
    {
        this.enemy = e;

        this.hpbar.maxValue = enemy.HP;
        this.hpbar.value = enemy.HP;
    }

    private void Start()
    {
        SetEnemy(new Enemy(Enemy.EnemyType.Basic, 100, 10, 0.015f));
    }

    private void Update()
    {
        if(enemy == null) return;
        MoveEnemy();
    }

    void MoveEnemy()
    {
        if(transform.position.y < -3)
        {
            //transform.Translate(0, 0, 0);
            transform.position = new Vector3(0, 2, 0);
        }
        else if(transform.position.y > -3)
        {
            transform.Translate(0, -enemy.Speed, 0);
        }

        /* �Ǽ��� ������ �� ������ �������� �ʾƼ� == ������ ��� X
         * <= �̰ų� >= �̰� ��� O
         */
    }
}
