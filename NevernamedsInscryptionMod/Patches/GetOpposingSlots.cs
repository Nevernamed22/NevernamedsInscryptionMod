using DiskCardGame;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace NevernamedsInscryptionMod
{
    [HarmonyPatch]
    public class GetOpposingSlotsPatches
    {
        [HarmonyPostfix, HarmonyPatch(typeof(PlayableCard), nameof(PlayableCard.GetOpposingSlots))]
        public static void GetOpposingSlotsPatch(PlayableCard __instance, ref List<CardSlot> __result)
        {
            bool isTri = __instance.HasTriStrike();
            bool isBif = __instance.HasAbility(Ability.SplitStrike);
            bool isDouble = __instance.HasAbility(Ability.DoubleStrike);
            bool isSniper = __instance.HasAbility(Ability.Sniper);

            if (__instance.Info.name == "BeastNevernamed Grue")
            {
                int snuffedCandles = 0;
                CardSlot opposingSlot = __instance.slot.opposingSlot;
                snuffedCandles += (RunState.Run.maxPlayerLives - RunState.Run.playerLives);
                snuffedCandles += (Singleton<TurnManager>.Instance.opponent.StartingLives - Singleton<TurnManager>.Instance.opponent.NumLives);
                if (opposingSlot && snuffedCandles > 0)
                {
                    for (int i = 0; i < snuffedCandles; i++)
                    {
                        __result.Add(opposingSlot);
                    }
                }
            }      
        }
    }
}
