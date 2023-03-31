using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.Toast;

public class ToastController : MonoBehaviour
{
    [Header("Message")]
    [SerializeField] string _message;

    [Header("Duration")]
    [SerializeField] float _duration;

    [Header("Color")]
    [SerializeField] Color _color;

    public void ShowToastonInspector()
    {
        Toast.Show(_message, _duration, _color);
    }

    public void ShowScriptToast(string message, float duration, Color color)
    {
        Toast.Show(message, duration, color);
    }
}
