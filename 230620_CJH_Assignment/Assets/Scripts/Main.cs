using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Enemy e1 = new Enemy("��Ȳ����", 10);
        Enemy e2 = new Enemy("�ӽ���", 100);

        e1.GetEnemyInfo();
        e2.GetEnemyInfo();



        List<Character> c;

        c.Add(new Character("�̸�1", "����1", 10, 10));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateCharacter()
    {

    }

    void RemoveCracter()
    {

    }

    void PrintAllCharacter()
    {

    }
}
