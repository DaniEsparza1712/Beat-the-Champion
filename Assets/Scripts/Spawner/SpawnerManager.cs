using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public Spawner[] spawnerArray;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnCoroutine");
    }

    private void Spawn(){
        int spawnerID = Random.Range(0, spawnerArray.Length);
        GameObject objToSpawn = spawnerArray[spawnerID].SpawnObject();
        
        if(objToSpawn){
            Vector3 newPos = new Vector3(transform.position.x + Random.Range(-5,5), transform.position.y, transform.position.z);
            ParticleSystem appearFX = spawnerArray[spawnerID].appearParticles;
            Instantiate(appearFX, newPos, Quaternion.identity);
            objToSpawn.transform.position = newPos;
            objToSpawn.transform.rotation = transform.rotation;
        }
    }

    public IEnumerator SpawnCoroutine(){
        while(true){
            yield return new WaitForSeconds(waitTime);
            Spawn();
        }
    }
}
