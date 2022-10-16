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
    static class BrazenBull
    {
        public static GameObject Face;
        public static void Init()
        {
            #region setupFace
            Face = Plugin.bundle.LoadAsset<GameObject>("BrazenBullPortrait");

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
                    eyesClosed = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/BrazenBull/brazenbull_eyesblink.png"), new Vector2(0.5f, 0f)),
                    eyesOpenEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/BrazenBull/brazenbull_eyes_emission.png"), new Vector2(0.5f, 0f)),
                   // eyesClosedEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/pallasnoctua_eyesblink_emission.png"), new Vector2(0.5f, 0f)),
                    mouthOpen = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/BrazenBull/brazenbull_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};
            face.voiceSoundId = "female1_voice"; //Others are kobold_voice , cat_voice 
            face.voiceSoundPitch = 0.1f;
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
            DialogueEventGenerator.GenerateEvent("BrazenBullDrawn", new List<CustomLine>
        {
           "Proceed",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Let's go!"
            },
            new List<CustomLine>
            {
                "Proceed"
            },
            new List<CustomLine>
            {
                "Play me properly"
            },
            new List<CustomLine>
            {
                "HAHAHAHAHAAH, YES!"
            },
            new List<CustomLine>
            {
                "YES, YES!"
            },
            new List<CustomLine>
            {
                "LET'S MAKE A RING",
                "OF FIRE"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);


            DialogueEventGenerator.GenerateEvent("BrazenBullPlayed", new List<CustomLine>
        {
           "HAHAHAHAHAH",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "BURN"
            },
            new List<CustomLine>
            {
                "I want to",
                "see the fire"
            },
            new List<CustomLine>
            {
                "for glory!"
            },
            new List<CustomLine>
            {
                "Yes, very well"
            },
            new List<CustomLine>
            {
                "Let's get to work"
            },
            new List<CustomLine>
            {
                "Let's go!"
            },
            new List<CustomLine>
            {
                "HAHAHAHAHA"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("BrazenBullSacrificed",
                new List<CustomLine>
        {
           "HAHAHAHAHAHAHAH",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "TO GLORY"
            },
            new List<CustomLine>
            {
                "HAHAHAHAHAHAH"
            },
            new List<CustomLine>
            {
                "TOO BAD"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("BrazenBullSelectableGood", new List<CustomLine>
        {
           "Yes, Yes!",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "HAHAHAH, YES!"
            },
            new List<CustomLine>
            {
                "IMPROVE ME"
            },
            new List<CustomLine>
            {
                "I can be",
                "So much more!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("BrazenBullSelectableBad", new List<CustomLine>
        {
           "If you want.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "YES"
            },
            new List<CustomLine>
            {
                "SACRIFICE ME!"
            },
            new List<CustomLine>
            {
                "I WILL DIE",
                "FOR YOU"
            },
            new List<CustomLine>
            {
                "It's up to you"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("BrazenBullHurt", new List<CustomLine>
        {
           "Excellent!"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Harder!"
            },
            new List<CustomLine>
            {
                "Excellent!"
            },
            new List<CustomLine>
            {
                "YES"
            },
            new List<CustomLine>
            {
                "DO IT!"
            },
            new List<CustomLine>
            {
                "HAHAHAHAHAHA!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            

            DialogueEventGenerator.GenerateEvent("BrazenBullGivenSigil", new List<CustomLine>
        {
           "YES! MORE!"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Very good."
            },
            new List<CustomLine>
            {
                "YES! MORE!"
            },
            new List<CustomLine>
            {
                "HAHAHAHAHAHAH"
            },
            new List<CustomLine>
            {
                "THANK YOU, THANK YOU!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("BrazenBullTrial", new List<CustomLine>
        {
           "VICTORY?"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "VICTORY?"
            },
            new List<CustomLine>
            {
                "TO GLORY!"
            },
            new List<CustomLine>
            {
                "YES, YES"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            #endregion

            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "BrazenBullTalker", typeof(BrazenBullTalker)).Id;


            // Add the card
            CardSetupUtility.NewCard("Nevernamed BrazenBull",
                "Brazen Bull",
                4,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The horrific brazen bull. A true metric of human depravity.",
                bloodCost: 3,
                bonesCost: 0,
                onePerDeck: true,
                animatedPortrait: Face,
                abilities: new List<Ability>() { Ability.StrafeSwap, Ignition.ability, Ability.MadeOfStone },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.AnimatedPortrait, CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { Tribe.Hooved },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability, CreateCharredLump.ability }
                );
        }
    }
    public class BrazenBullTalker : PaperTalkingCard
    {
        public override string OnDrawnDialogueId => "BrazenBullDrawn";
        public override string OnAttackedDialogueId => "BrazenBullHurt";
        protected override string OnSacrificedDialogueId => "BrazenBullSacrificed";
        public override string OnBecomeSelectableNegativeDialogueId => "BrazenBullSelectableBad";
        public override string OnBecomeSelectablePositiveDialogueId => "BrazenBullSelectableGood";
        public override string OnPlayFromHandDialogueId => "BrazenBullPlayed";
        public override string OnDrawnFallbackDialogueId => "BrazenBullPlayed";
        protected override string OnSelectedForCardRemoveDialogueId => "BrazenBullSelectableBad";
        protected override string OnSelectedForCardMergeDialogueId => "BrazenBullGivenSigil";
        protected override string OnSelectedForDeckTrialDialogueId => "BrazenBullTrial";
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