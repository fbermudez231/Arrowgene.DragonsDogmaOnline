using Arrowgene.Buffers;
using Arrowgene.Ddon.Shared.Entity.Structure;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.Shared.Entity.PacketStructure
{
    public class S2CInstanceEnemyRepopNtc : IPacketStructure
    {
        public PacketId Id => PacketId.S2C_INSTANCE_13_40_16_NTC;

        public S2CInstanceEnemyRepopNtc()
        {
            LayoutId = new CStageLayoutID();
            EnemyData = new CDataLayoutEnemyData();
            WaitSecond = 0;
        }

        public CStageLayoutID LayoutId { get; set; }
        public CDataLayoutEnemyData EnemyData { get; set; }
        public uint WaitSecond { get; set; }

        public class Serializer : EntitySerializer<S2CInstanceEnemyRepopNtc>
        {
            public override void Write(IBuffer buffer, S2CInstanceEnemyRepopNtc obj)
            {
                WriteEntity<CStageLayoutID>(buffer, obj.LayoutId);
                WriteEntity<CDataLayoutEnemyData>(buffer, obj.EnemyData);
                WriteUInt32(buffer, obj.WaitSecond);
            }

            public override S2CInstanceEnemyRepopNtc Read(IBuffer buffer)
            {
                S2CInstanceEnemyRepopNtc obj = new S2CInstanceEnemyRepopNtc();
                obj.LayoutId = ReadEntity<CStageLayoutID>(buffer);
                obj.EnemyData = ReadEntity<CDataLayoutEnemyData>(buffer);
                obj.WaitSecond = ReadUInt32(buffer);
                return obj;
            }
        }
        
    }
}