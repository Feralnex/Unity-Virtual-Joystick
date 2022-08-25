# Virtual Joystick
Virtual Joystick is a UI element that allows you to enter input by dragging the thumbstick on the screen.

## About
VirtualJoystick prefab provides several parameters:
- Threshold - image defining the scope of the joystick (already filled),
- Thumbstick - image (draggable) defining the input relative to the threshold (already filled),
- Relative Object - transform from which rotation is taken into consideration in order to compute input relative to fixed direction (prefab created with the camera in mind),
- Inactive Opacity - value from 0.0 to 1.0 indicating VirtualJoystick visibility on screen when it is not beeing used (value 0.0 means not visible),
- Active Opacity - value from 0.0 to 1.0 indicating VirtualJoystick visibility on screen when it is beeing used (value 0.0 means not visible).

Virtual Joystick has been created so that the character always moves in the desired direction as shown by the joystick without worrying about the camera position, but you can also choose different object (Transform) from which to calculate the input relative to the fixed direction.

**Important:**
The Image component has been attached to the root of the prefab to be able to react to the OnPointerDown event if you click next to the Threshold image to center the Virtual Joystick on a given position. The scope of this operation can be controlled by modifying the RectTransform parameters in the root of the prefab.

Unity version:
- 2021.2.7f1.

## Usage
Just place the Virtual Joystick prefab in Canvas and set it as you see fit.

An example of how to read input from VirtualJoystick prefab from Example/Scripts/Example.cs:

```cs
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
```