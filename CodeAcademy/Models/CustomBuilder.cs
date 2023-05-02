namespace CodeAcademy.Models;
public class CustomBuilder
{
    private char[] _arr;
    private int _capacity = 16;
    private int _length = 0;
    public int Length
    {
        get
        {
            return _length;
        }
        set
        {
            if (value < _length)
            {
                throw new Exception($"Length must be more than {_length}");
            }
            if (value > _capacity && value <= 2 * _capacity)
            {
                Capacity *= 2;
            }
            if (value > 2 * _capacity)
            {
                Capacity = value;
            }
            _length = value;
        }
    }
    public int Capacity
    {
        get
        {
            return _capacity;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value cannot be less than zero");
            }
            if (value < Length)
            {
                throw new Exception($"Capacity must be more than {Length}");
            }
            _capacity = value;
            Array.Resize(ref _arr, _capacity);
        }
    }

    public CustomBuilder()
    {
        _arr = new char[_capacity];
    }

    public void Append(char item)
    {
        if (Length == Capacity)
        {
            Capacity = Capacity * 2;
        }
        _arr[_length] = item;
        _length++;

    }
    public void Remove(int index, int count)
    {
        if (Length == Capacity)
        {
            Capacity = Capacity * 2;
        }
        char[] chars = new char[_arr.Length - count];
        for (int i = 0; i < chars.Length; i++)
        {
            if (i < index || i >= index + count)
            {
                chars[i] = _arr[i];
            }
        }
        _arr = chars;
    }
    public void Replace(char old, char @new)
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            if (_arr[i] == old)
            {
                _arr[i] = @new;
            }
        }
    }
    public char[] GetResult
    {
        get
        {
            return _arr;
        }
    }
    public override string ToString()
    {
        return new string(_arr);
    }

}
