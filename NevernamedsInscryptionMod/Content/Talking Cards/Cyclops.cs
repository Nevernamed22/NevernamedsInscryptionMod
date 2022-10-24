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
    static class Cyclops
    {
        public static GameObject Face;
        public static void Init()
        {
            #region setupFace
            Face = Plugin.bundle.LoadAsset<GameObject>("CyclopsPortrait");

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
                    eyesClosed = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Cyclops/cyclops_eyesblink.png"), new Vector2(0.5f, 0f)),
                    eyesOpenEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Cyclops/cyclops_eyes_emission.png"), new Vector2(0.5f, 0f)),
                   // eyesClosedEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/pallasnoctua_eyesblink_emission.png"), new Vector2(0.5f, 0f)),
                    mouthOpen = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Cyclops/cyclops_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};
            face.voiceSoundId = "female1_voice"; //Others are kobold_voice , cat_voice 
            face.voiceSoundPitch = 0.2f;
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
            DialogueEventGenerator.GenerateEvent("CyclopsDrawn", new List<CustomLine>
        {
           "Aim well.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Shoot with caution."
            },
            new List<CustomLine>
            {
                "Aim me well."
            },
            new List<CustomLine>
            {
                "Aim well."
            },
            new List<CustomLine>
            {
                "Acceptable draw."
            },
            new List<CustomLine>
            {
                "Survive."
            },
            new List<CustomLine>
            {
                "I am your instrument."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);


            DialogueEventGenerator.GenerateEvent("CyclopsPlayed", new List<CustomLine>
        {
           "I will succeed.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "If you are",
                "certain."
            },
            new List<CustomLine>
            {
                "I trust",
                "The bigger",
                "picture."
            },
            new List<CustomLine>
            {
                "Over exposed."
            },
            new List<CustomLine>
            {
                "This turn?"
            },
            new List<CustomLine>
            {
                "Temporal Misplay."
            },
            new List<CustomLine>
            {
                "Remember this."
            },
            new List<CustomLine>
            {
                "I will succeed."
            },
            new List<CustomLine>
            {
                "Certainly."
            },
            new List<CustomLine>
            {
                "You have",
                "aimed... well."
            },
            new List<CustomLine>
            {
                "Within acceptable",
                "parameters."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CyclopsSacrificed",
                new List<CustomLine>
        {
           "Betrayal.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Judas."
            },
            new List<CustomLine>
            {
                "Once more?"
            },
            new List<CustomLine>
            {
                "How many times..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CyclopsSelectableGood", new List<CustomLine>
        {
           "Acceptable.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Modification."
            },
            new List<CustomLine>
            {
                "Acceptable."
            },
            new List<CustomLine>
            {
                "This is desirable."
            },
            new List<CustomLine>
            {
                "Picturesque."
            },
            new List<CustomLine>
            {
                "Regards."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CyclopsSelectableBad", new List<CustomLine>
        {
           "Undesirable.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Cease."
            },
            new List<CustomLine>
            {
                "Undesirable."
            },
            new List<CustomLine>
            {
                "This is unfriendly."
            },
            new List<CustomLine>
            {
                "Cease considerations."
            },
            new List<CustomLine>
            {
                "Halt."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CyclopsHurt", new List<CustomLine>
        {
           "I have been...",
           "...dealt a blow"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "...a blow"
            },
            new List<CustomLine>
            {
                "Suffered."
            },
            new List<CustomLine>
            {
                "Assessing damages."
            },
            new List<CustomLine>
            {
                "Cease."
            },
            new List<CustomLine>
            {
                "Dealt a blow..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CyclopsLeshy", new List<CustomLine>
        {
           "I am... This is... familiar...",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "So... familiar..."
            },
            new List<CustomLine>
            {
                "It is unfortunate",
                "that we must",
                "trade blows..."
            },
            new List<CustomLine>
            {
                "I feel... kinship."
            }            
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CyclopsGivenSigil", new List<CustomLine>
        {
           "I am improved."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Improvement"
            },
            new List<CustomLine>
            {
                "Edit in progress."
            },
            new List<CustomLine>
            {
                "A new instrument."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CyclopsTrial", new List<CustomLine>
        {
           "Under analysis"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "statistically viable"
            },
            new List<CustomLine>
            {
                "A lineup?"
            },
            new List<CustomLine>
            {
                "under analysis"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            #endregion

            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "CyclopsTalker", typeof(CyclopsTalker)).Id;


            // Add the card
            CardSetupUtility.NewCard("Nevernamed Cyclops",
                "Cyclops",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The diminutive cyclops. It's great eye holds a perfect image of the past.",
                bloodCost: 1,
                bonesCost: 0,
                onePerDeck: true,
                animatedPortrait: Face,
                abilities: new List<Ability>() { Snapshot.ability },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.AnimatedPortrait, CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability }
                );
        }
    }
    public class CyclopsTalker : PaperTalkingCard
    {
        public override string OnDrawnDialogueId => "CyclopsDrawn";
        public override string OnAttackedDialogueId => "CyclopsHurt";
        protected override string OnSacrificedDialogueId => "CyclopsSacrificed";
        public override string OnBecomeSelectableNegativeDialogueId => "CyclopsSelectableBad";
        public override string OnBecomeSelectablePositiveDialogueId => "CyclopsSelectableGood";
        public override string OnPlayFromHandDialogueId => "CyclopsPlayed";
        public override string OnDrawnFallbackDialogueId => "CyclopsPlayed";
        protected override string OnSelectedForCardRemoveDialogueId => "CyclopsSelectableBad";
        protected override string OnSelectedForCardMergeDialogueId => "CyclopsGivenSigil";
        protected override string OnSelectedForDeckTrialDialogueId => "CyclopsTrial";
        public override Dictionary<Opponent.Type, string> OnDrawnSpecialOpponentDialogueIds => new Dictionary<Opponent.Type, string>()
        {
            { Opponent.Type.LeshyBoss, "CyclopsLeshy" }
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