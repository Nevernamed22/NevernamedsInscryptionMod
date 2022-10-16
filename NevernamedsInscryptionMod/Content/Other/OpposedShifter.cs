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
    public class OpposedShifter : SpecialCardBehaviour
    {
        public static SpecialTriggeredAbility ability;

        public static void Init()
        {
            ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "OpposedShifter", typeof(OpposedShifter)).Id;
        

        BeastPortrait = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/empusa_beast.png"));
            BeastForm = new CardModificationInfo();
            BeastForm.attackAdjustment = 2;
            BeastForm.negateAbilities.Add(Cute.ability);
            BeastForm.negateAbilities.Add(Allure.ability);
            BeastForm.abilities.Add(Ability.Deathtouch);
            BeastForm.abilities.Add(Vampiric.ability);
        }
        bool isOpposed = false;
        public static CardModificationInfo BeastForm;
        public static Sprite BeastPortrait;
        public override bool RespondsToResolveOnBoard()
        {
            return true;
        }
        public override IEnumerator OnResolveOnBoard()
        {
            
            
            yield break;
        }
        public override void ManagedUpdate()
        {
            if (base.PlayableCard && base.PlayableCard.OnBoard && base.PlayableCard.slot && base.PlayableCard.slot.opposingSlot)
            {
                if (base.PlayableCard.slot.opposingSlot.Card != null && isOpposed == false)
                {
                    base.PlayableCard.AddTemporaryMod(BeastForm);
                    base.PlayableCard.Status.hiddenAbilities.Add(Cute.ability);
                    base.PlayableCard.Status.hiddenAbilities.Add(Allure.ability);
                    base.PlayableCard.SwitchToPortrait(BeastPortrait);
                    base.PlayableCard.RenderCard();
                    
                    isOpposed = true;
                }
                else if (base.PlayableCard.slot.opposingSlot.Card == null && isOpposed == true)
                {
                    base.PlayableCard.RemoveTemporaryMod(BeastForm);
                    base.PlayableCard.Status.hiddenAbilities.Remove(Cute.ability);
                    base.PlayableCard.Status.hiddenAbilities.Remove(Allure.ability);
                    base.PlayableCard.SwitchToDefaultPortrait();
                    base.PlayableCard.RenderCard();

                    isOpposed = false;
                }
            }
            base.ManagedUpdate();
        }
    }
}
