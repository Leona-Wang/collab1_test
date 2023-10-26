using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] drops;
    float createTime = 1f;
    GameObject fall;


    public void SpawnNext()
	{
        int rand = Random.Range(0, drops.Length);

        fall = Instantiate<GameObject>(drops[rand]);
        fall.transform.position= new Vector3(Random.Range(-23, 23), 20, 0);


    }

    
    // Start is called before the first frame update
    void Start()
    {
        SpawnNext();
    }

    // Update is called once per frame
    void Update()
    {
        createTime -= Time.deltaTime;

        if (createTime <= 0)
		{
            createTime = Random.Range(1, 3);
            SpawnNext();
		}
    }
}
