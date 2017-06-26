//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Game.Data.Items
{
    using Cookie.API.Utils.IO;


    public class ObjectItemInformationWithQuantity : ObjectItemMinimalInformation
    {
        
        public new const short ProtocolId = 387;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ObjectItemInformationWithQuantity(uint quantity)
        {
            m_quantity = quantity;
        }
        
        public ObjectItemInformationWithQuantity()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhInt(m_quantity);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_quantity = reader.ReadVarUhInt();
        }
    }
}