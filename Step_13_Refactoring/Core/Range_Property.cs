using System;

namespace Core;

public class Range_Property<T> :
    Property<T>
    where T : IComparable<T>
{
    public Property<T> Min { get; private set; }
    public Property<T> Max { get; private set; }

    public Range_Property(T value, T min, T max) :
        base(value)
    {
        Min = new Property<T>(min);
        Max = new Property<T>(max);
    }

    protected override T GetValue(T value)
    {
        var min = Min.Value.CompareTo(value);
        if (min > 0)
            return Min.Value;
        var max = Max.Value.CompareTo(value);
        if (max < 0)
            return Max.Value;
        return value;
    }
}