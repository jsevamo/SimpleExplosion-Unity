using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    List<GameObject> enemies = new List<GameObject>();
    
    [SerializeField]
    List<Enemy> enemies_ofTypeEnemy = new List<Enemy>();
    
    [SerializeField]
    private GameObject heroGameObject; 
    private Hero hero;

    [SerializeField]
    private GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        heroGameObject = GameObject.FindGameObjectWithTag("Hero");
        hero = heroGameObject.GetComponent<Hero>();
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
        CheckIfHeroHasBeenClicked();

    }

    void SpawnEnemy()
    {
        if (Input.GetKeyDown("p"))
        {
            GameObject enemyInstantiate = Instantiate(enemy, new Vector3(Random.Range(-5.0f, 5.0f), 3, Random.Range(-5.0f, 5.0f)), Quaternion.identity);
            enemies.Add(enemyInstantiate);

            Enemy e = enemyInstantiate.GetComponent<Enemy>();
            enemies_ofTypeEnemy.Add(e);
        }
    }

    void CheckIfHeroHasBeenClicked()
    {
        if (enemies.Count > 0)
        {
            if (Input.GetMouseButtonDown(0)) {
           
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
            
                if(Physics.Raycast(ray, out hit))
                {
                    if(hit.transform.name == "Hero")
                    {
                        for (int i = 0; i < enemies.Count; i++)
                        {
                            Enemy e = enemies_ofTypeEnemy[i];
                            e.Explode();
                        }
                    }
                }
            
            }
        }
        
        
    }
}
