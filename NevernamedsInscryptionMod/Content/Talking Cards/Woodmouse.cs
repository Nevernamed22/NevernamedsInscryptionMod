using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using System.Collections;
using InscryptionAPI.Card;
using TalkingCardUtility;

namespace NevernamedsInscryptionMod
{
    static class Woodmouse
    {
        public static GameObject Face;
        public static void Init()
        {
            #region setupFace
            Face = Plugin.bundle.LoadAsset<GameObject>("WoodmousePortrait");

            CharacterFace face = Face.AddComponent<CharacterFace>();
            face.anim = Face.transform.Find("Anim").GetComponent<Animator>();
            face.eyes = Face.transform.Find("Anim").Find("Body").Find("eyes").gameObject.AddComponent<CharacterEyes>();
            face.mouth = Face.transform.Find("Anim").Find("Body").Find("mouth").gameObject.AddComponent<CharacterMouth>();
            face.face = Face.transform.Find("Anim").Find("Body").GetComponent<SpriteRenderer>();
            face.emotionSprites = new List<CharacterFace.EmotionSprites>
             {
                new CharacterFace.EmotionSprites
                {
                    emotion = Emotion.Neutral,
                    face = face.face.sprite,
                    eyesOpen = face.eyes.GetComponent<SpriteRenderer>().sprite,
                    mouthClosed = face.mouth.GetComponent<SpriteRenderer>().sprite,
                    eyesClosed = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Woodmouse/woodmouse_eyesblink.png"), new Vector2(0.5f, 0f)),
                    eyesOpenEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Woodmouse/woodmouse_eyes_emission.png"), new Vector2(0.5f, 0f)),
                    eyesClosedEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Woodmouse/woodmouse_eyes_emission.png"), new Vector2(0.5f, 0f)),
                    mouthOpen = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Woodmouse/woodmouse_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};
            face.voiceSoundId = "female1_voice"; //Others are kobold_voice , cat_voice 
            face.voiceSoundPitch = 0.1f;
            face.eyes.blinkRate = 5f;

            int offscreen = LayerMask.NameToLayer("CardOffscreen");
            foreach (Transform t in Face.GetComponentsInChildren<Transform>())
            {
                t.gameObject.layer = offscreen;
            }
            Face.layer = offscreen;
            face.eyes.emissionRenderer = face.eyes.transform.Find("emission")?.GetComponent<SpriteRenderer>();
            if (face.eyes.emissionRenderer != null)
            {
                face.eyes.emissionRenderer.gameObject.layer = LayerMask.NameToLayer("CardOffscreenEmission");
            }
            #endregion

            #region setupDialogue
            DialogueEventGenerator.GenerateEvent("WoodmouseDotDotDot", new List<CustomLine>
        {
           "...",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "..."
            },
            new List<CustomLine>
            {
                "...."
            },
            new List<CustomLine>
            {
                "....."
            },
            new List<CustomLine>
            {
                "......"
            }         
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);        

            #endregion

            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "WoodmouseTalker", typeof(WoodmouseTalker)).Id;


            // Add the card
            CardSetupUtility.NewCard("Nevernamed Woodmouse",
                "Woodmouse",
                0,
                4,
                new List<CardMetaCategory> { CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode },
                CardTemple.Nature,
                description: "The silent woodmouse. It seems to have undergone... a lot of training.",
                bloodCost: 1,
                bonesCost: 0,
                onePerDeck: true,
                animatedPortrait: Face,
                abilities: new List<Ability>() { TemptingTarget.ability },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.AnimatedPortrait },
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability }
                );
        }
    }
    public class WoodmouseTalker : PaperTalkingCard
    {
        public override string OnDrawnDialogueId => "WoodmouseDotDotDot";
        public override string OnAttackedDialogueId => "WoodmouseDotDotDot";
        protected override string OnSacrificedDialogueId => "WoodmouseDotDotDot";
        public override string OnBecomeSelectableNegativeDialogueId => "WoodmouseDotDotDot";
        public override string OnBecomeSelectablePositiveDialogueId => "WoodmouseDotDotDot";
        public override string OnPlayFromHandDialogueId => "WoodmouseDotDotDot";
        public override string OnDrawnFallbackDialogueId => "WoodmouseDotDotDot";
        protected override string OnSelectedForCardRemoveDialogueId => "WoodmouseDotDotDot";
        protected override string OnSelectedForCardMergeDialogueId => "WoodmouseDotDotDot";
        protected override string OnSelectedForDeckTrialDialogueId => "WoodmouseDotDotDot";
        public override Dictionary<Opponent.Type, string> OnDrawnSpecialOpponentDialogueIds => new Dictionary<Opponent.Type, string>()
        {
        };
        public override DialogueEvent.Speaker SpeakerType => DialogueEvent.Speaker.Stoat;

        public override IEnumerator OnShownForCardSelect(bool forPositiveEffect)
        {
            yield return new WaitForEndOfFrame();
            yield return base.OnShownForCardSelect(forPositiveEffect);
            yield break;
        }
    }
}