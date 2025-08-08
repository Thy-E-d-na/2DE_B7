using System.Collections;
using UnityEngine;

public class gameContrller : MonoBehaviour
{
    private void Awake()
    {
        SoundManager.instance.PlayBGM(1);
    }
}
