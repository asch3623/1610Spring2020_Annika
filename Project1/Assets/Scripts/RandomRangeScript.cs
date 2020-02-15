using UnityEngine;
using Random = UnityEngine.Random;

public class RandomRangeScript : MonoBehaviour
{
    private int speed;

    private Vector3 direction;
    // tutorial from HelloWorld Studios
    void Start()
    {
        speed = Random.Range(0,7);
        print(speed);
        direction = new Vector3(Random.Range(-3, 3), 0, Random.Range(-3, 3));
    }

    private void Update()
    {
        transform.Translate( direction * Time.deltaTime * speed);
    }

}
