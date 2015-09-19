using UnityEngine;
using System.Collections;

public class level_1_btn : MonoBehaviour
{
    void OnMouseDown()
    {
        bool open = false;
        
        if (open == true) {
            transform.localScale += new Vector3(-100, -100, -10);
            open = false;
        }   
        else if(open == false) {
            transform.localScale += new Vector3(100, 100, 10);
            open = true;
        }
  
    }
}
