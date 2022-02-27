
using UnityEngine;
using UnityEngine.Events;

public class VoiceButton : MonoBehaviour
{
    public UnityEvent upEvent;
    public UnityEvent downEvent;
    void OnMouseDown(){
        downEvent?.Invoke();
    }

    void OnMouseUp(){
        upEvent?.Invoke();

    }
}
