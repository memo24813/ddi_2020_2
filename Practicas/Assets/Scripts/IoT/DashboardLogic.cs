using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DashboardLogic : MonoBehaviour
{
 
    public Button btnMenu;
    public GameObject menu;
    public Text btnText;
    RectTransform rtbtn;
    private void Start() {
        rtbtn = btnMenu.GetComponent<RectTransform>();
    }


 public void OnClickMenu()
 {
    if(btnText.text.Equals(">"))
    {
        // btnMenu.transform.position = new Vector3(btnMenu.transform.position.y + 10,btnMenu.transform.position.y,0); 
        // rtbtn.SetPositionAndRotation(new Vector3(190,rtbtn.position.y,0),new Quaternion(0,0,0,0));
        btnText.text = "<";
    }
    else if(btnText.text.Equals("<"))
    {
        btnText.text = ">";
        // btnMenu.transform.position = new Vector3(btnMenu.transform.position.y + 10,btnMenu.transform.position.y,0);
        // rtbtn.SetPositionAndRotation(new Vector3(485,rtbtn.position.y,0),new Quaternion(0,0,0,0));
    }

    menu.SetActive(!menu.activeSelf);
    
 }
}
