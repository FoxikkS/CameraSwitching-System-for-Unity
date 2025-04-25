using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraSwitcher : MonoBehaviour
{
    [Header("Security Camera Feeds")]
    [SerializeField] private List<RenderTexture> cameraFeeds;

    [Header("Camera UI Canvas")]
    [SerializeField] private Canvas cameraCanvas;

    private RawImage _cameraDisplay;
    private int _currentCameraIndex;

    private void Start()
    {
        _cameraDisplay = cameraCanvas.GetComponent<RawImage>();
        _cameraDisplay.texture = cameraFeeds[_currentCameraIndex];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _currentCameraIndex--;
            _currentCameraIndex = Mathf.Clamp(_currentCameraIndex, 0, cameraFeeds.Count - 1);
            UpdateCamera();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _currentCameraIndex++;
            _currentCameraIndex = Mathf.Clamp(_currentCameraIndex, 0, cameraFeeds.Count - 1);
            UpdateCamera();
        }
    }

    private void UpdateCamera()
    {
        _cameraDisplay.texture = cameraFeeds[_currentCameraIndex];
    }
}