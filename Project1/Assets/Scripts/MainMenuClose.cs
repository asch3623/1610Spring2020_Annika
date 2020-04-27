using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class MainMenuClose : MonoBehaviour
{

    public Image menu;
    public Text starFinder;
    
    private void OnMouseUp()
    {
        enabled = false;
        starFinder.enabled = false;
        menu.enabled = false;
    }
    
}
