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
    public class CensoredWord : IData
    {
        
        public virtual uint Id
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
        
        private uint mId;
        
        public virtual uint ListId
        {
            get
            {
                return mListId;
            }
            set
            {
                mListId = value;
            }
        }
        
        private uint mListId;
        
        public virtual string Language
        {
            get
            {
                return mLanguage;
            }
            set
            {
                mLanguage = value;
            }
        }
        
        private string mLanguage;
        
        public virtual string Word
        {
            get
            {
                return mWord;
            }
            set
            {
                mWord = value;
            }
        }
        
        private string mWord;
        
        public virtual bool DeepLooking
        {
            get
            {
                return mDeepLooking;
            }
            set
            {
                mDeepLooking = value;
            }
        }
        
        private bool mDeepLooking;
        
        public CensoredWord()
        {
        }
    }
}
