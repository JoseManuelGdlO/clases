using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class functions : MonoBehaviour
{
	public Button Do, Re, Mi, Fa, Sol,La, Si, Doo, Ree, Faa, Soll, Laa;
	
	public Button buttonIWantToUse;
	
	
 
    // Start is called before the first frame update
    void Start()
	{
        
    }

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)) {
			Do.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.W)) {
			Re.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.E)) {
			Mi.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.R)) {
			Fa.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.T)) {
			Sol.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.Y)) {
			La.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.U)) {
			Si.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.Alpha2)) {
			Doo.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.Alpha3)) {
			Ree.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.Alpha4)) {
			Faa.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.Alpha5)) {
			Soll.onClick.Invoke();
		} else if(Input.GetKeyDown(KeyCode.Alpha6)) {
			Laa.onClick.Invoke();
		}
	}
}
