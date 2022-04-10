using UnityEngine;

public class Ray : MonoBehaviour {
    public float raycastLength = 100f;
    public float reflectLength = 5f;

    [Header("Optional")]
    public LineRenderer lineRay;

    private void Awake() {
        if (lineRay == null) lineRay = GetComponent<LineRenderer>();
        lineRay.positionCount = 3;
    }

    void Update() {
        lineRay.SetPosition(0, transform.position);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastLength)) {
            lineRay.SetPosition(1, hit.point);
            Vector3 reflectDirection = Vector3.Reflect(transform.forward, hit.normal);
            lineRay.SetPosition(2, hit.point + reflectDirection * reflectLength);
        }else
        {
            lineRay.SetPosition(1, transform.position);
            lineRay.SetPosition(2, transform.forward * raycastLength);
        }
    }
}