using APIPlugin;
using DiskCardGame;
using InscryptionAPI.Card;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    public class GrueAttackColourOverride : SpecialCardBehaviour
    {
        public static SpecialTriggeredAbility ability;
        public static void Init()
        {
            ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "GrueAttackColourOverride", typeof(GrueAttackColourOverride)).Id;
        }
        public override void ManagedUpdate()
        {
            if (base.PlayableCard != null && base.PlayableCard.renderInfo != null)
            {
                if (base.PlayableCard.renderInfo.attackTextColor != Color.white)
                {
                    base.PlayableCard.renderInfo.attackTextColor = Color.white;
                }
            }
        }
        public override bool RespondsToDrawn()
        {
            return true;
        }
        public override IEnumerator OnDrawn()
        {
            base.PlayableCard.renderInfo.attackTextColor = Color.white;
            yield break;
        }
    }
}
