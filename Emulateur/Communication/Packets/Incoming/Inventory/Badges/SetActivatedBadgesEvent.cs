using Butterfly.Communication.Packets.Outgoing;
using Butterfly.Database.Interfaces;
using Butterfly.HabboHotel.GameClients;
using Butterfly.HabboHotel.Quests;
using Butterfly.HabboHotel.Users.Badges;

namespace Butterfly.Communication.Packets.Incoming.Structure
{
    class SetActivatedBadgesEvent : IPacketEvent
    {
        public void Parse(GameClient Session, ClientPacket Packet)
        {
            Session.GetHabbo().GetBadgeComponent().ResetSlots();
        }
    }
}