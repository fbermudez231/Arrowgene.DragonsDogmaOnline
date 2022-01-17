using Arrowgene.Buffers;
using Arrowgene.Ddon.Shared.Entity.Structure;

namespace Arrowgene.Ddon.Shared.Entity.PacketStructure
{
    public class L2CGetLoginSettingsRes : IPacketStructure
    {
        public L2CGetLoginSettingsRes()
        {
            LoginSetting = new CDataLoginSetting();
        }

        public PacketId Id => PacketId.L2C_GET_LOGIN_SETTING_RES;

        public CDataLoginSetting LoginSetting;
    }

    public class L2CGetLoginSettingsResSerializer : EntitySerializer<L2CGetLoginSettingsRes>
    {
        public override void Write(IBuffer buffer, L2CGetLoginSettingsRes obj)
        {
            WriteEntity(buffer, obj.LoginSetting);
        }

        public override L2CGetLoginSettingsRes Read(IBuffer buffer)
        {
            L2CGetLoginSettingsRes obj = new L2CGetLoginSettingsRes();
            obj.LoginSetting = ReadEntity<CDataLoginSetting>(buffer);
            return obj;
        }
    }
}
