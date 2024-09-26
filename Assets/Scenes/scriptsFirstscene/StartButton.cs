using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit; 

public class StartButton : MonoBehaviour
{
    public TriggerDetector TriggerDetector; 
    
    void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => operating());
    }
    
    void operating()
    { 
        TriggerDetector.start = true;
        Debug.Log(TriggerDetector.start);
    }
}
