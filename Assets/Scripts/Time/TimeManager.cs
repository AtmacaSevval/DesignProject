using System.Collections;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : Singleton<TimeManager>
{
    /*public int maxTime = 30;
    public float waitTime = 2f;
    
    private float _currentTime;
    
    public bool isTimeUp;

    public Slider slider;
    
    public void Update()
    {
        if (GameManager.Instance.paused || isTimeUp || PhotonNetwork.PlayerList.Length != 2 )
        {
            return;
        }
        _currentTime -= Time.deltaTime;

        if (_currentTime <= 0)
        {
            isTimeUp = true;
            RoundManager.Instance.SetRound();
        }
        if (!isTimeUp)
        {
            slider.value = _currentTime;
        }

    }
    public void AddTime(int timeValue)
    {
        _currentTime += timeValue;
        _currentTime = Mathf.Clamp(_currentTime, 0, maxTime);
    }

    public void ResetTimer()
    {
        StartCoroutine(ResetTimerRoutine());
    }

    IEnumerator ResetTimerRoutine()
    {
        GameManager.Instance.paused = true;
        isTimeUp = false;
        slider.maxValue = maxTime;
        slider.value = maxTime;
        _currentTime = maxTime;
        
        yield return new WaitForSeconds(waitTime);
        

        //Reset slider
        GameManager.Instance.paused = false;

    }*/
    
}
