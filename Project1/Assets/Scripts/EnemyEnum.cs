using UnityEngine;

public class EnemyEnum : MonoBehaviour
{
public enum EnemyType
    {
        normal,
        hard,
        ice
    }


    public EnemyType currentEnemyType;

    void Start()
    {
        switch (currentEnemyType)
        {
            case EnemyType.hard :
                break;
        }
    }
}
