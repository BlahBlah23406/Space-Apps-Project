using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private Camera collage;

    [SerializeField]
    private float zoomStep, minCamSize, maxCamSize;


    [SerializeField]
    private SpriteRenderer mapRenderer;
    private float mapMinX, mapMaxX, mapMinY, mapMaxY;
    private Vector3 dragOrigin;

    private void Awake()
    {
        mapMinX = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;
        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;

    }


    // Update is called once per frame
    private void Update()
    {
        PanCamera();
    }

    private void PanCamera()
    {
        if (Input.GetMouseButtonDown(0))
            dragOrigin = collage.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - collage.ScreenToWorldPoint(Input.mousePosition);

            collage.transform.position = ClampCamera(collage.transform.position + difference);
        }
    
    
    }

    public void ZoomIn()
    {
        float newSize = collage.orthographicSize - 1;
        collage.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        collage.transform.position = ClampCamera(collage.transform.position);

    }

    public void ZoomOut()
    {
       
        float newSize = collage.orthographicSize + zoomStep;
        collage.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

        collage.transform.position = ClampCamera(collage.transform.position);

        
    }

    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = collage.orthographicSize;
        float camWidth = collage.orthographicSize * collage.aspect;

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX + camWidth;
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY + camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxY);
        float newY = Mathf.Clamp(targetPosition.y, minX, maxY);

        return new Vector3(newX, newY, targetPosition.z);
    }
}
