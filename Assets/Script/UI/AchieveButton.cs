using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AchieveButton : MonoBehaviour {
    public Text introText;
    public string intro;
    public int achieveId;
    void OnEnable()
    {
        if (PlayerPrefs.GetInt("Achieve" + achieveId, 0) == 0)
        {
            GetComponent<Image>().color = new Color(0.4f,0.4f,0.4f);
            intro = "You haven't got this achievement";
        }
    }
	public void showIntro()
    {
        introText.text=intro;
    }
}
