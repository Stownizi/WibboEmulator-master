using Butterfly.Communication.Packets.Outgoing.Structure;
using Butterfly.HabboHotel.GameClients;

namespace Butterfly.Communication.Packets.Incoming.Structure
            int roomID = Packet.PopInt();

            RoomData roomData = ButterflyEnvironment.GetGame().GetRoomManager().GenerateRoomData(roomID);
            if (roomData == null)
                return;

            Boolean isLoading = Packet.PopInt() == 1;
            Boolean checkEntry = Packet.PopInt() == 1;

            Session.SendPacket(new GetGuestRoomResultComposer(Session, roomData, isLoading, checkEntry));