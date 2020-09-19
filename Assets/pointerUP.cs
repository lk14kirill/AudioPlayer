using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pointerUP : MonoBehaviour, IPointerUpHandler
{
    public AudioClip click;
    public AudioSource audioSource;
    public void OnPointerUp(PointerEventData eventData)
    {
        audioSource.PlayOneShot(click);
    }
}
