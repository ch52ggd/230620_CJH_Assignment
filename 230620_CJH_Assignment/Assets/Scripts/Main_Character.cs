using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{    
    List<Character> characterList;

    // Start is called before the first frame update
    void Start()
    {
        characterList = new List<Character>();

        //List<Character> character = new List<Character>();

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

        CreateCharacter(new Character("이름1", "직업1", 10, 10));
        CreateCharacter(new Character("이름2", "직업2", 10, 10));
        CreateCharacter(new Character("이름3", "직업3", 10, 10));
        CreateCharacter(new Character("이름4", "직업4", 10, 10));

        PrintAllCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreateCharacter(Character c) //매개변수 이름은 딱히 상관 없음
    {
        characterList.Add(c);
    }

    public void RemoveCharacter(int index)
    {
        characterList.RemoveAt(index);
    }

    public void PrintAllCharacter()
    {
        int i = 0;

        if(characterList.Count == 0)
        {
            Debug.Log("비어있다");
        }
        else
        {
            while (i <= characterList.Count)
            {
                characterList[i].GetInfo();
                i++;
            }
        }
    }
}
