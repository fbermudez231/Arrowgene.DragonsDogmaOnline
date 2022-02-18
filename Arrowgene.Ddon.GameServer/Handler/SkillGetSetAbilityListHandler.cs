using Arrowgene.Ddon.Server;
using Arrowgene.Ddon.Server.Network;
using Arrowgene.Ddon.Shared.Entity.PacketStructure;
using Arrowgene.Logging;

namespace Arrowgene.Ddon.GameServer.Handler
{
    public class SkillGetSetAbilityListHandler : StructurePacketHandler<GameClient, C2SSkillGetSetAbilityListReq>
    {
        private static readonly ServerLogger Logger = LogProvider.Logger<ServerLogger>(typeof(SkillGetSetAbilityListHandler));

        public SkillGetSetAbilityListHandler(DdonGameServer server) : base(server)
        {
        }

        public override void Handle(GameClient client, StructurePacket<C2SSkillGetSetAbilityListReq> packet)
        {
            client.Send(new S2CSkillGetSetAbilityListRes());
        }
    }
}