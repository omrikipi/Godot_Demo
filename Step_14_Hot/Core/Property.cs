using Messages;

namespace Core;

public class Property<T>
{
    private T value;

    public Property(T value)
    {
        this.value = value;
    }

    public T Value
    {
        get => value;
        set
        {
            var old_value = this.value;
            this.value = GetValue(value);
            if (!old_value.Equals(this.value))
                new Update_Message();
        }
    }

    protected virtual T GetValue(T value)
    {
        return value;
    }
}