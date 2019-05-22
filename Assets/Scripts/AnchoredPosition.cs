using UnityEngine;
using System.Collections;

public class AnchoredPosition : MonoBehaviour {
    public Vector2 aP;
    public int sH; 
	// Use this for initialization
	void Start () {
        sH = Screen.height;

        this.gameObject.transform.localPosition = new Vector3(0,-960, 0);
        this.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        aP = this.gameObject.GetComponent<RectTransform>().anchoredPosition;
        
    }
	
}
