using System;

namespace InterfaceAndInheritanc
{
    // this class have multipule base Interfaces
    // coz it can not iherite from multiple classes 
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }

    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {
        }

        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }
}