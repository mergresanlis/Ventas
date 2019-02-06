[assembly: Xamarin.Forms.Dependency(typeof(Ventas.Droid.Implementations.PathService))]
namespace Ventas.Droid.Implementations
{
    using System;
    using System.IO;
    using Interfaces;

    public class PathService : IPathService
    {
        public string GetDatabasePath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "Sales.db3");
        }
    }

}