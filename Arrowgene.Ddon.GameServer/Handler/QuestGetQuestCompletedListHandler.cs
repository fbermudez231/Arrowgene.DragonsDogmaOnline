﻿using Arrowgene.Ddon.GameServer.Dump;
using Arrowgene.Ddon.Server;
using Arrowgene.Ddon.Server.Network;
using Arrowgene.Ddon.Shared.Network;
using Arrowgene.Logging;

namespace Arrowgene.Ddon.GameServer.Handler
{
    public class QuestGetQuestCompletedListHandler : PacketHandler<GameClient>
    {
        private static readonly ServerLogger Logger = LogProvider.Logger<ServerLogger>(typeof(QuestGetQuestCompletedListHandler));


        public QuestGetQuestCompletedListHandler(DdonGameServer server) : base(server)
        {
        }

        public override PacketId Id => PacketId.C2S_QUEST_GET_QUEST_COMPLETE_LIST_REQ;

        public override void Handle(GameClient client, IPacket packet)
        {
            client.Send(GameFull.Dump_126);
        }
    }
}
