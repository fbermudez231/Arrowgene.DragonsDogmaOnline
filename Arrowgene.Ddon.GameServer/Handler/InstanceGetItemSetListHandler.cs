﻿using Arrowgene.Ddon.GameServer.Dump;
using Arrowgene.Ddon.Server.Logging;
using Arrowgene.Ddon.Shared;
using Arrowgene.Logging;

namespace Arrowgene.Ddon.GameServer.Handler
{
    public class InstanceGetItemSetListHandler : PacketHandler<GameClient>
    {
        private static readonly DdonLogger Logger = LogProvider.Logger<DdonLogger>(typeof(InstanceGetItemSetListHandler));


        public InstanceGetItemSetListHandler(DdonGameServer server) : base(server)
        {
        }

        public override PacketId Id => PacketId.C2S_INSTANCE_GET_ITEM_SET_LIST_REQ;

        public override void Handle(GameClient client, Packet packet)
        {
            client.Send(SelectedDump.Dump_93283);
        }
    }
}
