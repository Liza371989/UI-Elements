using UnityEngine;
using TMPro;

public class DropdownFunctions : MonoBehaviour
{
   // public function for Dropdown Selections

   // List of Car GameObjects
   public GameObject[] carsList;
   
   // Call Function if Car Dropdown Menu Changes
   public void SelectCar(TMP_Dropdown _myDropdownMenu)
   {
        int carMenuValue = _myDropdownMenu.value;
        // Hide All Calls
        for (int i = 0; i<carsList.Length; i++)
        {
            carsList[i].SetActive(false);
        }
        // Show Car Selection
        carsList[carMenuValue].SetActive(true);
   }

   // List of Materials for Cube Object
   public Material[] materialsList;
   public GameObject cubeObj;

   // Call Function if Color Dropdown Menu Changes
   public void SelectColor(TMP_Dropdown _myDropdownMenu)
   {
        int colorMenuValue = _myDropdownMenu.value;
        
        // Set Color Material of Cube
        cubeObj.GetComponent<Renderer>().material = materialsList[colorMenuValue];
   }

   // List of Vector3 Rotations for Car Views
   public Vector3[] viewsList;
   public GameObject carObj;

   // Call Function if View Dropdown Menu Changes
   public void SelectView(TMP_Dropdown _myDropdownMenu)
   {
        int viewMenuValue = _myDropdownMenu.value;
        
        // Set Car Rotation View
        carObj.transform.localEulerAngles = viewsList[viewMenuValue];
        
    }

   // List of Vector3 Rotations for Car Views
   public AudioClip[] musicLoopList;
   public AudioSource audioSpeaker;

   // Call Function if View Dropdown Menu Changes
   public void SelectMusicLoop(TMP_Dropdown _myDropdownMenu)
   {
        int loopMenuValue = _myDropdownMenu.value;
        
        // Set Audio Loop
        audioSpeaker.clip = musicLoopList[loopMenuValue];
		audioSpeaker.Play();
    }
}
