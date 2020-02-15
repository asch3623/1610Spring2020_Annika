using UnityEngine;
using Random = UnityEngine.Random;

public class RandomRangeScript : MonoBehaviour
{
    private int speed;
    private int i = 1;

    private Vector3 direction;
    // random number tutorial from HelloWorld Studios
    void Start()
    {
       
        speed = Random.Range(0,7);
        print(speed);
        direction = new Vector3(Random.Range(-3, 3), 0, Random.Range(-3, 3));
    }

    private void Update()
    {
        //while loops learned from Charger Games youtube video
         while (i <= 6)
                {
                    transform.Translate( direction * Time.deltaTime * speed);
                    print("the value of i is" + i);
                    i++;
                }

         print("stopped");
         transform.Translate(0, 0, 0);
    }

}
