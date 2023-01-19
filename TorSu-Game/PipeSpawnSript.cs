using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnSript : MonoBehaviour
{
    public GameObject pipe;
    public float spwanRate = 4;
    private float timer = 0;
    public float heightOffset = 8;

  // Start is called before the first frame u
  //   pdate
    void Start()
    {
    PipeSpwan();
    }

    // Update is called once per frame
    void Update()
    {
      if (timer < spwanRate)
      {
        timer += Time.deltaTime;
      }else
      {
        PipeSpwan();
        timer = 0;
      }
    }

    void PipeSpwan()
    {
      float lowestPoint = transform.position.y - heightOffset;
      float heighestPoint = transform.position.y + heightOffset;

      Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}
