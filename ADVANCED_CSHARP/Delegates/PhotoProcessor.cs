namespace Delegates // this is not extandeble but i can make is so using DELEGATES
{
    public class PhotoProcessor
    {
        public delegate void PhototFilterHandler(Photo photo);
      //public void Proccess(string path)
        public void Process(string path, PhototFilterHandler filterHandler)
        {
            // use .NET Delegates
            //System.Action<> {void}
            //System.Func<> {returns Value}

            var photo = Photo.Load(path);

            //var filters = new PhotoFilters();
            filterHandler(photo);

            /* filters.ApplyBrightness(photo);
               filters.ApplyContrast(photo);
               filters.Resize(photo); */

            filterHandler(photo); // client disgns what he|she wants this method to act  
            photo.Save();
        }
    }
}
