using DataTypes;
using UnityEngine;
[RequireComponent(typeof(Transform))]
public class KillScript : MonoBehaviour
{
    public FloatData killCheck; 
    Transform player;
    public Transform spawnPoint;
    public Vector3Data checkPointPos;
    public IntData health;
    public BoolData isFlipped;
    private SpriteRenderer mySprite;
    public Transform spriteTransform;

    void Start()
    {
           player = GetComponent<Transform>();
           mySprite = GetComponentInChildren<SpriteRenderer>();
           

    }
    void Update()
    {

        if (killCheck.value <= 0)
        {
            isFlipped.value = false;
            spriteTransform.rotation = Quaternion.Euler(0, 0, 0);
            var temp = Physics2D.gravity;
            temp.y = -19.81f;
            Physics2D.gravity = temp;

            mySprite.flipY = false;
            
            player.transform.position = checkPointPos.value;
            print("I teleported");
            killCheck.value += 1;
            health.value--;
        }

        if (health.value == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
