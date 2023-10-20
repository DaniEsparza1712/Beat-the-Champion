using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    public ParticleSystem appearParticles;

    private void Start() {
        pooledObjects = new List<GameObject>();
        for(int i = 0; i < amountToPool; i++){
            GameObject obj = Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject SpawnObject(){
        for(int i = 0; i < pooledObjects.Count; i++){
            if(!pooledObjects[i].activeInHierarchy){
                pooledObjects[i].SetActive(true);
                return pooledObjects[i];
            }
        }
        return null;
    }
}
