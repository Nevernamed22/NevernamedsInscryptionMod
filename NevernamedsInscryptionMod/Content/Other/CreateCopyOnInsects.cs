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
    public class CreateCopyOnInsects : SpecialCardBehaviour
    {
        public static SpecialTriggeredAbility ability;

        public static void Init()
        {
            ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "CreateCopyOnInsects", typeof(CreateCopyOnInsects)).Id;
        }
        public override bool RespondsToOtherCardResolve(PlayableCard otherCard)
        {
            if ((otherCard.OpponentCard == base.PlayableCard.OpponentCard) && (otherCard.Info.tribes.Contains(Tribe.Insect) || otherCard.Info.tribes.Contains(NevernamedsTribes.Arachnid)) && (otherCard.GetComponent<CreateCopyOnInsects>() == null)) return true;
            else return false;
        }
        public override IEnumerator OnOtherCardResolve(PlayableCard otherCard)
        {
            if (otherCard && !otherCard.Dead)
            {
                Singleton<ViewManager>.Instance.SwitchToView(View.Board, false, false);
                CardSlot targetSlot = otherCard.slot;

                yield return otherCard.Die(true, base.PlayableCard, true);

                yield return Singleton<BoardManager>.Instance.CreateCardInSlot(base.Card.Info, targetSlot, 0.15f, true);

                base.Card.Anim.StrongNegationEffect();
                yield return new WaitForSeconds(0.1f);
                yield break;
            }
        }
    }
}
