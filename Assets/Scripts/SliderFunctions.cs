using UnityEngine;
using UnityEngine.UI;

public class SliderFunctions : MonoBehaviour
{
    public CanvasGroup canvasObj;
    public void ChangeFadeVal(Slider _mySlider)
    {
        float fadeSliderVal = _mySlider.value;
        canvasObj.alpha = fadeSliderVal;
    }

    public Material materialObj;
    public void ChangeColorVal(Slider[] _myColorSliders)
    {
        float redSliderVal = _myColorSliders[0].value;
        float greenSliderVal = _myColorSliders[1].value;
        float blueSliderVal = _myColorSliders[2].value;
        materialObj.color = new Color(redSliderVal, greenSliderVal, blueSliderVal, 1f);
    }

    public GameObject carObj;
    public void ChangeMoveVal(Slider _mySlider)
    {
        float moveSliderVal = _mySlider.value;
        float moveXVal = -5f + 10 * moveSliderVal;
        carObj.transform.localPosition = new Vector3(moveXVal,0f,0f);
    }
    public void ChangeRotateVal(Slider _mySlider)
    {
        float rotateSliderVal = _mySlider.value;
        float rotateVal = rotateSliderVal * 360f;
        carObj.transform.localEulerAngles = new Vector3(0f,rotateVal,0f);
    }
    public void ChangeScaleVal(Slider _mySlider)
    {
        float scaleSliderVal = _mySlider.value;
        float scaleVal = 1f + 1 * scaleSliderVal;
        carObj.transform.localScale = new Vector3(scaleVal,scaleVal,scaleVal);
    }

    public AudioSource audioObj;
    public void ChangeVolumeVal(Slider _mySlider)
    {
        float volumeSliderVal = _mySlider.value;
        audioObj.volume = volumeSliderVal;
    }
    public void ChangePitchVal(Slider _mySlider)
    {
        float pitchSliderVal = _mySlider.value;
        audioObj.pitch = 1 + pitchSliderVal;
    }


}
