using Butterfly.HabboHotel.GameClients;
using Butterfly.HabboHotel.Rooms;
using Butterfly.HabboHotel.Rooms.Wired;

namespace Butterfly.Communication.Packets.Incoming.Structure
{
    class SaveWiredConfigEvent : IPacketEvent
    {
        public void Parse(GameClient Session, ClientPacket Packet)
        {
			Room room = Session.GetHabbo().CurrentRoom;
        }
    }
}