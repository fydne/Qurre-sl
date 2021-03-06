﻿using Qurre.API.Events;
using Qurre.Events.modules;
namespace Qurre.Events
{
    public static class Player
    {
        public static event main.AllEvents<SpawnEvent> Spawn;
        public static event main.AllEvents<InteractLiftEvent> InteractLift;
        public static event main.AllEvents<InteractDoorEvent> InteractDoor;
        public static event main.AllEvents<InteractEvent> Interact;
        public static event main.AllEvents<DyingEvent> Dying;
        public static event main.AllEvents<DamageEvent> Damage;
        public static event main.AllEvents<UnCuffEvent> UnCuff;
        public static event main.AllEvents<InteractLockerEvent> InteractLocker;
        public static event main.AllEvents<CuffEvent> Cuff;
        public static event main.AllEvents<DiedEvent> Died;
        public static event main.AllEvents<RoleChangeEvent> RoleChange;
        public static event main.AllEvents<ItemChangeEvent> ItemChange;
        public static event main.AllEvents<GroupChangeEvent> GroupChange;
        public static event main.AllEvents<KickEvent> Kick;
        public static event main.AllEvents<BanEvent> Ban;
        public static event main.AllEvents<EscapeEvent> Escape;
        public static event main.AllEvents<IcomSpeakEvent> IcomSpeak;
        public static event main.AllEvents<DroppingItemEvent> DroppingItem;
        public static event main.AllEvents<DropItemEvent> DropItem;
        public static event main.AllEvents<InteractGeneratorEvent> InteractGenerator;
        public static event main.AllEvents<TeslaTriggerEvent> TeslaTrigger;
        public static event main.AllEvents<ThrowGrenadeEvent> ThrowGrenade;
        public static event main.AllEvents<SyncDataEvent> SyncData;
        public static event main.AllEvents<UsedMedicalEvent> UsedMedical;
        public static event main.AllEvents<UsingMedicalEvent> UsingMedical;
        public static event main.AllEvents<SpeakEvent> Speak;
        public static event main.AllEvents<StoppingMedicalUsingEvent> StoppingMedicalUsing;
        public static event main.AllEvents<ShootingEvent> Shooting;
        public static event main.AllEvents<RechargeWeaponEvent> RechargeWeapon;
        public static event main.AllEvents<PickupItemEvent> PickupItem;
        public static event main.AllEvents<LeaveEvent> Leave;
        public static event main.AllEvents<KickedEvent> Kicked;
        public static event main.AllEvents<JoinEvent> Join;
        public static event main.AllEvents<RagdollSpawnEvent> RagdollSpawn;
        public static event main.AllEvents<BannedEvent> Banned;

        public static void ban(BanEvent ev);
        public static void banned(BannedEvent ev);
        public static void cuff(CuffEvent ev);
        public static void damage(DamageEvent ev);
        public static void died(DiedEvent ev);
        public static void dropItem(DropItemEvent ev);
        public static void droppingItem(DroppingItemEvent ev);
        public static void dying(DyingEvent ev);
        public static void escape(EscapeEvent ev);
        public static void groupchange(GroupChangeEvent ev);
        public static void icomSpeak(IcomSpeakEvent ev);
        public static void interact(InteractEvent ev);
        public static void interactdoor(InteractDoorEvent ev);
        public static void interactGenerator(InteractGeneratorEvent ev);
        public static void interactLift(InteractLiftEvent ev);
        public static void interactLocker(InteractLockerEvent ev);
        public static void itemchange(ItemChangeEvent ev);
        public static void join(JoinEvent ev);
        public static void kick(KickEvent ev);
        public static void kicked(KickedEvent ev);
        public static void leave(LeaveEvent ev);
        public static void pickupItem(PickupItemEvent ev);
        public static void ragdollSpawn(RagdollSpawnEvent ev);
        public static void rechargeWeapon(RechargeWeaponEvent ev);
        public static void rolechange(RoleChangeEvent ev);
        public static void shooting(ShootingEvent ev);
        public static void spawn(SpawnEvent ev);
        public static void speak(SpeakEvent ev);
        public static void stoppingMedicalUsing(StoppingMedicalUsingEvent ev);
        public static void syncData(SyncDataEvent ev);
        public static void teslaTrigger(TeslaTriggerEvent ev);
        public static void throwGrenade(ThrowGrenadeEvent ev);
        public static void unCuff(UnCuffEvent ev);
        public static void usedMedical(UsedMedicalEvent ev);
        public static void usingMedical(UsingMedicalEvent ev);
    }
}