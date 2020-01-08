using UnityEngine;
using System.Collections;

public class AchieveTrigger: MonoBehaviour {
    public int achieveId;


   public static void getAchieve(int id)
    {
        if (PlayerPrefs.GetInt("Achieve" + id, 0) == 0)
        {
            Instantiate(Resources.Load("AchieveLabels/AchieveLabel" + id), Vector3.zero, Quaternion.identity);
            PlayerPrefs.SetInt("Achieve" + id, 1);
        }
    }
	void OnTriggerEnter2D()
    {
        getAchieve(achieveId);
    }
}
