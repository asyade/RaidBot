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
    public class Interactive : IData
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
        
        public virtual int ActionId
        {
            get
            {
                return mActionId;
            }
            set
            {
                mActionId = value;
            }
        }
        
        private int mActionId;
        
        public virtual bool DisplayTooltip
        {
            get
            {
                return mDisplayTooltip;
            }
            set
            {
                mDisplayTooltip = value;
            }
        }
        
        private bool mDisplayTooltip;
        
        public Interactive()
        {
        }
    }
}