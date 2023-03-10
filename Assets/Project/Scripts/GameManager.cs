using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float SpawnCount;
    int RandomSpawn;
    public  Transform[] waypoints;
    public Transform[] SpawnPoint;
    public GameObject[] Zombie;
    public float ZombieAlive;
    [SerializeField]float ZombieAliveCount;
    [Space(10f)]
    public Transform[] SpawnPointPlayer;

    // Start is called before the first frame update
    void Awake()
    {
        RandomSpawn = Random.Range(0, SpawnPoint.Length);

        for (int i = 0; i < SpawnCount; i++)
        {
            Instantiate(Zombie[Random.Range(0, Zombie.Length)], SpawnPoint[RandomSpawn].position, SpawnPoint[RandomSpawn].rotation);
            ZombieAliveCount = ZombieAlive;
        }

    }

    private void Update()
    {
        if (ZombieAliveCount > ZombieAlive)
        {
            Instantiate(Zombie[Random.Range(0, Zombie.Length)], SpawnPoint[Random.Range(0, SpawnPoint.Length)].position, transform.rotation);
        }
    }
}
