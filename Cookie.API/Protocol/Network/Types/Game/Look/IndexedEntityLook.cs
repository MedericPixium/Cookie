//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Look
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class IndexedEntityLook : NetworkType
    {
        
        public const short ProtocolId = 405;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private EntityLook m_look;
        
        public virtual EntityLook Look
        {
            get
            {
                return m_look;
            }
            set
            {
                m_look = value;
            }
        }
        
        private byte m_index;
        
        public virtual byte Index
        {
            get
            {
                return m_index;
            }
            set
            {
                m_index = value;
            }
        }
        
        public IndexedEntityLook(EntityLook look, byte index)
        {
            m_look = look;
            m_index = index;
        }
        
        public IndexedEntityLook()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_look.Serialize(writer);
            writer.WriteByte(m_index);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_look = new EntityLook();
            m_look.Deserialize(reader);
            m_index = reader.ReadByte();
        }
    }
}