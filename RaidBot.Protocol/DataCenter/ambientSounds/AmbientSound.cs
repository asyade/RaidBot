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
    public class AmbientSound : IData
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
        
        public virtual uint Volume
        {
            get
            {
                return mVolume;
            }
            set
            {
                mVolume = value;
            }
        }
        
        private uint mVolume;
        
        public virtual int CriterionId
        {
            get
            {
                return mCriterionId;
            }
            set
            {
                mCriterionId = value;
            }
        }
        
        private int mCriterionId;
        
        public virtual uint SilenceMin
        {
            get
            {
                return mSilenceMin;
            }
            set
            {
                mSilenceMin = value;
            }
        }
        
        private uint mSilenceMin;
        
        public virtual uint SilenceMax
        {
            get
            {
                return mSilenceMax;
            }
            set
            {
                mSilenceMax = value;
            }
        }
        
        private uint mSilenceMax;
        
        public virtual int Channel
        {
            get
            {
                return mChannel;
            }
            set
            {
                mChannel = value;
            }
        }
        
        private int mChannel;
        
        public virtual int Typeid
        {
            get
            {
                return mTypeid;
            }
            set
            {
                mTypeid = value;
            }
        }
        
        private int mTypeid;
        
        public AmbientSound()
        {
        }
    }
}
