using UnityEngine;
using UnityEngine.UI;
namespace SpeedTutorInspectSystem
{
    public class ObjectController : MonoBehaviour
    {



        [SerializeField] public Sprite inspectimage;
        [Space(10)] [SerializeField] private string objectName;

        [Space(10)] [TextArea] [SerializeField] private string extraInfo;

        [Space(10)] [SerializeField] private InspectionController inspectionController;


        public void ShowObjectImage()
        {
            inspectionController.ShowImage(inspectimage);
        }

        public void HideObjectImage()
        {
            inspectionController.HideImage();
        }


        public void ShowObjectName()
        {
            inspectionController.ShowName(objectName);
        }

        public void HideObjectName()
        {
            inspectionController.HideName();
        }

        public void ShowExtraInfo()
        {
            inspectionController.ShowAdditionalInfo(extraInfo);
        }
    }
}
