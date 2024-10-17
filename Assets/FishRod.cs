using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FishRod : MonoBehaviour
{ 
    #region DATA
    #region GAME OBJECTS
        public GameObject fishRod;
        public LineRenderer leska;
        public LayerMask mask;

        public Vector3 MousePos;

        public Transform hook;

        public Transform startTransform;

        public Vector3[] points;
    #endregion

    #region bool
        public bool isHit;
    #endregion

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000f, mask))
            {

            hook.transform.position = hit.point;
            isHit = false;


            Debug.Log(hit.collider.gameObject.transform.position);

            }

        leska.SetPosition(0, new Vector3(startTransform.position.x, startTransform.position.y, startTransform.position.z));
        leska.SetPosition(1, new Vector3(hook.position.x, hook.position.y, hook.position.z));

    }

}
