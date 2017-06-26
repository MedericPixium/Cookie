//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Preset
{
    using Cookie.API.Protocol.Network.Types.Game.Inventory.Preset;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class InventoryPresetUpdateMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6171;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private Preset m_preset;
        
        public virtual Preset Preset
        {
            get
            {
                return m_preset;
            }
            set
            {
                m_preset = value;
            }
        }
        
        public InventoryPresetUpdateMessage(Preset preset)
        {
            m_preset = preset;
        }
        
        public InventoryPresetUpdateMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            m_preset.Serialize(writer);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_preset = new Preset();
            m_preset.Deserialize(reader);
        }
    }
}