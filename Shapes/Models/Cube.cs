namespace Shapes.Models
{
  public class Cube
  {
    private Rectangle _face;
    public Cube (Rectangle side)
    {
      _face = side;
    }
  }
}
public int GetVolume()
{
  return 0;
}
public int GetSurfaceArea()
{
  int length = _face.GetLength();
  return (length * length) * 6;
}
