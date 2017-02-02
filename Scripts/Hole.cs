using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {
    // Mole Prefab
    public GameObject mole;
    public float aliveTime = 2;
    
    // Spawn Interval
    public int intervalMin = 2;
    public int intervalMax = 10;
        
    // Use this for initialization
    void Start () {
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }
    
    void Spawn() {
        // Spawn the mole
        GameObject g = (GameObject)Instantiate(mole, transform.position, Quaternion.identity);
        
        // Make sure to destroy it after a few seconds
        Destroy(g, aliveTime);
        
        // Next Spawn
        Invoke("Spawn", Random.Range(intervalMin, intervalMax));
    }
}
