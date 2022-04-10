using Arrowgene.Buffers;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.Shared.Entity.PacketStructure
{
    public class C2SInstanceTreasurePointGetCategoryListReq : IPacketStructure
    {
        public PacketId Id => PacketId.C2S_INSTANCE_TREASURE_POINT_GET_CATEGORY_LIST_REQ;

        public uint Data0 { get; set; }

        public C2SInstanceTreasurePointGetCategoryListReq()
        {
            Data0 = 0;
        }

        public class Serializer : PacketEntitySerializer<C2SInstanceTreasurePointGetCategoryListReq>
        {
            public override void Write(IBuffer buffer, C2SInstanceTreasurePointGetCategoryListReq obj)
            {
                WriteUInt32(buffer, obj.Data0);
            }

            public override C2SInstanceTreasurePointGetCategoryListReq Read(IBuffer buffer)
            {
                C2SInstanceTreasurePointGetCategoryListReq obj = new C2SInstanceTreasurePointGetCategoryListReq();
                obj.Data0 = ReadUInt32(buffer);
                return obj;
            }
        }
    }
}
