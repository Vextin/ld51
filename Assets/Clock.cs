using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public delegate void TenSecondDel();
    public event TenSecondDel TenSecondEvent;
    float seconds;
    const float TIMER = 10;

    // Start is called before the first frame update
    void Start()
    {
        seconds = 0f;   
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds > TIMER)
        {
            seconds -= TIMER;
            TenSecondEvent?.Invoke();
        }
    }
}
