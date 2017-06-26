//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Objects
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ObjectGroundAddedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 3017;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_cellId;
        
        public virtual ushort CellId
        {
            get
            {
                return m_cellId;
            }
            set
            {
                m_cellId = value;
            }
        }
        
        private ushort m_objectGID;
        
        public virtual ushort ObjectGID
        {
            get
            {
                return m_objectGID;
            }
            set
            {
                m_objectGID = value;
            }
        }
        
        public ObjectGroundAddedMessage(ushort cellId, ushort objectGID)
        {
            m_cellId = cellId;
            m_objectGID = objectGID;
        }
        
        public ObjectGroundAddedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_cellId);
            writer.WriteVarUhShort(m_objectGID);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_cellId = reader.ReadVarUhShort();
            m_objectGID = reader.ReadVarUhShort();
        }
    }
}