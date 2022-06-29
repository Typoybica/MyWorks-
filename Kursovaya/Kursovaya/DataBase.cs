using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kursovaya
{
    class DataBase
    {
        public static void SaveBinaryFile(Catalog catalog)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("Catalog_0.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binaryFormatter.Serialize(fileStream, catalog);
            }
        }

        public static Catalog LoadBinaryFile()
        {
            Catalog catalog = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (Stream stream = File.OpenRead("Catalog_0.dat"))
            {
                catalog = (Catalog)binaryFormatter.Deserialize(stream);
            }
            return catalog;
        }
    }
}
