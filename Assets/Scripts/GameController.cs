using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    List<GameObject> enemies = new List<GameObject>();
    
    [SerializeField]
    List<Enemy> enemies_ofTypeEnemy = new List<Enemy>();
    
    [SerializeField]
    private GameObject hero;

    [SerializeField]
    private GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        hero = GameObject.FindGameObjectWithTag("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfSpawnButtonIsPressed();
    }

    void CheckIfSpawnButtonIsPressed()
    {
        if (Input.GetKeyDown("p"))
        {
            Instantiate(enemy, new Vector3(0, 10, 0), Quaternion.identity);
        }
    }
}
