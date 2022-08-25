using UnityEngine;

class Example : MonoBehaviour
{
    [SerializeField]
    private VirtualJoystick _virtualJoystick;

    protected void Awake()
    {
        _virtualJoystick.InputChanged += OnInputChanged;
        _virtualJoystick.RelativeInputChanged += OnRelativeInputChanged;
        _virtualJoystick.RadiusChanged += OnRadiusChanged;
        _virtualJoystick.AngleChanged += OnAngleChanged;
        _virtualJoystick.RelativeAngleChanged += OnRelativeAngleChanged;
    }

    private void OnInputChanged(Vector2 input)
    {
        Debug.Log("Input: " + input);
    }

    private void OnRelativeInputChanged(Vector2 input)
    {
        Debug.Log("Relative input: " + input);
    }

    private void OnRadiusChanged(float radius)
    {
        Debug.Log("Radius: " + radius);
    }

    private void OnAngleChanged(float angleInRadians, float angleInDegrees)
    {
        Debug.Log("Angle in radians: " + angleInRadians);
        Debug.Log("Angle in degrees: " + angleInDegrees);
    }

    private void OnRelativeAngleChanged(float angleInRadians, float angleInDegrees)
    {
        Debug.Log("Relative angle in radians: " + angleInRadians);
        Debug.Log("Relative angle in degrees: " + angleInDegrees);
    }
}
