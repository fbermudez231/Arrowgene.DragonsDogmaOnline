using Arrowgene.Buffers;

namespace Arrowgene.Ddon.Shared.Entity.Structure
{
    public class CDataSetAcquirementParam
    {
        public CDataSetAcquirementParam()
        {
            Job=0;
            Type=0;
            SlotNo=0;
            AcquirementNo=0;
            AcquirementLv=0;
        }

        public byte Job { get; set; }
        public byte Type { get; set; }
        public byte SlotNo { get; set; }
        public uint AcquirementNo { get; set; }
        public byte AcquirementLv { get; set; }

        public class Serializer : EntitySerializer<CDataSetAcquirementParam>
        {
            public override void Write(IBuffer buffer, CDataSetAcquirementParam obj)
            {
                WriteByte(buffer, obj.Job);
                WriteByte(buffer, obj.Type);
                WriteByte(buffer, obj.SlotNo);
                WriteUInt32(buffer, obj.AcquirementNo);
                WriteByte(buffer, obj.AcquirementLv);
            }

            public override CDataSetAcquirementParam Read(IBuffer buffer)
            {
                CDataSetAcquirementParam obj = new CDataSetAcquirementParam();
                obj.Job = ReadByte(buffer);
                obj.Type = ReadByte(buffer);
                obj.SlotNo = ReadByte(buffer);
                obj.AcquirementNo = ReadUInt32(buffer);
                obj.AcquirementLv = ReadByte(buffer);
                return obj;
            }
        }
    }
}
