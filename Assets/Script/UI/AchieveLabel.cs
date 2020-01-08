using UnityEngine;
using System.Collections;

public class AchieveLabel : MonoBehaviour {
    public GameObject achieveLabel;
	void OnEnable()
    {
        Destroy(achieveLabel);
    }
}
