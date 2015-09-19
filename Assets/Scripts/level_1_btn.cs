using UnityEngine;
using System.Collections;

public class level_1_btn : MonoBehaviour
{
    void OnMouseDown()
    {
        print(gameObject.name);
        transform.localScale += new Vector3(2, 2, 2);

    }

//    public GameObject thelight = null;

//    private void
}
