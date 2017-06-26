//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Guild
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GuildEmblem : NetworkType
    {
        
        public const short ProtocolId = 87;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_symbolShape;
        
        public virtual ushort SymbolShape
        {
            get
            {
                return m_symbolShape;
            }
            set
            {
                m_symbolShape = value;
            }
        }
        
        private int m_symbolColor;
        
        public virtual int SymbolColor
        {
            get
            {
                return m_symbolColor;
            }
            set
            {
                m_symbolColor = value;
            }
        }
        
        private byte m_backgroundShape;
        
        public virtual byte BackgroundShape
        {
            get
            {
                return m_backgroundShape;
            }
            set
            {
                m_backgroundShape = value;
            }
        }
        
        private int m_backgroundColor;
        
        public virtual int BackgroundColor
        {
            get
            {
                return m_backgroundColor;
            }
            set
            {
                m_backgroundColor = value;
            }
        }
        
        public GuildEmblem(ushort symbolShape, int symbolColor, byte backgroundShape, int backgroundColor)
        {
            m_symbolShape = symbolShape;
            m_symbolColor = symbolColor;
            m_backgroundShape = backgroundShape;
            m_backgroundColor = backgroundColor;
        }
        
        public GuildEmblem()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_symbolShape);
            writer.WriteInt(m_symbolColor);
            writer.WriteByte(m_backgroundShape);
            writer.WriteInt(m_backgroundColor);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_symbolShape = reader.ReadVarUhShort();
            m_symbolColor = reader.ReadInt();
            m_backgroundShape = reader.ReadByte();
            m_backgroundColor = reader.ReadInt();
        }
    }
}