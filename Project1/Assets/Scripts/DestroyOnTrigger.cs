using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
  public GameObject destroyObj;
  public void Destroy()
  {
    Destroy(destroyObj);
  }
}
