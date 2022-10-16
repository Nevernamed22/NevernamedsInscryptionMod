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
    public class BoardWipe : SpecialCardBehaviour
    {
        public static SpecialTriggeredAbility ability;

        public static void Init()
        {
            ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "BoardWipe", typeof(BoardWipe)).Id;
        }
        public override bool RespondsToResolveOnBoard()
        {
            return true;
        }
        public override IEnumerator OnResolveOnBoard()
        {
            List<CardSlot> availableSlots = new List<CardSlot>(Singleton<BoardManager>.Instance.GetSlots(true));
            availableSlots.AddRange(Singleton<BoardManager>.Instance.GetSlots(false));
            foreach (CardSlot slot in availableSlots)
            {
                if (slot.Card != null && slot.Card != base.Card && !slot.Card.HasTrait(Trait.Uncuttable))
                {
                    yield return GlitchOutCard(slot.Card);
                    yield return new WaitForSeconds(0.1f);
                }
            }
            yield return new WaitForSeconds(0.25f);
            DeckInfo deck = SaveManager.SaveFile.CurrentDeck;
            CardInfo card = deck.Cards.Find((CardInfo x) => x.name == base.Card.Info.name);
            deck.RemoveCard(card);
            yield return GlitchOutCard(base.PlayableCard);
            yield break;
        }
        private IEnumerator GlitchOutCard(PlayableCard card)
        {
            card.UnassignFromSlot();
            GlitchOutAssetEffect.GlitchModel(card.transform, true, true);
            AudioController.Instance.PlaySound2D("glitch_error", MixerGroup.TableObjectsSFX, 1f, 0f, null, null, null, null, false);
            yield break;
        }
    }
}
