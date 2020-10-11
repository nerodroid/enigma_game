using UnityEngine;
using UnityEngine.UI;

namespace SpeedTutorInspectSystem
{
    public class InspectionRaycast : MonoBehaviour
    {

        public GameObject Panel;


        [Header("Raycast Length/Layer")]
        [SerializeField] private int rayLength = 1;
        [SerializeField] private LayerMask layerMaskInteract;
        [SerializeField] private LayerMask layerMaskExclude;
        private ObjectController raycastedObj;

        [Header("Crosshair Reference")]
        [SerializeField] private Image crosshair;
        private bool isCrosshairActive;
        private bool doOnce;
        bool isPaused =false;
        void Update()
        {
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            int Mask = 1 << layerMaskExclude | layerMaskInteract.value;


            if (Input.GetMouseButtonDown(1) ){

                if (isPaused ){
                    ClosePanel();   
                    Cursor.lockState = CursorLockMode.None;
                    Time.timeScale=1;
                    raycastedObj.ShowExtraInfo();
                    raycastedObj.HideObjectImage();
                    //raycastedObj.GetObjectImage();
                    //Cursor.visible =false;
                    Cursor.lockState = CursorLockMode.None;
                    isPaused= false;

                }
            }



            if (Physics.Raycast(transform.position, fwd, out hit, rayLength, Mask))
            {
                if (hit.collider.CompareTag("InteractObject"))
                {
                    if (!doOnce)
                    {
                        raycastedObj = hit.collider.gameObject.GetComponent<ObjectController>();
                        raycastedObj.ShowObjectName();
                        CrosshairChange(true);
                    }

                    isCrosshairActive = true;
                    doOnce = true;
                    
                  


                    if (Input.GetMouseButtonDown(0))
                    {

                        if (isPaused ){
                            ClosePanel();   
                            Cursor.lockState = CursorLockMode.None;
                            Time.timeScale=1;
                            raycastedObj.ShowExtraInfo();
                            raycastedObj.HideObjectImage();
                            //raycastedObj.GetObjectImage();
                            //Cursor.visible =false;
                            Cursor.lockState = CursorLockMode.None;
                            isPaused= false;

                        }

                        

                        else{





                            Cursor.lockState = CursorLockMode.Locked;
                            OpenPanel();   
                            Cursor.visible =false;
                            Time.timeScale=0;
                            isPaused= true;
                            raycastedObj.ShowObjectImage();
                           // Cursor.lockState = CursorLockMode.None;
                            //raycastedObj.ShowExtraInfo();    

                        }
                        
                    
                        //Destroy(col.gameObject);
                    }
                }
            }

            else
            {
                if (isCrosshairActive)
                {
                    //ClosePanel();
                    raycastedObj.HideObjectName();
                    CrosshairChange(false);
                    doOnce = false;
                }
            }
        }

        void CrosshairChange(bool on)
        {
            if (on && !doOnce)
            {
                crosshair.color = Color.red;
            }

            else
            {
                crosshair.color = Color.white;
                isCrosshairActive = false;
            }
        }

        public void OpenPanel(){

            if(Panel != null){
                Panel.SetActive(true);
            }
        }

        public void ClosePanel(){

            if(Panel != null){
                Panel.SetActive(false);
            }
        }



    }
}
