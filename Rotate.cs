using UnityEngine;

public class Rotate : MonoBehaviour
{
    float minspeed = 1;
    float maxspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (minspeed <= 1000)
        {
            minspeed++;
            if (minspeed <= maxspeed)
            {
                minspeed = maxspeed;
            }
        }
        gameObject.transform.Rotate(0, 0, minspeed);
        
    }
}
