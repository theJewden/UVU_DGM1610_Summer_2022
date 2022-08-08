using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CorBehavior : MonoBehaviour
{

    public UnityEvent startEvent, repeatCountEvent, startCountEvent, endCountEvent, repeatUntilFalseEvent;

    
    public bool canRun;
    public float seconds = 1f;
    public Text countDown;
    public IntData2 counterNum;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    private void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();

        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }

    private IEnumerator Counting()
    {

        startCountEvent.Invoke();

        while(counterNum.value > -1)
        {
            Debug.Log(counterNum);
            if (counterNum.value > 0)
            {

                if (countDown != null)
                {
                    countDown.text = ("" + counterNum.value);
                }
                
            }
            else
            {

                if(countDown != null)
                {
                    countDown.text = "Go!";
                }
                endCountEvent.Invoke();
            }
            yield return wfsObj;
            repeatCountEvent.Invoke();

            counterNum.value--;
        }

    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while(canRun)
        {
            yield return wfsObj;
            repeatUntilFalseEvent.Invoke();
        }


    }

}
