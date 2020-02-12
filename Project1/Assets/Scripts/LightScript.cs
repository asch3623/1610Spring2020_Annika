using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightScript : MonoBehaviour
{
    private Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
        myLight.intensity = 0f;
    }

    void Update()
    {
        
    }
}
