using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class Main : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        Enemy e1 = new Enemy("주황버섯", 10);
        Enemy e2 = new Enemy("머쉬맘", 100);

        e1.GetEnemyInfo();
        e2.GetEnemyInfo();



        List<Character> character = new List<Character>();

        /*
        character.Add(new Character("이름1", "직업1", 10, 10));
        character.Add(new Character("이름2", "직업2", 20, 20));
        character.Add(new Character("이름3", "직업3", 30, 30));
        character.Add(new Character("이름4", "직업4", 40, 40));
        character.Add(new Character("이름5", "직업5", 50, 50));

        
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
