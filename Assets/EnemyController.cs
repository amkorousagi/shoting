using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject[] enemies;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(makeEnemyCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator makeEnemyCoroutine()
    {
        while (true)
        {
            GameObject go = GameObject.Instantiate(enemies[Mathf.FloorToInt(Random.Range(0, 3))]);
            go.SetActive(true);
            go.transform.position = new Vector3(Random.Range(-2, 2), 7, 0);
            go.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -100));
            yield return new WaitForSeconds(Random.Range(1, 5));
        }
    }
}
