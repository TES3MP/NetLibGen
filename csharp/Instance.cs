using System;

namespace TES3MPSharp
{
    public class Instance
    {
        public virtual void OnServerInit()
        {
        }
        public virtual void OnServerPostInit()
        {
        }
        public virtual void OnServerExit(int code)
        {
        }
        public virtual void OnPlayerConnect(ushort pid)
        {
        }
        public virtual void OnPlayerDisconnect(ushort pid)
        {
        }
        public virtual void OnPlayerDeath(ushort pid)
        {
        }
        public virtual void OnPlayerResurrect(ushort pid)
        {
        }
        public virtual void OnPlayerCellChange(ushort pid)
        {
        }
        public virtual void OnPlayerAttribute(ushort pid)
        {
        }
        public virtual void OnPlayerSkill(ushort pid)
        {
        }
        public virtual void OnPlayerLevel(ushort pid)
        {
        }
        public virtual void OnPlayerBounty(ushort pid)
        {
        }
        public virtual void OnPlayerReputation(ushort pid)
        {
        }
        public virtual void OnPlayerEquipment(ushort pid)
        {
        }
        public virtual void OnPlayerInventory(ushort pid)
        {
        }
        public virtual void OnPlayerJournal(ushort pid)
        {
        }
        public virtual void OnPlayerFaction(ushort pid)
        {
        }
        public virtual void OnPlayerShapeshift(ushort pid)
        {
        }
        public virtual void OnPlayerSpellbook(ushort pid)
        {
        }
        public virtual void OnPlayerQuickKeys(ushort pid)
        {
        }
        public virtual void OnPlayerTopic(ushort pid)
        {
        }
        public virtual void OnPlayerDisposition(ushort pid)
        {
        }
        public virtual void OnPlayerBook(ushort pid)
        {
        }
        public virtual void OnPlayerItemUse(ushort pid)
        {
        }
        public virtual void OnPlayerMiscellaneous(ushort pid)
        {
        }
        public virtual void OnPlayerInput(ushort pid)
        {
        }
        public virtual void OnPlayerRest(ushort pid)
        {
        }
        public virtual void OnPlayerSendMessage(ushort pid, string message)
        {
        }
        public virtual void OnPlayerEndCharGen(ushort pid)
        {
        }

        public virtual void OnGUIAction(ushort pid, int idGui, string data)
        {
        }

        public virtual void OnRecordDynamic(ushort pid)
        {
        }

        public virtual void OnCellLoad(ushort pid, string cellDescription)
        {
        }
        public virtual void OnCellUnload(ushort pid, string cellDescription)
        {
        }
        public virtual void OnCellDeletion(string cellDescription)
        {
        }

        public virtual void OnContainer(ushort pid, string cellDescription)
        {
        }
        public virtual void OnDoorState(ushort pid, string cellDescription)
        {
        }
        public virtual void OnObjectActivate(ushort pid, string cellDescription)
        {
        }
        public virtual void OnObjectPlace(ushort pid, string cellDescription)
        {
        }
        public virtual void OnObjectState(ushort pid, string cellDescription)
        {
        }
        public virtual void OnObjectSpawn(ushort pid, string cellDescription)
        {
        }
        public virtual void OnObjectDelete(ushort pid, string cellDescription)
        {
        }
        public virtual void OnObjectLock(ushort pid, string cellDescription)
        {
        }
        public virtual void OnObjectScale(ushort pid, string cellDescription)
        {
        }
        public virtual void OnObjectTrap(ushort pid, string cellDescription)
        {
        }
        public virtual void OnVideoPlay(ushort pid, string cellDescription)
        {
        }

        public virtual void OnActorList(ushort pid, string cellDescription)
        {
        }
        public virtual void OnActorEquipment(ushort pid, string cellDescription)
        {
        }
        public virtual void OnActorAI(ushort pid, string cellDescription)
        {
        }
        public virtual void OnActorDeath(ushort pid, string cellDescription)
        {
        }
        public virtual void OnActorCellChange(ushort pid, string cellDescription)
        {
        }
        public virtual void OnActorTest(ushort pid, string cellDescription)
        {
        }

        public virtual void OnWorldKillCount(ushort pid)
        {
        }
        public virtual void OnWorldMap(ushort pid)
        {
        }
        public virtual void OnWorldWeather(ushort pid)
        {
        }

        public virtual void OnMpNumIncrement(int mpNum)
        {
        }
        public virtual void OnRequestPluginList()
        {
        }
    }
}
