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
    public class ChaosCardBehaviour : SpecialCardBehaviour
    {
        public static SpecialTriggeredAbility ability;

        public static void Init()
        {
            ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "ChaosCardBehaviour", typeof(ChaosCardBehaviour)).Id;
        }
        public override bool RespondsToDrawn()
        {
            return base.Card && base.Card.Info;
        }
        public override IEnumerator OnDrawn()
        {
			if (Singleton<PlayerHand>.Instance is PlayerHand3D)
			{
				(Singleton<PlayerHand>.Instance as PlayerHand3D).MoveCardAboveHand(base.PlayableCard);
			}
			yield return new WaitForSeconds(0.5f);
			Singleton<UIManager>.Instance.Effects.GetEffect<ScreenGlitchEffect>().SetIntensity(1f, 0.2f);
			AudioController.Instance.PlaySound2D("glitch", MixerGroup.None, 1f, 0f, null, null, null, null, false);
			base.Card.Anim.LightNegationEffect();

			DeckInfo currentDeck = SaveManager.SaveFile.CurrentDeck;
			CardInfo card = currentDeck.Cards.Find((CardInfo x) => x == base.Card.Info);
			currentDeck.RemoveCard(card);

			CardInfo deathcard = CustomDeathcardPortrait.CompletelyRandomAnimalDeathcard(UnityEngine.Random.Range(5, 9), UnityEngine.Random.value <= 0.25f ? 0 : 1);

			base.PlayableCard.ClearAppearanceBehaviours();
			base.PlayableCard.SetInfo(deathcard);

			SaveManager.SaveFile.CurrentDeck.AddCard(deathcard);

			yield return new WaitForSeconds(0.5f);
			yield break;
		}
    }
}
