using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public GameObject  theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine (EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while(enemyCount < 10)
        {
            xPos = Random.Range(35, 38);
            zPos = Random.Range(39, 50);
            Instantiate(theEnemy,new Vector3(xPos,4,zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 2;
        }
    }
}
