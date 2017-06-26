//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
    {
        
        public new const uint ProtocolId = 6412;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_elementEventId;
        
        public virtual byte ElementEventId
        {
            get
            {
                return m_elementEventId;
            }
            set
            {
                m_elementEventId = value;
            }
        }
        
        public GameContextRemoveElementWithEventMessage(byte elementEventId)
        {
            m_elementEventId = elementEventId;
        }
        
        public GameContextRemoveElementWithEventMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_elementEventId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_elementEventId = reader.ReadByte();
        }
    }
}