using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSSellBackpackGoodsPacket : GamePacket
    {
        public CSSellBackpackGoodsPacket() : base(CSOffsets.CSSellBackpackGoodsPacket, 5)
        {
        }

        public override void Read(PacketStream stream)
        {
            var objId = stream.ReadBc();

            _log.Warn("CSSellBackpackGoods, ObjId: {0}", objId);
        }
    }
}
