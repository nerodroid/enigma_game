using UnityEngine;
using UnityEngine.UI;

namespace SpeedTutorInspectSystem
{
    public class InspectionController : MonoBehaviour
    {
        [Header("Object Name UI")]
        [SerializeField] private GameObject objectNameBG;


        [SerializeField] private Text objectNameUI;

        [Header("Object Additional Info Settings")]
        [SerializeField] private float onScreenTimer;
        [SerializeField] private Text extraInfoUI;
        [SerializeField] private GameObject extraInfoBG;

        [SerializeField] private GameObject infoImage;
        [HideInInspector] public bool startTimer;
        private float timer;

        private void Start()
        {
            objectNameBG.SetActive(false);
            extraInfoBG.SetActive(false);
            infoImage.SetActive(false);
        }

        private void Update()
        {
            if (startTimer)
            {
                timer -= Time.deltaTime;

                if (timer <= 0)
                {
                    timer = 0;
                    ClearAdditionalInfo();
                    startTimer = false;
                }
            }
        }

        public void ShowName(string objectName)
        {

            //infoImage.SetActive(true);
            objectNameBG.SetActive(true);
            
            objectNameUI.text = objectName;
        }

        public void HideName()
        {
            objectNameBG.SetActive(false);
            objectNameUI.text = "";
            //infoImage.SetActive(false);
        }


    public void ShowImage(Sprite a)
        {
            infoImage.GetComponent<Image>().sprite = a;
            infoImage.SetActive(true);
            
            //objectNameBG.SetActive(true);
            
            //objectNameUI.text = objectName;
        }

        public void HideImage()
        {
            infoImage.SetActive(false);
            //objectNameUI.text = "";
            //infoImage.SetActive(false);
        }




        public void ShowAdditionalInfo(string newInfo)
        {
            infoImage.SetActive(true);
            
            extraInfoUI.text = newInfo;
                  

        }

        void ClearAdditionalInfo()
        {
            infoImage.SetActive(false);
            extraInfoBG.SetActive(false);
            extraInfoUI.text = "";
            
        }
    }
}
