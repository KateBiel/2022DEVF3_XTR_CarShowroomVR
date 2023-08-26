using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShow : MonoBehaviour

    
{
    Renderer renderobj;
    bool isVisible;

    void Awake()
    {
        renderobj = GetComponent<Renderer>();
        
    }

    public void hideIt(Renderer renderobj)
    {
        
        renderobj.enabled = isVisible;

        //renderobj.enabled = !renderobj.enabled;
        //obj.SetActive(true);

    }
    public void showIt(Renderer renderobj)
    {
        renderobj.enabled = !isVisible;

        // renderobj.enabled = renderobj.enabled;
    }


}
