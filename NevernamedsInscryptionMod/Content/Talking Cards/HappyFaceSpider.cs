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
    static class HappyFaceSpider
    {
        public static GameObject Face;
        public static void Init()
        {
            #region setupFace
            Face = Plugin.arachnophobiaMode.Value ? Plugin.bundle.LoadAsset<GameObject>("HappyFaceSpiderPortraitPhobiaFriendly") : Plugin.bundle.LoadAsset<GameObject>("HappyFaceSpiderPortrait");

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
                    eyesClosed = Tools.ConvertTexToSprite(Tools.LoadTex($"NevernamedsInscryptionMod/Resources/TalkingCards/Act1/HappyFaceSpider/{(Plugin.arachnophobiaMode.Value ? "happyfacespiderphobia" : "happyfacespider")}_eyesblink.png"), new Vector2(0.5f, 0f)),
                    eyesOpenEmission = Tools.ConvertTexToSprite(Tools.LoadTex($"NevernamedsInscryptionMod/Resources/TalkingCards/Act1/HappyFaceSpider/{(Plugin.arachnophobiaMode.Value ? "happyfacespiderphobia" : "happyfacespider")}_eyes_emission.png"), new Vector2(0.5f, 0f)),
                   // eyesClosedEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/pallasnoctua_eyesblink_emission.png"), new Vector2(0.5f, 0f)),
                    mouthOpen = Tools.ConvertTexToSprite(Tools.LoadTex($"NevernamedsInscryptionMod/Resources/TalkingCards/Act1/HappyFaceSpider/{(Plugin.arachnophobiaMode.Value ? "happyfacespiderphobia" : "happyfacespider")}_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};
            face.voiceSoundId = "female1_voice"; //Others are kobold_voice , cat_voice 
            face.voiceSoundPitch = 1.2f;
            face.eyes.blinkRate = 1.5f;

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
            DialogueEventGenerator.GenerateEvent("HappyFaceSpiderDrawn", new List<CustomLine>
        {
           "Golly!",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Is this a fight?"
            },
            new List<CustomLine>
            {
                "Are we fighting?"
            },
            new List<CustomLine>
            {
                "Wowie!"
            },
            new List<CustomLine>
            {
                "Golly!"
            },
            new List<CustomLine>
            {
                "H-Here we go..."
            },
            new List<CustomLine>
            {
                "I hope I can",
                "get a good",
                "connection"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);


            DialogueEventGenerator.GenerateEvent("HappyFaceSpiderPlayed", new List<CustomLine>
        {
           "H-Here goes nothing!",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "So that's what",
                "They look like..."
            },
            new List<CustomLine>
            {
                "W-What are these?"
            },
            new List<CustomLine>
            {
                "Are these...",
                "your friends?"
            },
            new List<CustomLine>
            {
                "H-Here goes nothing!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HappyFaceSpiderSacrificed",
                new List<CustomLine>
        {
           "W-What?",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "W-Why?"
            },
            new List<CustomLine>
            {
                "W-What?"
            },
            new List<CustomLine>
            {
                "No, please!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HappyFaceSpiderSelectableGood", new List<CustomLine>
        {
           "Oooh, what is this?",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "This looks fun!"
            },
            new List<CustomLine>
            {
                "Oooh, what is this?"
            },
            new List<CustomLine>
            {
                "Whoa!",
                "A new signal!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HappyFaceSpiderSelectableBad", new List<CustomLine>
        {
           "uhhh...",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "This looks iffy..."
            },
            new List<CustomLine>
            {
                "uhhh..."
            },
            new List<CustomLine>
            {
                "What's this for?"
            },
            new List<CustomLine>
            {
                "Is this a virus?"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HappyFaceSpiderHurt", new List<CustomLine>
        {
           "Owie!"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "That's mean!"
            },
            new List<CustomLine>
            {
                "Owie!"
            },
            new List<CustomLine>
            {
                "Please stop"
            },
            new List<CustomLine>
            {
                "please"
            },
            new List<CustomLine>
            {
                "This makes me sad"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);



            DialogueEventGenerator.GenerateEvent("HappyFaceSpiderGivenSigil", new List<CustomLine>
        {
           "Nifty!"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Wowie!"
            },
            new List<CustomLine>
            {
                "Nifty!"
            },
            new List<CustomLine>
            {
                "I feel... connected"
            },
            new List<CustomLine>
            {
                "What does this do?"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("HappyFaceSpiderTrial", new List<CustomLine>
        {
           "Did we win?"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Wowie!"
            },
            new List<CustomLine>
            {
                "Did we win?"
            },
            new List<CustomLine>
            {
                "This is fun!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            #endregion

            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "HappyFaceSpiderTalker", typeof(HappyFaceSpiderTalker)).Id;


            // Add the card
            CardSetupUtility.NewCard("Nevernamed HappyFaceSpider",
                "Happy Face Spider",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The happy face spider- perpetually amazed by it's own... web",
                bloodCost: 2,
                bonesCost: 0,
                onePerDeck: true,
                animatedPortrait: Face,
                abilities: new List<Ability>() { FriendFinder.ability },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.AnimatedPortrait, CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability }
                );
        }
    }
    public class HappyFaceSpiderTalker : PaperTalkingCard
    {
        public override string OnDrawnDialogueId => "HappyFaceSpiderDrawn";
        public override string OnAttackedDialogueId => "HappyFaceSpiderHurt";
        protected override string OnSacrificedDialogueId => "HappyFaceSpiderSacrificed";
        public override string OnBecomeSelectableNegativeDialogueId => "HappyFaceSpiderSelectableBad";
        public override string OnBecomeSelectablePositiveDialogueId => "HappyFaceSpiderSelectableGood";
        public override string OnPlayFromHandDialogueId => "HappyFaceSpiderPlayed";
        public override string OnDrawnFallbackDialogueId => "HappyFaceSpiderPlayed";
        protected override string OnSelectedForCardRemoveDialogueId => "HappyFaceSpiderSelectableBad";
        protected override string OnSelectedForCardMergeDialogueId => "HappyFaceSpiderGivenSigil";
        protected override string OnSelectedForDeckTrialDialogueId => "HappyFaceSpiderTrial";
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