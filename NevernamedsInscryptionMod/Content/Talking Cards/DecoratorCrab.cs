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
    static class DecoratorCrab
    {
        public static GameObject Face;
        public static void Init()
        {
            #region setupFace
            Face = Plugin.bundle.LoadAsset<GameObject>("DecoratorCrabPortrait");

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
                    eyesClosed = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/DecoratorCrab/decoratorcrab_eyesblink.png"), new Vector2(0.5f, 0f)),
                    eyesOpenEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/DecoratorCrab/decoratorcrab_eyes_emission.png"), new Vector2(0.5f, 0f)),
                    //eyesClosedEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/DecoratorCrab/pallasnoctua_eyesblink_emission.png"), new Vector2(0.5f, 0f)),
                    mouthOpen = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/DecoratorCrab/decoratorcrab_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};
            face.voiceSoundId = "female1_voice"; //Others are kobold_voice , cat_voice 
            face.voiceSoundPitch = 0.5f;
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
            DialogueEventGenerator.GenerateEvent("DecoratorCrabDrawn", new List<CustomLine>
        {
           "Well, looks",
           "Like I ain't",
           "Be sleepin on",
           "the job..."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Anuvva one?"
            },
            new List<CustomLine>
            {
                "Show em what-for."
            },
            new List<CustomLine>
            {
                "Time to dive",
                "on in"
            },
            new List<CustomLine>
            {
                "Oh bloody hell..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("DecoratorCrabUseSigil", new List<CustomLine>
        {
           "Let's see..."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Lets get in there"
            },
            new List<CustomLine>
            {
                "Takin a dive"
            },
            new List<CustomLine>
            {
                "Take yer pick mate"
            },
            new List<CustomLine>
            {
                "Orright boss"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("DecoratorCrabUseSigilFail", new List<CustomLine>
        {
           "There's nuffin in",
           "Your deck boss."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Nuffin? No refunds"
            },
            new List<CustomLine>
            {
                "Sorry boss, hit",
                "The bottom"
            },
            new List<CustomLine>
            {
                "Nuffin left"
            },
            new List<CustomLine>
            {
                "Deck empty...  bugger"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("DecoratorCrabAngler", new List<CustomLine>
        {
           "This bugger eh?",
           "looks like nuffin's",
           "changed.",
           "he still reeks o'",
           "cod and sweat."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "This bastard again?"
            },
            new List<CustomLine>
            {
                "bloody hell..."
            },
            new List<CustomLine>
            {
                "Some things",
                "don't change.",
                "...",
                "like the smell"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);


            DialogueEventGenerator.GenerateEvent("DecoratorCrabPlayed", new List<CustomLine>
        {
           "Orright.",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Orright."
            },
            new List<CustomLine>
            {
                "You sure, mate?"
            },
            new List<CustomLine>
            {
                "Eyes on the prize."
            },
            new List<CustomLine>
            {
                "Come at me ya",
                "bloody whelklickers!"
            },
            new List<CustomLine>
            {
                "Time to take",
                "a dive"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("DecoratorCrabSacrificed",
                new List<CustomLine>
        {
           "Oy!",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "What the hell?"
            },
            new List<CustomLine>
            {
                "Bastard."
            },
            new List<CustomLine>
            {
                "Bloody hell."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("DecoratorCrabSelectableGood", new List<CustomLine>
        {
           "Looks awful fine"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Luvly"
            },
            new List<CustomLine>
            {
                "Spare an upgrade",
                "for an old mate?"
            },
            new List<CustomLine>
            {
                "Oy, mate,",
                "pick me, eh?"
            },
            new List<CustomLine>
            {
                "Time ta treat",
                "myself"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("DecoratorSelectableBad", new List<CustomLine>
        {
           "Don't you even",
           "bloody think",
           "about it."
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Oh christ alive..."
            },
            new List<CustomLine>
            {
                "I ain't takin",
                "this dive"
            },
            new List<CustomLine>
            {
                "geroff"
            },
            new List<CustomLine>
            {
                "bugger off"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("DecoratorCrabHurt", new List<CustomLine>
        {
           "Geroff"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Bloody hell"
            },
            new List<CustomLine>
            {
                "Geroff"
            },
            new List<CustomLine>
            {
                "bugger"
            },
            new List<CustomLine>
            {
                "wanker"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("DecoratorCrabGivenSigil", new List<CustomLine>
        {
           "Luvverly"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Sac that bugger"
            },
            new List<CustomLine>
            {
                "Luvverly"
            },
            new List<CustomLine>
            {
                "Sumfin marvelous"
            },
            new List<CustomLine>
            {
                "Marv'lous"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("DecoratorCrabTrial", new List<CustomLine>
        {
           "Oh bloody 'ell"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Good look lad"
            },
            new List<CustomLine>
            {
                "Blow them away"
            },
            new List<CustomLine>
            {
                "Oh bloody 'ell"
            },
            new List<CustomLine>
            {
                "Did I 'elp?"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            #endregion
            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "DecoratorCrabTalker", typeof(DecoratorCrabTalker)).Id;


            // Add the card
            CardSetupUtility.NewCard("Nevernamed DecoratorCrab",
                "Decorator Crab",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode },
                CardTemple.Nature,
                description: "The lowly decorator crab. It scrounges the bottom of the ocean for detritus to stick to it's body.",
                bloodCost: 0,
                bonesCost: 5,
                onePerDeck: true,
                animatedPortrait: Face,
                abilities: new List<Ability>() { Diver.ability, Dredge.ability },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.AnimatedPortrait },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability }
                );
        }
    }
    public class DecoratorCrabTalker : PaperTalkingCard
    {
        public override string OnDrawnDialogueId => "DecoratorCrabDrawn";
        public override string OnAttackedDialogueId => "DecoratorCrabHurt";
        protected override string OnSacrificedDialogueId => "DecoratorCrabSacrificed";
        public override string OnBecomeSelectableNegativeDialogueId => "DecoratorCrabSelectableBad";
        public override string OnBecomeSelectablePositiveDialogueId => "DecoratorCrabSelectableGood";
        public override string OnPlayFromHandDialogueId => "DecoratorCrabPlayed";
        public override string OnDrawnFallbackDialogueId => "DecoratorCrabPlayed";
        protected override string OnSelectedForCardRemoveDialogueId => "DecoratorCrabSelectableBad";
        protected override string OnSelectedForCardMergeDialogueId => "DecoratorCrabGivenSigil";
        protected override string OnSelectedForDeckTrialDialogueId => "DecoratorCrabTrial";
        public override Dictionary<Opponent.Type, string> OnDrawnSpecialOpponentDialogueIds => new Dictionary<Opponent.Type, string>()
        {
            {Opponent.Type.AnglerBoss, "DecoratorCrabAngler" }
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