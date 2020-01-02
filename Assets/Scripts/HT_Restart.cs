using UnityEngine;
using System.Collections;

public class HT_Restart : MonoBehaviour {
    [System.Obsolete]
    public void OnMouseDown () {
		Application.LoadLevel (Application.loadedLevel);
	}
}
