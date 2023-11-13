using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public void Pause()
    {
        Time.timeScale = 0;
    }
}
