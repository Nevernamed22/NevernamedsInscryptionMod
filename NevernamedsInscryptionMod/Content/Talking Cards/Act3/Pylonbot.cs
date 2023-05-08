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
    static class PylonBot
    {
        public static GameObject Face;
        public static void Init()
        {
            #region setupFace
            Face = Plugin.bundle.LoadAsset<GameObject>("CustomStinkbugPortrait");

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
                    eyesClosed = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stinkbug/stinkbug_eyesblink.png"), new Vector2(0.5f, 0f)),
                    eyesOpenEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stinkbug/stinkbug_eyes_emission.png"), new Vector2(0.5f, 0f)),
                   // eyesClosedEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/pallasnoctua_eyesblink_emission.png"), new Vector2(0.5f, 0f)),
                    mouthOpen = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stinkbug/stinkbug_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};
            face.voiceSoundId = "female1_voice"; //Others are kobold_voice , cat_voice 
            face.voiceSoundPitch = 1.2f;
            face.eyes.blinkRate = 2f;

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

     /*       #region setupDialogue
            DialogueEventGenerator.GenerateEvent("CustomStinkbugDrawn", new List<CustomLine>
        {
           "Salutations.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "A lucky draw."
            },
            new List<CustomLine>
            {
                "Salutations."
            },
            new List<CustomLine>
            {
                "Great draw."
            },
            new List<CustomLine>
            {
                "Hello again dear."
            },
            new List<CustomLine>
            {
                "Regards."
            },
            new List<CustomLine>
            {
                "Greetings."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);


            DialogueEventGenerator.GenerateEvent("CustomStinkbugPlayed", new List<CustomLine>
        {
           "Back in the game.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Masterful."
            },
            new List<CustomLine>
            {
                "Back in the game."
            },
            new List<CustomLine>
            {
                "Shall we?"
            },
            new List<CustomLine>
            {
                "Cracking!"
            },
            new List<CustomLine>
            {
                "Good play."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStinkbugSacrificed",
                new List<CustomLine>
        {
           "Death again...",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Darkness take me."
            },
            new List<CustomLine>
            {
                "Death again..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStinkbugSelectableGood", new List<CustomLine>
        {
           "Marvelous.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Am I your choice?"
            },
            new List<CustomLine>
            {
                "The choice is yours."
            },
            new List<CustomLine>
            {
                "Hello."
            },
            new List<CustomLine>
            {
                "Marvelous."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStinkbugSelectableBad", new List<CustomLine>
        {
           "The choice is yours.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "The choice is yours."
            },
            new List<CustomLine>
            {
                "Do what you must."
            },
            new List<CustomLine>
            {
                "Hello."
            },
            new List<CustomLine>
            {
                "Am I your choice?"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStinkbugHurt", new List<CustomLine>
        {
           "Death take me!"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "That stings!"
            },
            new List<CustomLine>
            {
                "Death take me!"
            },
            new List<CustomLine>
            {
                "My flesh..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStinkbugAngler", new List<CustomLine>
        {
           "That old angler?",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Mind his hook."
            },
            new List<CustomLine>
            {
                "Remember your side deck!"
            },
            new List<CustomLine>
            {
                "Avoid that hook"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStinkbugRoyal", new List<CustomLine>
        {
           "Royal? Is that you?",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "My own ghoul?!"
            },
            new List<CustomLine>
            {
                "That traitor!"
            },
            new List<CustomLine>
            {
                "Royal, it's me!"
            },
            new List<CustomLine>
            {
                "Ungrateful bones."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStinkbugGivenSigil", new List<CustomLine>
        {
           "Empower me!"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Yes! More power!"
            },
            new List<CustomLine>
            {
                "Empower me!"
            },
            new List<CustomLine>
            {
                "Momento Mori"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStinkbugTrial", new List<CustomLine>
        {
           "I wish you well"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Good fortune"
            },
            new List<CustomLine>
            {
                "Did I help?"
            },
            new List<CustomLine>
            {
                "I wish you well"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);*/

           // #endregion
            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "CustomPylonBotTalker", typeof(CustomPylonBotTalker)).Id;


            // Add the card
            CardSetupUtility.NewCard("Nevernamed PylonBot",
                "Test",
                1,
                2,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "The... pungent... stinkbug?..",
                bloodCost: 0,
                bonesCost: 4,
                onePerDeck: true,
                animatedPortrait: Face,
                abilities: new List<Ability>() { Ability.DebuffEnemy },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.DynamicPortrait },
                tribes: new List<Tribe>() {  },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability }
                );
        }
    }
    public class CustomPylonBotTalker : DiskTalkingCard
    {
        public override string OnDrawnDialogueId => "CustomStinkbugDrawn";
        public override string OnAttackedDialogueId => "CustomStinkbugHurt";
        protected override string OnSacrificedDialogueId => "CustomStinkbugSacrificed";
        public override string OnBecomeSelectableNegativeDialogueId => "CustomStinkbugSelectableBad";
        public override string OnBecomeSelectablePositiveDialogueId => "CustomStinkbugSelectableGood";
        public override string OnPlayFromHandDialogueId => "CustomStinkbugPlayed";
        public override string OnDrawnFallbackDialogueId => "CustomStinkbugPlayed";
        protected override string OnSelectedForCardRemoveDialogueId => "CustomStinkbugSelectableBad";
        protected override string OnSelectedForDeckTrialDialogueId => "CustomStinkbugTrial";
        protected override string OnSelectedForCardMergeDialogueId => "CustomStinkbugGivenSigil";
        public override Dictionary<Opponent.Type, string> OnDrawnSpecialOpponentDialogueIds => new Dictionary<Opponent.Type, string>()
        {
            { Opponent.Type.AnglerBoss, "CustomStinkbugAngler" },
            { Opponent.Type.PirateSkullBoss, "CustomStinkbugRoyal" },
        };
        public override DialogueEvent.Speaker SpeakerType => DialogueEvent.Speaker.AnglerTalkingCard;

        public override IEnumerator OnShownForCardSelect(bool forPositiveEffect)
        {
            yield return new WaitForEndOfFrame();
            yield return base.OnShownForCardSelect(forPositiveEffect);
            yield break;
        }
    }
}