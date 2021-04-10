using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public float FadeInTime;

    Image fadeInPanel;

	// Use this for initialization
	void Start ()
    {
        fadeInPanel = GetComponent<Image>();	
	}

    // Update is called once per frame
    void Update ()
    {
        if (Time.timeSinceLevelLoad < FadeInTime)
        {
            var color = fadeInPanel.color;
            color.a -= Time.deltaTime / FadeInTime;
            fadeInPanel.color = color;
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
