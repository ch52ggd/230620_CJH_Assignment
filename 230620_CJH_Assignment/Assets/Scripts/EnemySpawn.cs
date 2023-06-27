using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity, this.transform);

        obj.transform.position = new Vector3(Random.Range(-2, 2), 5 + Random.Range(0, 3), 0);

        Enemy e = new Enemy(Enemy.EnemyType.Basic, 100, 10, 0.015f);

        obj.GetComponent<EnemyObject>().SetEnemy(e);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
