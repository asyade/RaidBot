//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18408
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaidBot.Protocol.DataCenter
{
    using System.Collections.Generic;
    using RaidBot.Common.IO;
    using System;
    
    
    [Serializable()]
    public class Job : IData
    {
        
        public virtual int Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }
        
        private int mId;
        
        public virtual uint NameId
        {
            get
            {
                return mNameId;
            }
            set
            {
                mNameId = value;
            }
        }
        
        private uint mNameId;
        
        public virtual int SpecializationOfId
        {
            get
            {
                return mSpecializationOfId;
            }
            set
            {
                mSpecializationOfId = value;
            }
        }
        
        private int mSpecializationOfId;
        
        public virtual int IconId
        {
            get
            {
                return mIconId;
            }
            set
            {
                mIconId = value;
            }
        }
        
        private int mIconId;
        
        public virtual List<int> ToolIds
        {
            get
            {
                return mToolIds;
            }
            set
            {
                mToolIds = value;
            }
        }
        
        private List<int> mToolIds = new List<int>();
        
        public Job()
        {
        }
    }
}
