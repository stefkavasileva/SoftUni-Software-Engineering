namespace _02.Graphic_Editor
{
    public class Startup
    {
        public static void Main()
        {
            var circle = new Circle();
            var rect = new Rectangle();
            var square = new Square();

            var editor=new GraphicEditor();
            editor.DrawShape(circle);
            editor.DrawShape(rect);
            editor.DrawShape(square);
        }
    }
}
