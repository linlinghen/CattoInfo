using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class pozitionareImaginiCuburi : MonoBehaviour
{
    public GameObject image;
    public Transform cubeTransform;
    public Vector3 offset = new Vector3(0f, 0.1f, 0f);

    private ARTrackedImageManager trackedImageManager;

    private void Awake()
    {
        trackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var trackedImage in eventArgs.added)
        {
            if (trackedImage.referenceImage.name == "Image.tort")
            {
                PositionImage(trackedImage.transform);
            }
        }
    }

    private void PositionImage(Transform trackedImageTransform)
    {
        image.transform.position = cubeTransform.position + offset;
        image.transform.rotation = cubeTransform.rotation;
        image.SetActive(true);
    }
}
