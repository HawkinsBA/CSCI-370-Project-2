using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOrbs : MonoBehaviour
{
    public GameObject goal;
    public GameObject jump;
    public GameObject speed;
    public GameObject rain;
    public GameObject raining;
    public GameObject fps;

    public Vector3 v1 = new Vector3(108f, 42f, 104f);
    public Vector3 v2 = new Vector3(147f, 3f, 18f);
    public Vector3 v3 = new Vector3(311f, 34f, 39f);
    public Vector3 v4 = new Vector3(360f, 53f, 67f);
    public Vector3 v5 = new Vector3(375f, 53f, 43f);
    public Vector3 v6 = new Vector3(478f, 3f, 118f);
    public Vector3 v7 = new Vector3(417f, 13f, 186f);
    public Vector3 v8 = new Vector3(53f, 6f, 291f);
    public Vector3 v9 = new Vector3(187f, 30f, 143f);
    public Vector3 v10 = new Vector3(433f, 80f, 50f);

    private Vector3 pos1;
    private Vector3 pos2;
    private Vector3 pos3;

    public Vector3 bonus = new Vector3(403f, 1f, 381f);

    private List<GameObject> orbs = new List<GameObject>();
    private List<Vector3> positions = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();
        int rand = rnd.Next(0,3);
        orbs.Add(jump);
        orbs.Add(speed);
        orbs.Add(rain);
        positions.Add(v1);
        positions.Add(v2);
        positions.Add(v3);
        positions.Add(v4);
        positions.Add(v5);
        positions.Add(v6);
        positions.Add(v7);
        positions.Add(v8);
        positions.Add(v9);
        positions.Add(v10);
        orbs[rand].transform.position = bonus;
        orbs.Remove(orbs[rand]);
        orbs.Add(goal);
        int rand2 = rnd.Next(0, 9);
        orbs[0].transform.position = positions[rand2];
        positions.Remove(positions[rand2]);
        int rand3 = rnd.Next(0, 8);
        orbs[1].transform.position = positions[rand3];
        positions.Remove(positions[rand3]);
        int rand4 = rnd.Next(0, 7);
        orbs[2].transform.position = positions[rand4];
        positions.Remove(positions[rand4]);


    }

    // Update is called once per frame
    void Update()
    { }

   
}
