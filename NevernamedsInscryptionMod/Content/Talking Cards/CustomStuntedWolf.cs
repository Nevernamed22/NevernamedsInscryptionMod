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
    static class CustomStuntedWolf
    {
        public static GameObject Face;
        public static void Init()
        {
            #region setupFace
            Face = Plugin.bundle.LoadAsset<GameObject>("CustomStuntedWolfPortrait");

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
                    eyesClosed = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/StuntedWolf/stuntedwolf_eyesblink.png"), new Vector2(0.5f, 0f)),
                    eyesOpenEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/StuntedWolf/stuntedwolf_eyes_emission.png"), new Vector2(0.5f, 0f)),
                   // eyesClosedEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/pallasnoctua_eyesblink_emission.png"), new Vector2(0.5f, 0f)),
                    mouthOpen = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/StuntedWolf/stuntedwolf_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};
            face.voiceSoundId = "barkeep_voice"; //Others are kobold_voice , cat_voice 
            face.voiceSoundPitch = 1f;
            face.eyes.blinkRate = 3f;

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
            DialogueEventGenerator.GenerateEvent("CustomStuntedWolfDrawn", new List<CustomLine>
        {
           "We meet again.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Greetings."
            },
            new List<CustomLine>
            {
                "We meet again."
            },
            new List<CustomLine>
            {
                "My regards."
            },
            new List<CustomLine>
            {
                "Hello again."
            },
            new List<CustomLine>
            {
                "Best of luck"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);


            DialogueEventGenerator.GenerateEvent("CustomStuntedWolfPlayed", new List<CustomLine>
        {
           "Here we are.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Are you sure?"
            },
            new List<CustomLine>
            {
                "Here we are."
            },
            new List<CustomLine>
            {
                "Use me wisely."
            },
            new List<CustomLine>
            {
                "I must trust you."
            },
            new List<CustomLine>
            {
                "Unwise"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStuntedWolfSacrificed",
                new List<CustomLine>
        {
           "Betrayal.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Farewell."
            },
            new List<CustomLine>
            {
                "Betrayal."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStuntedWolfSelectableGood", new List<CustomLine>
        {
           "Ahem.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Ahem."
            },
            new List<CustomLine>
            {
                "I am at your service."
            },
            new List<CustomLine>
            {
                "I am yours."
            },
            new List<CustomLine>
            {
                "..."
            },
            new List<CustomLine>
            {
                "Select wisely."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStuntedWolfSelectableBad", new List<CustomLine>
        {
           "Ahem.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Ahem."
            },
            new List<CustomLine>
            {
                "Regrettable."
            },
            new List<CustomLine>
            {
                "Unwise."
            },
            new List<CustomLine>
            {
                "If you must."
            },
            new List<CustomLine>
            {
                "It is your choice."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStuntedWolfHurt", new List<CustomLine>
        {
           "Careful now."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "oof"
            },
            new List<CustomLine>
            {
                "Careful now."
            },
            new List<CustomLine>
            {
                "Good lord!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStuntedWolfGivenSigil", new List<CustomLine>
        {
           "Very well."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "A taste of my",
                "former glory"
            },
            new List<CustomLine>
            {
                "Very well"
            },
            new List<CustomLine>
            {
                "Marvellous"
            },
            new List<CustomLine>
            {
                "Enchanting"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStuntedWolfTrial", new List<CustomLine>
        {
           "I wish you luck"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Good fortune"
            },
            new List<CustomLine>
            {
                "I wish you luck"
            },
            new List<CustomLine>
            {
                "Hope for victory"
            },
            new List<CustomLine>
            {
                "Am I of",
                "assistance?"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            #endregion
            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "CustomStuntedWolfTalker", typeof(CustomStuntedWolfTalker)).Id;


            // Add the card
            CardSetupUtility.NewCard("Nevernamed CustomStuntedWolf",
                "Stunted Wolf",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The Stunted... Wolf... I thought I threw him- ...I mean, this, away...",
                bloodCost: 1,
                bonesCost: 0,
                onePerDeck: true,
                animatedPortrait: Face,
                abilities: new List<Ability>() { },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, CardAppearanceBehaviour.Appearance.AnimatedPortrait },
                tribes: new List<Tribe>() { Tribe.Canine },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                specialAbilities:  new List<SpecialTriggeredAbility>() { ability }
                );
        }
    }
    public class CustomStuntedWolfTalker : PaperTalkingCard
    {
        public override string OnDrawnDialogueId => "CustomStuntedWolfDrawn";
        public override string OnAttackedDialogueId => "CustomStuntedWolfHurt";
        protected override string OnSacrificedDialogueId => "CustomStuntedWolfSacrificed";
        public override string OnBecomeSelectableNegativeDialogueId => "CustomStuntedWolfSelectableBad";
        public override string OnBecomeSelectablePositiveDialogueId => "CustomStuntedWolfSelectableGood";
        public override string OnPlayFromHandDialogueId => "CustomStuntedWolfPlayed";
        public override string OnDrawnFallbackDialogueId => "CustomStuntedWolfPlayed";
        protected override string OnSelectedForCardRemoveDialogueId => "CustomStuntedWolfSelectableBad";
        protected override string OnSelectedForDeckTrialDialogueId => "CustomStuntedWolfTrial";
        protected override string OnSelectedForCardMergeDialogueId => "CustomStuntedWolfGivenSigil";
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