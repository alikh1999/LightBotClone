public struct Angle
{
    public float Value => _value;

    private float _value;

    public Angle(float angle)
    {
        _value = angle;
    }
}