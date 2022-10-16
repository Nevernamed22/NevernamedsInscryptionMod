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
    public class LiliputianPileup : SpecialCardBehaviour
    {
        public static SpecialTriggeredAbility ability;
        public static void Init()
        {
            ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "LiliputianPileup", typeof(LiliputianPileup)).Id;
        

        amountSprites = new Dictionary<int, Sprite>()
            {
                {1, Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/liliputianskeleton_pixel_1.png"))},
                {2, Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/liliputianskeleton_pixel_2.png"))},
                {3, Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/liliputianskeleton_pixel_3.png"))},
                {4, Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/liliputianskeleton_pixel_4.png"))},
                {5, Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/liliputianskeleton_pixel_5.png"))},
                {6, Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/liliputianskeleton_pixel_6.png"))},
                {7, Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/liliputianskeleton_pixel_7.png"))},
                {8, Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/liliputianskeleton_pixel_8.png"))},
            };
        }
        public static Dictionary<int, Sprite> amountSprites;
        public int PileAmount = 1;
        public override bool RespondsToOtherCardResolve(PlayableCard otherCard)
        {
            if (otherCard && otherCard.OnBoard && otherCard != base.PlayableCard &&  otherCard.GetComponent<LiliputianPileup>() && otherCard.GetComponent<LiliputianPileup>().PileAmount == 1) return true;
            else return false;
        }
        public override bool RespondsToTakeDamage(PlayableCard source)
        {
            return PileAmount > 1;
        }
        public override IEnumerator OnTakeDamage(PlayableCard source)
        {
            if (PileAmount > 1 && base.PlayableCard.Health > 0)
            {
                int newAmt = base.PlayableCard.Health;
                base.PlayableCard.temporaryMods.Add(new CardModificationInfo(base.PlayableCard.Health - PileAmount, 0));

                PileAmount = newAmt;
                if (PileAmount < 9)
                {
                    CardInfo clone = CardLoader.Clone(base.PlayableCard.Info);
                    clone.pixelPortrait = amountSprites[PileAmount];
                    base.PlayableCard.SetInfo(clone);
                    base.Card.RenderCard();
                }
            }
            yield break;
        }
        public override bool RespondsToDie(bool wasSacrifice, PlayableCard killer)
        {
            return (PileAmount > 1);
        }
        public override IEnumerator OnDie(bool wasSacrifice, PlayableCard killer)
        {
            yield return Singleton<ResourcesManager>.Instance.AddBones(PileAmount - 1, base.PlayableCard.Slot);
            yield break;
        }
        public override IEnumerator OnOtherCardResolve(PlayableCard otherCard)
        {
            otherCard.UnassignFromSlot();
            UnityEngine.Object.Destroy(otherCard.gameObject);

            base.Card.Anim.StrongNegationEffect();
            base.PlayableCard.temporaryMods.Add(new CardModificationInfo(1, 1));

            PileAmount++;
            if (PileAmount < 9)
            {
                base.PlayableCard.Info.pixelPortrait = amountSprites[PileAmount];
            base.Card.RenderCard();
            }
            yield break;
        }
    }
}
