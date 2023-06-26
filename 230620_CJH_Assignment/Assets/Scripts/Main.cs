using System.Collections;
using System.Collections.Generic;
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



        List<Character> c;

        c.Add(new Character("이름1", "직업1", 10, 10));

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
