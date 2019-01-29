using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class ARRest : MonoBehaviour
{
    [SerializeField]
    ARSession arSession;
    // Start is called before the first frame update
    void Start()
    {
        ARSubsystemManager.DestroySubsystems();
        ARSubsystemManager.CreateSubsystems();
        ARSubsystemManager.StopSubsystems();
        arSession.gameObject.SetActive(false);
        StartCoroutine(StartTracking());
    }

    IEnumerator  StartTracking()
    {
        yield return new WaitForSeconds(1f);
        arSession.gameObject.SetActive(true);
        ARSubsystemManager.StartSubsystems();
      //  arPlaneManager.planeAdded += PlaneTracked;
    }

}
