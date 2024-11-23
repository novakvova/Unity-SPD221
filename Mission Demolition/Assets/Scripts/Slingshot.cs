using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public GameObject launchPoint;

    private void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
    }
    private void OnMouseEnter()
    {
        //print("Наведено мишку");
        launchPoint.SetActive(true);
    }
    private void OnMouseExit()
    {
        //print("Мишка забрана");
        launchPoint.SetActive(false);
    }
}
