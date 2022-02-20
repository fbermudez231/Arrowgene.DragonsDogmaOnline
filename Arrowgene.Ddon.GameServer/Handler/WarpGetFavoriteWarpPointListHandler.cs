﻿using Arrowgene.Ddon.GameServer.Dump;
using Arrowgene.Ddon.Server;
using Arrowgene.Ddon.Server.Network;
using Arrowgene.Ddon.Shared.Network;
using Arrowgene.Logging;

namespace Arrowgene.Ddon.GameServer.Handler
{
    public class WarpGetFavoriteWarpPointListHandler : PacketHandler<GameClient>
    {
        private static readonly ServerLogger Logger = LogProvider.Logger<ServerLogger>(typeof(WarpGetFavoriteWarpPointListHandler));


        public WarpGetFavoriteWarpPointListHandler(DdonGameServer server) : base(server)
        {
        }

        public override PacketId Id => PacketId.C2S_WARP_GET_FAVORITE_WARP_POINT_LIST_REQ;

        public override void Handle(GameClient client, IPacket packet)
        {
            client.Send(InGameDump.Dump_23);
        }
    }
}
