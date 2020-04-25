using TMPro;
using UnityEngine;

public class Assets : MonoBehaviour
{
    private static Assets _i;

    public static Assets i
    {
        get
        {
            if (i == null) _i = (Instantiate(Resources.Load("Assets")) as GameObject).GetComponent<Assets>();
                return _i;
        }
    }

    public Transform DamagePopUp;
}
