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
    static class PallasNoctua
    {
        public static GameObject Face;
        public static void Init()
        {
            #region setupFace
            Face = Plugin.bundle.LoadAsset<GameObject>("PallasNoctuaPortrait");

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
                    eyesClosed = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/PallasNoctua/pallasnoctua_eyesblink.png"), new Vector2(0.5f, 0f)),
                    eyesOpenEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/PallasNoctua/pallasnoctua_eyes_emission.png"), new Vector2(0.5f, 0f)),
                    eyesClosedEmission = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/PallasNoctua/pallasnoctua_eyesblink_emission.png"), new Vector2(0.5f, 0f)),
                    mouthOpen = Tools.ConvertTexToSprite(Tools.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/PallasNoctua/pallasnoctua_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};
            face.voiceSoundId = "female1_voice"; //Others are kobold_voice , cat_voice 
            face.voiceSoundPitch = 1;
            face.eyes.blinkRate = 0.5f;
            
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
            DialogueEventGenerator.GenerateEvent("PallasNoctuaDrawn", new List<CustomLine>
        {
           "Oh no.",
           "A fight???",
           "I wasnt made for this...",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Well here we are again."
            },
            new List<CustomLine>
            {
                "It's always such a pleasure..."
            },
            new List<CustomLine>
            {
                "I would appreciate survival this time."
            },
            new List<CustomLine>
            {
                "Oh dear."
            },
            new List<CustomLine>
            {
                "I'm... not optimistic..."
            },
            new List<CustomLine>
            {
                "I will inspect your deck"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);


            DialogueEventGenerator.GenerateEvent("PallasNoctuaPlayed", new List<CustomLine>
        {
           "Operations online...",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Statistically terrible."
            },
            new List<CustomLine>
            {
                "Total lack of synergy..."
            },
            new List<CustomLine>
            {
                "Let's look at that deck."
            },
            new List<CustomLine>
            {
                "Hmmmmm..."
            },
            new List<CustomLine>
            {
                "Let's see what we have here..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("PallasNoctuaSacrificed",
                new List<CustomLine>
        {
           "Goodbye then...",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Well met..."
            },
            new List<CustomLine>
            {
                "I'll be back."
            },
            new List<CustomLine>
            {
                "I am proud."
            },
            new List<CustomLine>
            {
                "Oh dear."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("PallasNoctuaSelectableGood", new List<CustomLine>
        {
           "I would be proud",
           "to recieve this upgrade",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Upgrades!"
            },
            new List<CustomLine>
            {
                "Upgrades, people, upgrades!"
            },
            new List<CustomLine>
            {
                "I would be proud."
            },
            new List<CustomLine>
            {
                "I've calculated it..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("PallasNoctuaSelectableBad", new List<CustomLine>
        {
           "I suspect this",
           "is not ideal...",
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "This is not an upgrade..."
            },
            new List<CustomLine>
            {
                "pick someone else."
            },
            new List<CustomLine>
            {
                "High chance of decomission..."
            },
            new List<CustomLine>
            {
                "Dubious..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("PallasNoctuaHurt", new List<CustomLine>
        {
           "Wait, no!"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "Dissassemble!"
            },
            new List<CustomLine>
            {
                "Dissassemble, dead!"
            },
            new List<CustomLine>
            {
                "I may need repairs..."
            },
            new List<CustomLine>
            {
                "I am... struggling."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("PallasNoctuaGivenSigil", new List<CustomLine>
        {
           "Upgrade me!"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "v1.3 inbound!"
            },
            new List<CustomLine>
            {
                "Yes! Yes!"
            },
            new List<CustomLine>
            {
                "Thank you!"
            },
            new List<CustomLine>
            {
                "Incredible!"
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("PallasNoctuaTrial", new List<CustomLine>
        {
           "An analysis?"
        }, new List<List<CustomLine>>
        {
            new List<CustomLine>
            {
                "The inspector",
                "becomes",
                "the inspected..."
            },
            new List<CustomLine>
            {
                "Study me."
            },
            new List<CustomLine>
            {
                "High chance",
                "of success"
            },
            new List<CustomLine>
            {
                "high chance",
                "of failure..."
            }
        }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            #endregion

            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add("nevernamedscustominscryptioncards", "PallasNoctuaTalker", typeof(PallasNoctuaTalker)).Id;         

            // Add the card
            CardSetupUtility.NewCard("Nevernamed PallasNoctua",
                "Pallas Noctua",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The holy owl. It may use it's all seeing eyes to copy your deck.",
                bloodCost: 2,
                bonesCost: 0,
                onePerDeck: true,
                animatedPortrait: Face,
                abilities: new List<Ability>() { Dupeglitch.ability },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, CardAppearanceBehaviour.Appearance.AnimatedPortrait },
                tribes: new List<Tribe>() { Tribe.Bird },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability }
                );
        }
    }
    public class PallasNoctuaTalker : PaperTalkingCard
    {
        public override string OnDrawnDialogueId => "PallasNoctuaDrawn";
        public override string OnAttackedDialogueId => "PallasNoctuaHurt";
        protected override string OnSacrificedDialogueId => "PallasNoctuaSacrificed";
        public override string OnBecomeSelectableNegativeDialogueId => "PallasNoctuaSelectableBad";
        public override string OnBecomeSelectablePositiveDialogueId => "PallasNoctuaSelectableGood";
        public override string OnPlayFromHandDialogueId => "PallasNoctuaPlayed";
        protected override string OnSelectedForCardRemoveDialogueId => "PallasNoctuaSelectableBad";
        public override string OnDrawnFallbackDialogueId => "PallasNoctuaPlayed";
        protected override string OnSelectedForCardMergeDialogueId => "PallasNoctuaGivenSigil";
        protected override string OnSelectedForDeckTrialDialogueId => "PallasNoctuaTrial";
        public override Dictionary<Opponent.Type, string> OnDrawnSpecialOpponentDialogueIds => new Dictionary<Opponent.Type, string>() { };
        public override DialogueEvent.Speaker SpeakerType => DialogueEvent.Speaker.Stoat;

        public override IEnumerator OnShownForCardSelect(bool forPositiveEffect)
        {
            yield return new WaitForEndOfFrame();
            yield return base.OnShownForCardSelect(forPositiveEffect);
            yield break;
        }
    }
}