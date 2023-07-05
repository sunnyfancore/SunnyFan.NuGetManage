using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SunnyFan.NuGetManage.Models
{
    [Serializable]
    public class PackSourceModel
    {
        string savePath { get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "packagesource.bin"); } }

        List<PackSourceModel> packageSources = new List<PackSourceModel>();
        public PackSourceModel()
        {
            packageSources = Load();
        }

        public List<PackSourceModel> GetPackageSources() => packageSources;

        public Guid Id { get; set; }


        public string Title { get; set; }


        public string Source { get; set; }


        public string APIKey { get; set; }


        public void Add()
        {
            packageSources.Add(this);
            this.Save();
        }
        public void Delete(Guid id)
        {
            var model = packageSources.Where(a => a.Id == id).FirstOrDefault();
            if (model != null)
            {
                packageSources.Remove(model);
                this.Save();
            }
        }
        public void Update()
        {
            var model = packageSources.Where(a => a.Id == this.Id).FirstOrDefault();
            if (model != null)
            {
                this.Id = model.Id;
                this.Title = model.Title;
                this.Source = model.Source;
                this.APIKey = model.APIKey;
                this.Save();
            }
        }
        void Save()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                File.WriteAllBytes(savePath, ms.GetBuffer());
            }
        }
        public List<PackSourceModel> Load()
        {
            if (!File.Exists(savePath))
            {
                return new List<PackSourceModel>();
            }

            using (Stream destream = new FileStream(savePath, FileMode.Open,
                         FileAccess.Read, FileShare.Read))
            {
                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    var entity = (PackSourceModel)formatter.Deserialize(destream);
                    return entity.packageSources;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return new List<PackSourceModel>();
                }
            }
        }


    }
}
