using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
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



        List<Character> character = new List<Character>();

        /*
        character.Add(new Character("�̸�1", "����1", 10, 10));
        character.Add(new Character("�̸�2", "����2", 20, 20));
        character.Add(new Character("�̸�3", "����3", 30, 30));
        character.Add(new Character("�̸�4", "����4", 40, 40));
        character.Add(new Character("�̸�5", "����5", 50, 50));

        
        int i = 0;
        while(i < character.Count)
        {
            character[i].GetInfo();
            i++;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
