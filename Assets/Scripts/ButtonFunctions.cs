using UnityEngine;
using TMPro;

public class ButtonFunctions : MonoBehaviour
{
    // Show & Hide on screen GameObject
    public void Show(GameObject myObj){
        myObj.SetActive(true);
    }
    public void Hide(GameObject myObj){
        myObj.SetActive(false);
    }
    public void ShowHide(GameObject myObj){
        myObj.SetActive(!myObj.activeSelf);
    }

    // Update and Display Number in text field
    public void AddValue(TextMeshProUGUI myNumberText){
        int calcVal = int.Parse(myNumberText.text) + 1;
        myNumberText.text = calcVal.ToString();
    }
    public void SubtractValue(TextMeshProUGUI myNumberText){
        int calcVal = int.Parse(myNumberText.text) - 1;
        myNumberText.text = calcVal.ToString();
    }
    public void ResetValue(TextMeshProUGUI myNumberText){
        int resetVal = 0;
        myNumberText.text = resetVal.ToString();
    }

    // Control GameObject Properties
    public void MoveLeft(GameObject myObj){
        Vector3 currentPos = myObj.transform.localPosition;
        myObj.transform.localPosition = new Vector3(currentPos.x - 5f, currentPos.y, currentPos.z);
    }
    public void MoveRight(GameObject myObj){
        Vector3 currentPos = myObj.transform.localPosition;
        myObj.transform.localPosition = new Vector3(currentPos.x + 5f, currentPos.y, currentPos.z);
    }
    public void ScaleUp(GameObject myObj){
        Vector3 currentScale = myObj.transform.localScale;
        myObj.transform.localScale = new Vector3(currentScale.x*1.1f, currentScale.y*1.1f, currentScale.z*1.1f);
    }
    public void ScaleDown(GameObject myObj){
        Vector3 currentScale = myObj.transform.localScale;
        myObj.transform.localScale = new Vector3(currentScale.x*0.9f, currentScale.y*0.9f, currentScale.z*0.9f);
    }

}
