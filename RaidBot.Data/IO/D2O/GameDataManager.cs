using RaidBot.Data.IO.D2O.DataCenter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Data.IO.D2O
{
    public class GameDataManager
    {
        //#region Public methode

        //public RaidBot.Protocol.DataCenter.IData GetObject(GameDataClassEnum name, int index)
        //{
        //    if (File.Exists(name + ".d2o"))
        //    {
        //        GameDataFileAccessor accesor = new GameDataFileAccessor(GameDataParam.Default.GameDataFolderPath + name.ToString() + ".d2o", new D2I.I18nFileAccessor(GameDataParam.Default.I18nFilePath));
        //        return (RaidBot.Protocol.DataCenter.IData)accesor.ReadClass(index);
        //    }
        //    else
        //        throw new Exception("Unkown data class file");
        //}

        //public RaidBot.Protocol.DataCenter.IData[] GetObjects(GameDataClassEnum name)
        //{
        //    GameDataFileAccessor accesor = new GameDataFileAccessor(GameDataParam.Default.GameDataFolderPath + name.ToString() + ".d2o", new D2I.I18nFileAccessor(GameDataParam.Default.I18nFilePath));
        //    return (RaidBot.Protocol.DataCenter.IData)accesor.ReadAllClass().ToArray();


        //#endregion // ToDo
        }
    }
