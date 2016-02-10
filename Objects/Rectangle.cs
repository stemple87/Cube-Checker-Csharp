namespace RectangleChecker
{
  public class Rectangle{
    private int _length;
    private int _width;

    public Rectangle(int sideLength, int sideWidth)
    {
      _length = sideLength;
      _width = sideWidth;
    }

    public int GetLength()
    {
      return _length;
    }
    public void setLength(int newLength)
    {
      _length = newLength;
    }
    public int GetWidth()
    {
      return _width;
    }
    public void setWidth(int newWidth)
    {
      _width = newWidth;
    }
    public int GetArea()
    {
      return _length * _width;
    }
    public bool IsSquare()
    {
      if (_length == _width) {
        return true;
      }
      else{
        return false;
      }
    }
  }
}
