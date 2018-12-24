using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] items; // referencing to what to spawn;
    public GameObject testObj;
    public float spawnTime; // how long before spawning each items
    public float min;
    public float max;
    public int selectedIndex;
    public float randomX;

    // Start is called before the first frame update
    void Start()
    {
        BoxCollider m_Collider = GetComponent<BoxCollider>();
        float width = m_Collider.size.x * transform.localScale.x;
        min = this.gameObject.transform.position.x - (width / 2);
        max = this.gameObject.transform.position.x + (width / 2);
        
    }

    public void spawn()
    {
        randomX = Random.Range(min, max);
        float y = this.gameObject.transform.position.y;
        Vector3 newPosition = new Vector3(randomX, y, 0);

        selectedIndex = Random.RandomRange(0, 2 + 1);
        Debug.Log(items.Length);

        GameObject prefab = Instantiate(items[selectedIndex]);
        prefab.transform.rotation = Quaternion.identity;
        prefab.transform.SetPositionAndRotation(newPosition, prefab.transform.rotation);
    }
    
}
