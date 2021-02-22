using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeCount : MonoBehaviour
{
    
    float timeleft = 375.0f;
    public TextMeshProUGUI text;



    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        text.SetText(Mathf.Round(timeleft) + "");
        

        if (timeleft < 0)
        {
            SceneManager.LoadScene("LevelParser");
        }
    }

    public void ResetTimer()
    {
        timeleft = 375.0f;
    }
}
