using APIPlugin;
using DiskCardGame;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    public class CreateCharredLump : SpecialCardBehaviour
    {
        public static SpecialTriggeredAbility ability;
        public override bool RespondsToOtherCardDie(PlayableCard card, CardSlot deathSlot, bool fromCombat, PlayableCard killer)
        {
			return killer == base.PlayableCard;
        }
        public static void Init()
        {
            ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "CreateCharredLump", typeof(CreateCharredLump)).Id;
        }
		public override bool RespondsToDie(bool wasSacrifice, PlayableCard killer)
		{
			return (base.PlayableCard.OnBoard && !wasSacrifice);
		}
        int kills = 0;
        public override IEnumerator OnOtherCardDie(PlayableCard card, CardSlot deathSlot, bool fromCombat, PlayableCard killer)
        {
            kills++;
            yield break;
        }
        public override IEnumerator OnDie(bool wasSacrifice, PlayableCard killer)
		{
			yield return new WaitForSeconds(0.35f);

			CardInfo lump = CardLoader.GetCardByName("BeastNevernamed CharredLump");
			lump.Mods.Add(base.PlayableCard.CondenseMods());
            lump.Mods.Add(new CardModificationInfo(0, kills));

            
			yield return Singleton<BoardManager>.Instance.CreateCardInSlot(lump, base.PlayableCard.Slot, 0.1f, true);
			yield return new WaitForSeconds(0.35f);
			yield break;
		}
	}
}
