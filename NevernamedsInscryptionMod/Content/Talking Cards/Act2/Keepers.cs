using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;
using System.Collections;
using GBC;

namespace NevernamedsInscryptionMod
{
    static class Keepers
    {
        public static void Init()
        {
            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "KeeperPixelTalker", typeof(KeeperPixelTalker)).Id;

            CardSetupUtility.NewCard("Nevernamed Keepers",
                "Keepers",
                1,
                3,
                new List<CardMetaCategory> {  },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                abilities: new List<Ability>() {  },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/snoligoster_pixel.png")
                );

            keeperSpeaker = new DialogueSpeaker()
            {
                characterId = KeepersCharacter,
            };
            keeperPortrait = new DialoguePortrait()
            {
                characterId = KeepersCharacter,

            };
        }
        public static DialogueSpeaker.Character KeepersCharacter = (DialogueSpeaker.Character)36421;
        public static DialogueSpeaker keeperSpeaker;
        public static DialoguePortrait keeperPortrait;
    }
    public class KeeperPixelTalker : PixelTalkingCard
    {
        protected override string OnDrawnDialogueId => "CustomStinkbugDrawn";
        protected override string OnAttackedDialogueId => "CustomStinkbugHurt";
        protected override string OnSacrificedDialogueId => "CustomStinkbugSacrificed";
        protected override string OnPlayFromHandDialogueId => "CustomStinkbugPlayed";
    }
    public abstract class PixelTalkingCard : SpecialCardBehaviour
    {
        public override bool RespondsToDrawn()
        {
            return  !Singleton<TurnManager>.Instance.TalkingCardsDrawnThisGame.Contains(base.Card.Info);
        }
        public override IEnumerator OnDrawn()
        {
            Singleton<TurnManager>.Instance.TalkingCardsDrawnThisGame.Add(base.Card.Info);
            yield return SpeakDialogueID(OnDrawnDialogueId);
            yield break;
        }
        public IEnumerator SpeakDialogueID(string eventId)
        {
            DialogueEvent dialogueEvent = DialogueDataUtil.Data.GetEvent(eventId);
            if (dialogueEvent == null)
            {
                yield break;
            }

            int repeatIndex = DialogueEventsData.GetEventRepeatCount(eventId) - 1;
            List<DialogueEvent.Line> lines = dialogueEvent.GetLines(repeatIndex);

            if (lines != null && lines.Count > 0)
            {
                foreach (DialogueEvent.Line line in lines)
                {
                    yield return Singleton<DialogueHandler>.Instance.PlayDialogueEvent(eventId, TextBox.Style.Neutral, new DialogueSpeaker()
                    {
                        characterId = DialogueSpeaker.Character.BlueWizard,
                    }, null, TextBox.ScreenPosition.ForceBottom, true);
                }
                yield return new WaitForSeconds(0.3f);
                DialogueEventsData.MarkEventPlayed(eventId);
            }
            yield break;
        }
        protected abstract string OnDrawnDialogueId { get; }
        protected abstract string OnAttackedDialogueId { get; }
        protected abstract string OnSacrificedDialogueId { get; }
        protected abstract string OnPlayFromHandDialogueId { get; }
    }
}