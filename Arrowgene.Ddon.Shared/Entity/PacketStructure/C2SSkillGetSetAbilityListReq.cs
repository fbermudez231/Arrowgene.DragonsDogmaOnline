using Arrowgene.Buffers;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.Shared.Entity.PacketStructure
{
    public class C2SSkillGetSetAbilityListReq : IPacketStructure
    {
        public PacketId Id => PacketId.C2S_SKILL_GET_SET_ABILITY_LIST_REQ;

        public class Serializer : PacketEntitySerializer<C2SSkillGetSetAbilityListReq>
        {

            public override void Write(IBuffer buffer, C2SSkillGetSetAbilityListReq obj)
            {
            }

            public override C2SSkillGetSetAbilityListReq Read(IBuffer buffer)
            {
                return new C2SSkillGetSetAbilityListReq();
            }
        }
    }
}
