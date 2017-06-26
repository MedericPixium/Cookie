//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Character.Status
{
    using Cookie.API.Utils.IO;
    using Cookie.API.Protocol.Network.Types.Game.Character.Status;


    public class PlayerStatusUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6386;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PlayerStatus m_status;
        
        public virtual PlayerStatus Status
        {
            get
            {
                return m_status;
            }
            set
            {
                m_status = value;
            }
        }
        
        private int m_accountId;
        
        public virtual int AccountId
        {
            get
            {
                return m_accountId;
            }
            set
            {
                m_accountId = value;
            }
        }
        
        private ulong m_playerId;
        
        public virtual ulong PlayerId
        {
            get
            {
                return m_playerId;
            }
            set
            {
                m_playerId = value;
            }
        }
        
        public PlayerStatusUpdateMessage(PlayerStatus status, int accountId, ulong playerId)
        {
            m_status = status;
            m_accountId = accountId;
            m_playerId = playerId;
        }
        
        public PlayerStatusUpdateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteUShort(((ushort)(m_status.TypeID)));
            m_status.Serialize(writer);
            writer.WriteInt(m_accountId);
            writer.WriteVarUhLong(m_playerId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_status = ProtocolTypeManager.GetInstance<PlayerStatus>((short)reader.ReadUShort());
            m_status.Deserialize(reader);
            m_accountId = reader.ReadInt();
            m_playerId = reader.ReadVarUhLong();
        }
    }
}