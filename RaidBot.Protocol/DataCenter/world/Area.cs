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
    public class Area : IData
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
        
        public virtual int SuperAreaId
        {
            get
            {
                return mSuperAreaId;
            }
            set
            {
                mSuperAreaId = value;
            }
        }
        
        private int mSuperAreaId;
        
        public virtual bool ContainHouses
        {
            get
            {
                return mContainHouses;
            }
            set
            {
                mContainHouses = value;
            }
        }
        
        private bool mContainHouses;
        
        public virtual bool ContainPaddocks
        {
            get
            {
                return mContainPaddocks;
            }
            set
            {
                mContainPaddocks = value;
            }
        }
        
        private bool mContainPaddocks;
        
        public virtual Rectangle Bounds
        {
            get
            {
                return mBounds;
            }
            set
            {
                mBounds = value;
            }
        }
        
        private Rectangle mBounds;
        
        public virtual uint WorldmapId
        {
            get
            {
                return mWorldmapId;
            }
            set
            {
                mWorldmapId = value;
            }
        }
        
        private uint mWorldmapId;
        
        public virtual bool HasWorldMap
        {
            get
            {
                return mHasWorldMap;
            }
            set
            {
                mHasWorldMap = value;
            }
        }
        
        private bool mHasWorldMap;
        
        public Area()
        {
        }
    }
}
