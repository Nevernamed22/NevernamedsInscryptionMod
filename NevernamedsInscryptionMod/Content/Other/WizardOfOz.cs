using APIPlugin;
using DiskCardGame;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;
using GBC;

namespace NevernamedsInscryptionMod
{
    public class WizardOfOz : SpecialCardBehaviour
    {
        public static SpecialTriggeredAbility ability;

        public static void Init()
        {
            ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "WizardOfOz", typeof(WizardOfOz)).Id;
        }
        public override bool RespondsToResolveOnBoard()
        {
            List<CardSlot> slots = Singleton<BoardManager>.Instance.GetSlots(!base.PlayableCard.OpponentCard);
            return slots.Exists(x => x.Card != null && x.Card.Info.name == "TechNevernamed TinMan") &&
                slots.Exists(x => x.Card != null && x.Card.Info.name == "BeastNevernamed CowardlyLion") &&
                slots.Exists(x => x.Card != null && x.Card.Info.name == "DeadNevernamed Scarecrow");
        }
        public override IEnumerator OnResolveOnBoard()
        {
            bool hasKilledScarecrow = false;
            bool hasKilledTinMan = false;
            bool hasKilledCowardlyLion = false;
            foreach (CardSlot slot in Singleton<BoardManager>.Instance.GetSlots(!base.PlayableCard.OpponentCard))
            {
                if (slot.Card != null && slot.Card != base.PlayableCard)
                {
                    if (slot.Card.Info.name == "TechNevernamed TinMan" && !hasKilledTinMan)
                    {
                        yield return slot.Card.Die(true);
                        hasKilledTinMan = true;
                    }
                    else if(slot.Card.Info.name == "DeadNevernamed Scarecrow" && !hasKilledScarecrow)
                    {
                        yield return slot.Card.Die(true);
                        hasKilledScarecrow = true;
                    }
                    else if (slot.Card.Info.name == "BeastNevernamed CowardlyLion" && !hasKilledCowardlyLion)
                    {
                        yield return slot.Card.Die(true);
                        hasKilledCowardlyLion = true;
                    }
                }
            }


            CardInfo evolution = CardLoader.GetCardByName("WizardNevernamed Oz");
                foreach (CardModificationInfo cardModificationInfo in base.Card.Info.Mods.FindAll((CardModificationInfo x) => !x.nonCopyable))
                {
                    evolution.Mods.Add((CardModificationInfo)cardModificationInfo.Clone());
                }
            yield return Singleton<TextBox>.Instance.ShowUntilInput("Behold, the great and powerful OZ!", TextBox.Style.Magic, null, TextBox.ScreenPosition.ForceBottom, 0f, true, false, null, false, Emotion.Neutral);
            yield return base.PlayableCard.TransformIntoCard(evolution, null, null);
            yield break;
        }
    }
}
