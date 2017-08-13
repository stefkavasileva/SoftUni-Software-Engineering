namespace _02.Graphic_Editor
{
    using System;

    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            Console.WriteLine(shape.Drow());
        }
    }
}