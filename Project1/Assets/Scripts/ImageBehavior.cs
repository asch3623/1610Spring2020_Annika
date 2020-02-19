using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehavior : MonoBehaviour
{
private Image newImage;
    void Start()
    {
        newImage = GetComponent<Image>();

    }
    
    void Update()
    {
        
    }
}
