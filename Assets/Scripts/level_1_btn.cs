using UnityEngine;
using System.Collections;

public class level_1_btn : MonoBehaviour
{
    void OnMouseDown()
    {       
        transform.localScale += new Vector3(100, 100, 10);
        Application.LoadLevel("TheCube");
        Cursor.visible = false;
    }
}