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
    static class CustomStoat
    {
        //A static reference to the talking card's Face object.
        public static GameObject Face;
        public static void Init()
        {
            //Loads and sets up the talking card face object.
            #region SetupFace
            //Loads the face GameObject you made in Unity from your custom Asset Bundle via it's gameobject name.
            Face = Plugin.bundle.LoadAsset<GameObject>("CustomStoatPortrait");

            CharacterFace face = Face.AddComponent<CharacterFace>();
            face.anim = Face.transform.Find("Anim").GetComponent<Animator>();
            face.eyes = Face.transform.Find("Anim").Find("Body").Find("eyes").gameObject.AddComponent<CharacterEyes>();
            face.mouth = Face.transform.Find("Anim").Find("Body").Find("mouth").gameObject.AddComponent<CharacterMouth>();
            face.face = Face.transform.Find("Anim").Find("Body").GetComponent<SpriteRenderer>();

            //Adds new emotions to the list that the card is capable of expressing. Cards do not need multiple emotions to function, but they do at least need a 'Neutral' state.
            face.emotionSprites = new List<CharacterFace.EmotionSprites>
             {
                new CharacterFace.EmotionSprites
                {
                    emotion = Emotion.Neutral, //The emotion being initialised.
                    face = face.face.sprite,

                    //Sets up the different facial features for the emotion. Just like in unity, different parts of the facial expression should have the exact same dimensions as the body texture, so that they could be seamlessly overlayed.
                    eyesOpen = face.eyes.GetComponent<SpriteRenderer>().sprite, //Sets the eye sprite for the expression to the default eyes you set up in unity. Best kept this way for a neutral expression, but may be changed for other emotions.
                    mouthClosed = face.mouth.GetComponent<SpriteRenderer>().sprite, //Same as the above comment, but relating to the mouth.
                    
                    //Sets the other parts of the expression for the emotion. All resource paths refer to embedded PNGs somewhere in your project.
                    //If you are unaware of how to set up an embedded PNG, refer to the section of the tutorial document which tells you how to embed the AssetBundle into your project (Step 7.1 - 7.2) and do the same, but with a PNG.
                    //It's very important to make sure all the sprite paths are correct.
                    
                    //Initialises the Texture of the card's eyes when blinking.
                    eyesClosed = TextureLoadUtility.ConvertTexToSprite(TextureLoadUtility.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/stoat_eyesblink.png"), new Vector2(0.5f, 0f)),
                    
                    //Initialises the Texture of the card's emission.
                    eyesOpenEmission = TextureLoadUtility.ConvertTexToSprite(TextureLoadUtility.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/stoat_eyes_emission.png"), new Vector2(0.5f, 0f)),
                    
                    //Initialises the Texture of the card's emission when it's eyes are blinking. If the card's emission is not in it's eyes, this should be set to the same as the normal eyes open emission.
                    //In this example, because the stoat has NO emission when it's eyes are closed, I've commented out the line.
                    // eyesClosedEmission = TextureLoadUtility.ConvertTexToSprite(TextureLoadUtility.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/stoat_eyesblink_emission.png"), new Vector2(0.5f, 0f)),
                    
                    //Initialises the Texture of the card's mouth when it is open, aka when the card is talking.
                    mouthOpen = TextureLoadUtility.ConvertTexToSprite(TextureLoadUtility.LoadTex("NevernamedsInscryptionMod/Resources/TalkingCards/Act1/Stoat/stoat_mouthopen.png"), new Vector2(0.5f, 0f)),
                }};

            //Adjusts the card's voice
            face.voiceSoundId = "female1_voice"; //Other viable voices are 'kobold_voice' and 'cat_voice'. Most talking cards just use female1_voice, however, and change the pitch.
            face.voiceSoundPitch = 1; //The pitch of the card's voice. Increase the number to make the voice higher, decrease it to make the voice deeper.
            face.eyes.blinkRate = 1.5f; //Controls how often the card blinks. Higher number means more blinking.

            int offscreen = LayerMask.NameToLayer("CardOffscreen");
            foreach (Transform t in Face.GetComponentsInChildren<Transform>()) { t.gameObject.layer = offscreen; }
            Face.layer = offscreen;
            face.eyes.emissionRenderer = face.eyes.transform.Find("emission")?.GetComponent<SpriteRenderer>();
            if (face.eyes.emissionRenderer != null) { face.eyes.emissionRenderer.gameObject.layer = LayerMask.NameToLayer("CardOffscreenEmission"); }
            #endregion

            //Sets up the talking card's dialogue under specific dialogue events.
            #region SetupDialogue

            //Feel free to experiment, but my preferred method is as follows.
            DialogueEventGenerator.GenerateEvent("CustomStoatDrawn", //The name of the dialogue event to be created.
                //A list of ordered dialogue lines, which will play one by one over the course of a run until they are all exhausted.
                //Lines put in this first list will ALWAYS play in the set order when the event happens. If you want the dialogue to be more random, and not structured like this, you can do what I've done here.
                //In this example, the first time the Stoat is drawn it will always say "Lucky Draw", but from thereon out it's set dialogue will be exhausted, and it will say the random lines.
            new List<CustomLine> { "Lucky draw." },
                //A list of lists of lines corresponding to random dialogue which will play when the aforementioned set dialogue is exhausted.
            new List<List<CustomLine>>{
            new List<CustomLine>{"Lucky draw."},
            new List<CustomLine>{"Nice topdeck."},
            new List<CustomLine>{"Me Again."},
            new List<CustomLine>{"Yep."},
            new List<CustomLine>{"Don't die"},
            new List<CustomLine>{"not the worst draw."}
                //Controls how the dialogue event decides to loop. RandomDefinedRepeat makes it so the random lines will be randomly picked once the set lines are exhausted.
            }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);
            
            DialogueEventGenerator.GenerateEvent("CustomStoatPlayed", 
            new List<CustomLine>{"Here we go."}, 
            new List<List<CustomLine>>{
            new List<CustomLine>{"Back on the board."},
            new List<CustomLine>{"Here we go."},
            new List<CustomLine>{"This spot? You sure?"},
            new List<CustomLine>{"OK..."},
            new List<CustomLine>{ "Fine."},
            new List<CustomLine>{"Bad play."},
            new List<CustomLine>{"Total misplay."},
            new List<CustomLine>{"Keep me alive."},
            new List<CustomLine>{"Yep."},
            new List<CustomLine>{"...sure."}
            }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStoatSacrificed",
            new List<CustomLine>{"Wow... seriously?"}, 
            new List<List<CustomLine>>{
            new List<CustomLine>{"Wow... seriously?"},
            new List<CustomLine>{"Again?"},
            new List<CustomLine>{"Oh come on!"}
            }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStoatSelectableGood", 
            new List<CustomLine>{"I'll go."}, 
            new List<List<CustomLine>>{
            new List<CustomLine>{"I'll go."},
            new List<CustomLine>{"It's me."},
            new List<CustomLine>{"Your choice."}
            }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStoatSelectableBad", 
            new List<CustomLine>{"Hmm..."}, 
            new List<List<CustomLine>>{
            new List<CustomLine>{"Hmm..."},
            new List<CustomLine>{"Nope."},
            new List<CustomLine>{"No way."},
            new List<CustomLine>{"Nope. Nope. Nope."},
            new List<CustomLine>{"Stop this."},
            new List<CustomLine>{"Pick something else."},
            new List<CustomLine>{"Please. No."}
            }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStoatHurt",
            new List<CustomLine>{"Ack."}, 
            new List<List<CustomLine>>{
            new List<CustomLine>{"Stop that."},
            new List<CustomLine>{"Ack."},
            new List<CustomLine>{"Ow."},
            new List<CustomLine>{"Ouch."},
            new List<CustomLine>{"Enough!"}
            }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStoatProspector", 
            new List<CustomLine>{"The Prospector. Again."}, 
            new List<List<CustomLine>>{
            new List<CustomLine>{"Prospector boss... again..."},
            new List<CustomLine>{"The Prospector. Again."},
            new List<CustomLine>{"Boss time, eh?"},
            new List<CustomLine>{"Easy boss.", "Just pop that mule."},
            new List<CustomLine>{"the mule's key"},
            new List<CustomLine>{"easy boss"}
            }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStoatGivenSigil", 
            new List<CustomLine>{"What an honor."}, 
            new List<List<CustomLine>>{
            new List<CustomLine>{"Fine choice"},
            new List<CustomLine>{"What an honor"},
            new List<CustomLine>{"Yeah? Alright"},
            new List<CustomLine>{"Another sigil..."}
            }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            DialogueEventGenerator.GenerateEvent("CustomStoatTrial", 
            new List<CustomLine>{"Good luck."}, 
            new List<List<CustomLine>>{
            new List<CustomLine>{"Good luck..."},
            new List<CustomLine>{"This again?"},
            new List<CustomLine>{"Fingers crossed"}
            }, DialogueEvent.MaxRepeatsBehaviour.RandomDefinedRepeat);

            #endregion

            //Sets up the custom talking card behaviour as a SpecialTriggeredAbility
            SpecialTriggeredAbility ability = SpecialTriggeredAbilityManager.Add(Plugin.PluginGuid, "CustomStoatTalker", typeof(CustomStoatTalker)).Id;

            //Sets up the card definition itself. This particular method is from my custom toolbox, but you can use whatever setup method you normally use.
            //Just don't forget to call it from your main class so that it gets initialised.
            //There are only three important things that define the card as a talking card.
            CardSetupUtility.NewCard("Nevernamed CustomStoat",
                "Stoat",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.TraderOffer, CardMetaCategory.ChoiceNode },
                CardTemple.Nature,
                description: "The... stoat. Did I leave this here?",
                bloodCost: 1,
                bonesCost: 0,
                onePerDeck: true,
                animatedPortrait: Face, // You need to set the 'animatedPortrait' variable of the CardInfo to the static reference of the Card Face at the top of this file.
                abilities: new List<Ability>() { },
                defaultTex: null,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.AnimatedPortrait }, // You need to give the card the AnimatedPortrait appearance behaviour
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { ability } // You need to add the Talking card triggered ability defined above to the card's list of special abilities.
                );
        }
    }
    //The class type of your custom Talking Card's special triggered talking behaviour. Each talking card needs it's own version of this.
    public class CustomStoatTalker : PaperTalkingCard
    {
        //Sets the dialogue events which correspond to the various events talking cards are capable of responding to. These are the dialogue event names you set when setting up the dialogue events themselves.
        //If you don't want the card to respond to the given event, you can just delete the line in this class which sets it's response dialogue.

        //The dialogue event for when the card is drawn from the player's deck in battle.
        public override string OnDrawnDialogueId => "CustomStoatDrawn";
        
        //The dialogue event for when the card is harmed in combat.
        public override string OnAttackedDialogueId => "CustomStoatHurt";

        //The dialogue event for when the card is sacrificed in combat.
        protected override string OnSacrificedDialogueId => "CustomStoatSacrificed";

        //The dialogue event for when the card is available for selection for a negative event.
        public override string OnBecomeSelectableNegativeDialogueId => "CustomStoatSelectableBad";

        //The dialogue event for when the card is available for selection for a positive event.
        public override string OnBecomeSelectablePositiveDialogueId => "CustomStoatSelectableGood";

        //The dialogue event for when the card is played onto the board from the player's hand.
        public override string OnPlayFromHandDialogueId => "CustomStoatPlayed";

        //A fallback dialogue event for when the card is drawn. I don't actually know what this is for, but just to be safe I've set it to an existing dialogue event.
        public override string OnDrawnFallbackDialogueId => "CustomStoatPlayed";

        //The dialogue event for when the card is selectable for the bone lord sacrifice node.
        protected override string OnSelectedForCardRemoveDialogueId => "CustomStoatSelectableBad";

        //The dialogue event for when the card is given a sigil at the sacrifice stones.
        protected override string OnSelectedForCardMergeDialogueId => "CustomStoatGivenSigil";

        //The dialogue event for when the card is drawn in a deck trial.
        protected override string OnSelectedForDeckTrialDialogueId => "CustomStoatTrial";

        //A dictionary of dialogue events corresponding to bosses in the game. This dictionary is what allows cards to have special dialogue when drawn on specific bosses.
        //In this case, the stoat will say the 'CustomStoatProspector' dialogue event when drawn during the ProspectorBoss opponent type.
        public override Dictionary<Opponent.Type, string> OnDrawnSpecialOpponentDialogueIds => new Dictionary<Opponent.Type, string>()
        {
            { Opponent.Type.ProspectorBoss, "CustomStoatProspector" }
        };

        //I don't know what the speaker type variable actually does, but I just leave it set to Stoat on all my talking cards and it's never broken anything.
        public override DialogueEvent.Speaker SpeakerType => DialogueEvent.Speaker.Stoat;

        //Fixes a Null which arises when custom talking cards are shown for card selection.
        public override IEnumerator OnShownForCardSelect(bool forPositiveEffect)
        {
            yield return new WaitForEndOfFrame();
            yield return base.OnShownForCardSelect(forPositiveEffect);
            yield break;
        }
    }
}