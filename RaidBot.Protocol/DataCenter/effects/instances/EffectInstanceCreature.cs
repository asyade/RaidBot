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
    public class EffectInstanceCreature : EffectInstance, IData
    {
        
        public virtual uint MonsterFamilyId
        {
            get
            {
                return mMonsterFamilyId;
            }
            set
            {
                mMonsterFamilyId = value;
            }
        }
        
        private uint mMonsterFamilyId;
        
        public EffectInstanceCreature()
        {
        }
    }
}
