using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RaidBot.Data.IO.D2P.File;
using System.IO.Compression;
using RaidBot.Data.IO.D2P;
using RaidBot.Data.IO.D2P.Map;
using System.Runtime.Serialization.Formatters.Binary;
using RaidBot.Common.IO;

namespace RaidBot.Data.MapData
{

    public class MapDataGenerator
    {
        #region Declarations
        public GeneratingStats Stats { get; private set; }
        private string mInputDirectory;
        public event EventHandler GenerationsSucces;

        #endregion

        #region Method

        public MapDataGenerator(string inputDirectory)
        {
            Stats = new GeneratingStats();
            mInputDirectory = inputDirectory;
        }

        public void Generate()
        {
            //On prepart le dossier qui va contenire les sous dossier coréspondant au fichier d2p
            if (!Directory.Exists(DataSetting.Default.D2PFolderPath))
                Directory.CreateDirectory(DataSetting.Default.D2PFolderPath);
            DirectoryInformations directory = new DirectoryInformations(mInputDirectory, "d2p");
            //Mis a jours de l'interface
            Stats.MainStats = string.Format("Decompression des maps");
            Stats.MainMaximum = directory.Files.Count + 1;      
            Stats.MainValue = 0;
            //On Decopresse les fichier d2p un par un
            foreach (string path in directory.Files)
            {
                ParseFile(path);
                Stats.MainValue += 1;
            }
            //Mis a jours de l'interface
            Stats.Generating = false;
            OnGeneratingSucces();
        }

        private void OnGeneratingSucces()
        {
            if (GenerationsSucces != null)
                GenerationsSucces(this, new EventArgs());
        }

        private DirectoryInfo ParseFile(string path)
        {
            //On charge le fichier d^p
            RaidBot.Data.IO.D2P.File.File file = new RaidBot.Data.IO.D2P.File.File(path);       
            //Mis a jours de l'interface
            Stats.SubMaximum = file.LoadedMaps.Count;
            Stats.SubValue = 0;
            Stats.SubStats = "Parsing : " + file.Path;
            //On prépart le répértoire qui corespon au fichier d2p en cours de décompression
            string currentPath = string.Format("{0}\\{1}", DataSetting.Default.D2PFolderPath, file.Path.Split('\\').Reverse().ToArray()[0].Split('.').ToArray()[0]);
            if (Directory.Exists(currentPath))
                Directory.Delete(currentPath, true);
            DirectoryInfo dir = Directory.CreateDirectory(currentPath);
            //On decompresse toutes les maps une par une
            foreach (var uncompressedMap in file.LoadedMaps.Values)
            {
                //On charge la map a partire des données décompresser
                Map map = new Map(uncompressedMap);
                //On prepart le fichier pour la sérialisation
                string mapFilePath = string.Format("{0}\\{1}.{2}",dir.FullName,map.Id.ToString(),"rmf");
                if(System.IO.File.Exists(mapFilePath))
                    System.IO.File.Delete(mapFilePath);
                FileStream stream = System.IO.File.Create(mapFilePath);
                //On sérialisse
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, map);
                stream.Close();
                //Mis a jours de l'interface
                Stats.SubValue += 1;
            }
            return dir;
        }

        #endregion
    }
}