//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Character.Choice
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class CharacterToRemodelInformations : CharacterRemodelingInformation
    {
        
        public new const short ProtocolId = 477;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_possibleChangeMask;
        
        public virtual byte PossibleChangeMask
        {
            get
            {
                return m_possibleChangeMask;
            }
            set
            {
                m_possibleChangeMask = value;
            }
        }
        
        private byte m_mandatoryChangeMask;
        
        public virtual byte MandatoryChangeMask
        {
            get
            {
                return m_mandatoryChangeMask;
            }
            set
            {
                m_mandatoryChangeMask = value;
            }
        }
        
        public CharacterToRemodelInformations(byte possibleChangeMask, byte mandatoryChangeMask)
        {
            m_possibleChangeMask = possibleChangeMask;
            m_mandatoryChangeMask = mandatoryChangeMask;
        }
        
        public CharacterToRemodelInformations()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_possibleChangeMask);
            writer.WriteByte(m_mandatoryChangeMask);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_possibleChangeMask = reader.ReadByte();
            m_mandatoryChangeMask = reader.ReadByte();
        }
    }
}