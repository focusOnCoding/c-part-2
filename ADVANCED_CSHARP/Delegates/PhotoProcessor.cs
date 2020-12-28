namespace Delegates // this is not extandeble but i can make is so using DELEGATES
{
    public class PhotoProcessor
    {
        public void Proccess(string path)
        {

            var photo = Photo.Load(path);

            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}
