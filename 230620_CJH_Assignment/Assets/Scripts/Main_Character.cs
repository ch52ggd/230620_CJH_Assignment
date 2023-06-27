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

        CreateCharacter(new Character("�̸�1", "����1", 10, 10));
        CreateCharacter(new Character("�̸�2", "����2", 10, 10));
        CreateCharacter(new Character("�̸�3", "����3", 10, 10));
        CreateCharacter(new Character("�̸�4", "����4", 10, 10));

        PrintAllCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CreateCharacter(Character c) //�Ű����� �̸��� ���� ��� ����
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
            Debug.Log("����ִ�");
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
