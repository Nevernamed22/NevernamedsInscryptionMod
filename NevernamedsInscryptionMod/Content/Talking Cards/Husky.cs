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
    static class Husky
    {
        public static GameObject Face;
        public static void Init()
        {
            #region setupFace
            Face = Plugin.bundle.LoadAsset<GameObject>("HuskyPortrait");

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
                    eyesClosed = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Husky/husky_eyesblink.png"), new Vector2(0.5f, 0f)),
                    eyesOpenEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Husky/husky_eyes_emission.png"), new Vector2(0.5f, 0f)),
                   // eyesClosedEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/pallasnoctua_eyesblink_emission.png"), new Vector2(0.5f, 0f)),
                    mouthOpen = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Husky/husky_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};
            face.voiceSoundId = "female1_voice"; //Others are kobold_voice , cat_voice 
            face.voiceSoundPitch = 1.1f;
            face.eyes.blinkRate = 1f;

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
            DialogueEventGenerator.GenerateEvent("HuskyDrawn", new List<CustomLine>
        {
           "Be quick!",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Please let this",
                "be over quickly..."
            },
            new List<CustomLine>
            {
                "Is it almost",
                "over?..."
            },
            new List<CustomLine>
            {
                "Oh no, oh no"
            },
            new List<CustomLine>
            {
                "I can't",
                "handle this!"
            },
            new List<CustomLine>
            {
                "Finish this",
                "quickly, I",
                "beg of you."
            },
            new List<CustomLine>
            {
                "Snarling, sniffing..."
            },
            new List<CustomLine>
            {
                "S-Surely I am",
                "of no use on",
                "the board..."
            },
            new List<CustomLine>
            {
                "P-Please, do not",
                "play me"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);


            DialogueEventGenerator.GenerateEvent("HuskyPlayed", new List<CustomLine>
        {
           "R-Really? Here?",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "...I'm doomed"
            },
            new List<CustomLine>
            {
                "R-Really? Here?"
            },
            new List<CustomLine>
            {
                "Oh no, oh no",
                "Oh no, oh no",
                "Oh no, oh no",
                "Oh no, oh no"
            },
            new List<CustomLine>
            {
                "I-I can",
                "hear them..."
            },
            new List<CustomLine>
            {
                "Barking, biting..."
            },
            new List<CustomLine>
            {
                "Anything but",
                "this... please"
            },
            new List<CustomLine>
            {
                "Agony!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HuskySacrificed",
                new List<CustomLine>
        {
           "What did I do?",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "HELP!"
            },
            new List<CustomLine>
            {
                "No, No, No"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HuskySelectableGood", new List<CustomLine>
        {
           "W-What is this?",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Do not look",
                "upon me..."
            },
            new List<CustomLine>
            {
                "W-What is this?"
            },
            new List<CustomLine>
            {
                "P-Please"
            },
            new List<CustomLine>
            {
                "What are you doing?"
            },
            new List<CustomLine>
            {
                "Do not drool",
                "like that..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HuskySelectableBad", new List<CustomLine>
        {
           "No No no no no",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Do not do this."
            },
            new List<CustomLine>
            {
                "No No no no no."
            },
            new List<CustomLine>
            {
                "I beg of you,",
                "anything but this"
            },
            new List<CustomLine>
            {
                "P-Please, stop"
            },
            new List<CustomLine>
            {
                "What did I do",
                "to deserve this?"
            },
            new List<CustomLine>
            {
                "Agony, Agony!"
            },
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HuskyHurt", new List<CustomLine>
        {
           "Agony!"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Avert your eyes!"
            },
            new List<CustomLine>
            {
                "Agony!"
            },
            new List<CustomLine>
            {
                "No, not",
                "again!"
            },
            new List<CustomLine>
            {
                "I'm being",
                "chewed out!"
            },
            new List<CustomLine>
            {
                "Just... get",
                "this over with"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HuskyRoyal", new List<CustomLine>
        {
           "Royal...",
           "That old sea dog",
           "It hurts...",
           "I considered him",
           "a friend."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Royal again, huh?"
            },
            new List<CustomLine>
            {
                "Scurvy dog..."
            },
            new List<CustomLine>
            {
                "Yellow bellied."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HuskyGivenSigil", new List<CustomLine>
        {
           "Avert your eyes..."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Oh dear..."
            },
            new List<CustomLine>
            {
                "Please, don't",
                "play me"
            },
            new List<CustomLine>
            {
                "So graphic.."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HuskyTrial", new List<CustomLine>
        {
           "d-Did I help?"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Oh no, I've",
                "doomed it,",
                "haven't I?"
            },
            new List<CustomLine>
            {
                "This makes me",
                "anxious..."
            },
            new List<CustomLine>
            {
                "Close your eyes!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            #endregion

            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "HuskyTalker", typeof(HuskyTalker)).Id;


            // Add the card
            CardSetupUtility.NewCard("Nevernamed Husky",
                "Husky",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The widely beloved husky. It is a master of bringing back bones...",
                bloodCost: 2,
                bonesCost: 0,
                onePerDeck: true,
                animatedPortrait: Face,
                abilities: new List<Ability>() { Bonelust.ability },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.AnimatedPortrait },
                tribes: new List<Tribe>() { Tribe.Canine },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability }
                );
        }
    }
    public class HuskyTalker : PaperTalkingCard
    {
        public override string OnDrawnDialogueId => "HuskyDrawn";
        public override string OnAttackedDialogueId => "HuskyHurt";
        protected override string OnSacrificedDialogueId => "HuskySacrificed";
        public override string OnBecomeSelectableNegativeDialogueId => "HuskySelectableBad";
        public override string OnBecomeSelectablePositiveDialogueId => "HuskySelectableGood";
        public override string OnPlayFromHandDialogueId => "HuskyPlayed";
        public override string OnDrawnFallbackDialogueId => "HuskyPlayed";
        protected override string OnSelectedForCardRemoveDialogueId => "HuskySelectableBad";
        protected override string OnSelectedForCardMergeDialogueId => "HuskyGivenSigil";
        protected override string OnSelectedForDeckTrialDialogueId => "HuskyTrial";
        public override Dictionary<Opponent.Type, string> OnDrawnSpecialOpponentDialogueIds => new Dictionary<Opponent.Type, string>()
        {
            { Opponent.Type.PirateSkullBoss, "HuskyRoyal" }
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