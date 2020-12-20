namespace InterfaceAndInheritanc
{
    public interface IDraggable
    {
        // this is not inheritable coz iterfaces have nothing to do with inheritances
        // when something inherites a interface you still need to write the implemantation
        // of the code coz here i only have a method name
        void Drag();
    }
}