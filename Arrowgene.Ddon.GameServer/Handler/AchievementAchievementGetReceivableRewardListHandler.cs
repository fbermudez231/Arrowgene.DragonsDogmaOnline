﻿using Arrowgene.Ddon.GameServer.Dump;
using Arrowgene.Ddon.Server.Logging;
using Arrowgene.Ddon.Shared;
using Arrowgene.Logging;

namespace Arrowgene.Ddon.GameServer.Handler
{
    public class AchievementAchievementGetReceivableRewardListHandler : PacketHandler<GameClient>
    {
        private static readonly DdonLogger Logger = LogProvider.Logger<DdonLogger>(typeof(AchievementAchievementGetReceivableRewardListHandler));


        public AchievementAchievementGetReceivableRewardListHandler(DdonGameServer server) : base(server)
        {
        }

        public override PacketId Id => PacketId.C2S_ACHIEVEMENT_ACHIEVEMENT_GET_RECEIVABLE_REWARD_LIST_REQ;

        public override void Handle(GameClient client, Packet packet)
        {
            client.Send(InGameDump.Dump_91);
        }
    }
}
