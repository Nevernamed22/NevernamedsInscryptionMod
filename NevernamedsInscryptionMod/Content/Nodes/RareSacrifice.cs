/*using DiskCardGame;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using APIPlugin;
using System.Collections;
using System.Linq;
using Pixelplacement;
using NevernamedsSigils;
using InscryptionAPI.Encounters;

namespace NevernamedsInscryptionMod
{
    class RareSacrifice : MonoBehaviour, ICustomNodeSequence
    {
        public static void Init()
        {
            NodeManager.Add<RareSacrifice, DeckHasRareCards>(
    new Texture2D[] {
        Tools.LoadTex("NevernamedsInscryptionMod/Resources/Nodes/raresacrifice1.png"),
        Tools.LoadTex("NevernamedsInscryptionMod/Resources/Nodes/raresacrifice2.png"),
        Tools.LoadTex("NevernamedsInscryptionMod/Resources/Nodes/raresacrifice3.png"),
        Tools.LoadTex("NevernamedsInscryptionMod/Resources/Nodes/raresacrifice2.png"),
    },
    NodeManager.NodePosition.CardChoiceRandom
);
        }
        public IEnumerator ExecuteCustomSequence(CustomNodeData nodeData)
        {
            throw new NotImplementedException();
        }
        public override IEnumerator DoCustomSequence()
        {
            //Sacrifice a card
            tableAnimals = new List<GameObject>();
            Singleton<ViewManager>.Instance.Controller.SwitchToControlMode(ViewController.ControlMode.CardMerging, false);
            Singleton<ViewManager>.Instance.Controller.LockState = ViewLockState.Locked;
            GameObject stone = Instantiate(SpecialNodeHandler.Instance.cardRemoveSequencer.stoneCircleAnim.gameObject);
            stone.SetActive(true);
            stone.transform.GetComponentsInChildren<Transform>().ToList().Find((x) => x.name.ToLower().Contains("ramskull"))?.gameObject?.SetActive(false);
            stone.transform.GetComponentInChildren<SelectCardFromDeckSlot>().Disable();

           yield return AddTableAnimals();



            yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("You approach a small forest clearing, marked with a semicircle of stones...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.WavyJitter);
            yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("Around the altar, a collection of beasts stand alert, waiting...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.WavyJitter);
            yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("They demand blood. Fine blood...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.WavyJitter);
            yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("[c:bR]Rare blood[c:]...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.WavyJitter);

            yield return new WaitForSeconds(1f);

            //Make sure the player actually has a rare card
            if (RunState.Run.playerDeck.Cards.Exists((x) => x != null && x.metaCategories != null && x.metaCategories.Contains(CardMetaCategory.Rare)))
            {

                sacrificeSlot = stone.transform.GetComponentInChildren<SelectCardFromDeckSlot>();
                sacrificeSlot.RevealAndEnable();
                sacrificeSlot.ClearDelegates();
                sacrificeSlot.CursorSelectStarted += OnSlotSelected;
                sacrificeSlot.backOutInputPressed = null;
                sacrificeSlot.backOutInputPressed += delegate ()
                {
                    if (sacrificeSlot.Enabled)
                    {
                        OnSlotSelected(this.sacrificeSlot);
                    }
                };

                yield return SpecialNodeHandler.Instance.cardRemoveSequencer.confirmStone.WaitUntilConfirmation();


                sacrificeSlot.Disable();

                foreach (SpecialCardBehaviour cardBehaviour in this.sacrificeSlot.Card.GetComponents<SpecialCardBehaviour>())
                {
                    yield return cardBehaviour.OnSelectedForCardRemoval();
                }
                SpecialCardBehaviour[] array = null;
                CardInfo sacrificedInfo = this.sacrificeSlot.Card.Info;

                bool merged = sacrificeSlot.Card.Info.Mods.Exists((x) => x.fromDuplicateMerge);
                int randommods = 0;
                foreach (CardModificationInfo mod in sacrificeSlot.Card.Info.Mods.FindAll((x) => x.fromCardMerge))
                {
                    randommods += mod.abilities.Count;
                }

                if (!sacrificeSlot.Card.Info.metaCategories.Contains(CardMetaCategory.Rare))
                {
                    //Punishes you for not sacrificing a rare
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("The beasts surround your offering as it cowers on the stones...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("This paltry sacrifice will [c:bR]not[c:] do.", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);

                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("They tear at the creature's flesh, deeply scarring it with hills and vallies of blood and gore.", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("And yet...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                    sacrificeSlot.Card.Anim.StrongNegationEffect();
                    yield return new WaitForSeconds(0.1f);
                    sacrificeSlot.Card.Anim.PlayTransformAnimation();
                    yield return new WaitForSeconds(0.05f);
                    List<Ability> newAbilities = negativeSigils.FindAll((x) => !sacrificeSlot.Card.Info.HasAbility(x));
                    if (newAbilities.Count > 0)
                    {
                        RunState.Run.playerDeck.ModifyCard(sacrificeSlot.Card.Info, new CardModificationInfo { abilities = new List<Ability> { Tools.RandomElement(newAbilities) }, nameReplacement = "Crippled  " + sacrificeSlot.Card.Info.DisplayedNameLocalized });
                    }
                    else if (sacrificeSlot.Card.Info.Attack > 0)
                    {
                        int amt = -2;
                        if (sacrificeSlot.Card.Info.Attack == 1) amt = -1;
                        RunState.Run.playerDeck.ModifyCard(sacrificeSlot.Card.Info, new CardModificationInfo { attackAdjustment = amt, nameReplacement = Tools.RandomElement(adjectives) + sacrificeSlot.Card.Info.DisplayedNameLocalized });
                    }
                    sacrificeSlot.Card.RenderCard();
                    yield return new WaitForSeconds(0.1f);

                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("The beast does not die...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("Wounded beyond any hope of recovery, it limps pathetically back to safety among your troupe.", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);


                    sacrificeSlot.FlyOffCard();
                    yield return new WaitForSeconds(0.2f);
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("The hungry beasts around the altar eye you warily. You are not welcome here.", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                    stone.GetComponentInChildren<Animator>().SetTrigger("exit");
                    yield return new WaitForSeconds(0.25f);
                    SpecialNodeHandler.Instance.cardRemoveSequencer.confirmStone.Exit();
                    yield return SpecialNodeHandler.Instance.cardRemoveSequencer.deckPile.DestroyCards(0.5f);
                    yield return RemoveTableAnimals();
                    yield return new WaitForSeconds(0.75f);
                    Destroy(stone);
                    SpecialNodeHandler.Instance.cardRemoveSequencer.confirmStone.SetStoneInactive();
                }
                else
                {
                    RunState.Run.playerDeck.RemoveCard(sacrificedInfo);
                    sacrificeSlot.Card.Anim.PlayDeathAnimation(false);
                    AudioController.Instance.PlaySound3D("sacrifice_default", MixerGroup.TableObjectsSFX, this.sacrificeSlot.transform.position, 1f, 0f, null, null, null, null, false);
                    yield return new WaitForSeconds(0.5f);
                    sacrificeSlot.DestroyCard();
                    stone.GetComponentInChildren<Animator>().SetTrigger("exit");
                    yield return new WaitForSeconds(0.25f);
                    SpecialNodeHandler.Instance.cardRemoveSequencer.confirmStone.Exit();
                    yield return RemoveTableAnimals();
                    yield return new WaitForSeconds(0.75f);
                    yield return SpecialNodeHandler.Instance.cardRemoveSequencer.deckPile.DestroyCards(0.5f);
                    Destroy(stone);
                    SpecialNodeHandler.Instance.cardRemoveSequencer.confirmStone.SetStoneInactive();

                    EnableViewDeck(ViewController.ControlMode.TradePelts, transform.position);

                    Singleton<ViewManager>.Instance.SwitchToView(View.TradingTopDown, false, false);
                    yield return new WaitForSeconds(0.25f);
                    yield return CreateTradeCards(GetCardInfos(merged, randommods), 5);
                    int cardsSelected = 0;
                    foreach (SelectableCard card in tradeCards)
                    {
                        if (card != null && card.gameObject != null)
                        {
                            card?.SetEnabled(true);
                        }
                        card.SetInteractionEnabled(true);
                        SelectableCard selectableCard = card;
                        selectableCard.CursorSelectStarted += delegate (MainInputInteractable c)
                       {
                           OnCardSelected(c as SelectableCard);
                           cardsSelected++;
                       };
                    }
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("Fed, the beasts seem more docile...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("You may choose three to accompany you.", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);

                    yield return new WaitUntil(() => cardsSelected >= 3);

                    foreach (SelectableCard card2 in tradeCards)
                    {
                        if (card2 != null && card2.gameObject != null)
                        {
                            card2.SetEnabled(false);
                        }
                    }

                    yield return CleanupTradeCards(tradeCards);
                    DisableViewDeck();

                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("With the new additions to your menagerie sated, and the screams of your former comrade pushed from your mind, you carry onwards...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.WavyJitter);
                }


            }
            else
            {
                //If you have no rare cards
                if (UnityEngine.Random.value <= 0.01f)
                {
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("The beasts glance between you and the utterly drab and common creatures of your group.", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("\"[c:bR]No Drip[c:]\", one snarls menacingly, baring it's fangs.", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("\"[c:bR]Get Bitches[c:]\", growls another.", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                    yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("Scoffing at this uncouth display, you hurry quickly on.", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                }
                else
                {
                yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("Nothing? At all?", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.Jitter);
                yield return Singleton<TextDisplayer>.Instance.ShowUntilInput("The beasts withdraw into the shadows, disappointed with your lack of offering...", -2.5f, 0.5f, Emotion.Neutral, TextDisplayer.LetterAnimation.WavyJitter);
                }
                stone.GetComponentInChildren<Animator>().SetTrigger("exit");
                yield return new WaitForSeconds(0.25f);
                SpecialNodeHandler.Instance.cardRemoveSequencer.confirmStone.Exit();
                yield return RemoveTableAnimals();
                yield return new WaitForSeconds(0.75f);
                Destroy(stone);
                SpecialNodeHandler.Instance.cardRemoveSequencer.confirmStone.SetStoneInactive();

            }
            yield break;
        }
        private void OnCardSelected(SelectableCard card)
        {
            card.SetEnabled(false);
            tradeCards.Remove(card);
            SpecialNodeHandler.Instance.tradePeltsSequencer.deckPile.MoveCardToPile(card, true, 0f, 0.7f);
            SpecialNodeHandler.Instance.tradePeltsSequencer.deckPile.AddToPile(card.transform);
            RunState.Run.playerDeck.AddCard(card.Info);
            AnalyticsManager.SendCardPickedEvent(card.Info.name);
            bool flag2 = card.Info.name == "MantisGod";
            if (flag2)
            {
                AscensionStatsData.TryIncrementStat(AscensionStat.Type.MantisGodsPicked);
            }
        }
        private void OnSlotSelected(MainInputInteractable slot)
        {
            sacrificeSlot.SetEnabled(false);
            sacrificeSlot.ShowState(HighlightedInteractable.State.NonInteractable, false, 0.15f);
            SpecialNodeHandler.Instance.cardRemoveSequencer.confirmStone.Exit();
            (slot as SelectCardFromDeckSlot).SelectFromCards(this.GetValidCards(), OnSelectionEnded, false);
        }
        private List<CardInfo> GetValidCards()
        {
            return new List<CardInfo>(RunState.DeckList).FindAll((x) => x != null && !x.traits.Contains(Trait.Pelt) && !x.traits.Contains(Trait.Terrain));
        }
        private void OnSelectionEnded()
        {
            sacrificeSlot.SetShown(true, false);
            sacrificeSlot.ShowState(HighlightedInteractable.State.Interactable, false, 0.15f);
            Singleton<ViewManager>.Instance.SwitchToView(View.CardMergeSlots, false, true);
            if (sacrificeSlot.Card != null)
            {
                SpecialNodeHandler.Instance.cardRemoveSequencer.confirmStone.Enter();
            }
        }
        private List<CardInfo> GetCardInfos(bool merged, int nummods)
        {
            List<CardInfo> unlockedCards = CardLoader.GetUnlockedCards(CardMetaCategory.TraderOffer, CardTemple.Nature);
            int numCards = 10;
            List<CardInfo> list = CardLoader.GetDistinctCardsFromPool(SaveManager.SaveFile.GetCurrentRandomSeed(), numCards, unlockedCards, nummods, false);
            if (merged)
            {
                
                    list.ForEach(delegate (CardInfo x)
                    {
                        x.Mods.Add(DuplicateMergeSequencer.GetDuplicateMod(x.Attack, x.Health));
                    });
                
            }
            return list;
        }
        private IEnumerator CreateTradeCards(List<CardInfo> cards, int cardsPerRow)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int x = i % cardsPerRow;
                int y = (i >= cardsPerRow) ? 0 : 1;
                GameObject cardObj = Instantiate(SpecialNodeHandler.Instance.tradePeltsSequencer.selectableCardPrefab, transform);
                cardObj.gameObject.SetActive(true);
                SelectableCard card = cardObj.GetComponent<SelectableCard>();
                card.SetInfo(cards[i]);
                foreach (SpecialCardBehaviour specialBehaviour in cardObj.GetComponents<SpecialCardBehaviour>())
                {
                    specialBehaviour.OnShownForCardChoiceNode();
                }
                Vector3 destinationPos = SpecialNodeHandler.Instance.tradePeltsSequencer.CARDS_ANCHOR + new Vector3((SpecialNodeHandler.Instance.tradePeltsSequencer.CARD_SPACING.x * (float)(x - 1)), 0f, SpecialNodeHandler.Instance.tradePeltsSequencer.CARD_SPACING.y * (float)y);
                if (cards.Count <= 4)
                {
                    destinationPos.z = -2f;
                }
                Vector3 destinationRot = new Vector3(90f, 90f, 90f);
                card.transform.position = destinationPos + new Vector3(0f, 0.25f, 3f);
                card.transform.eulerAngles = destinationRot + new Vector3(0f, 0f, -7.5f + UnityEngine.Random.value * 7.5f);
                Tween.Position(card.transform, destinationPos, 0.15f, 0f, Tween.EaseOut, Tween.LoopType.None, null, null, true);
                Tween.Rotation(card.transform, destinationRot, 0.15f, 0f, Tween.EaseOut, Tween.LoopType.None, null, null, true);
                tradeCards.Add(card);
                card.SetEnabled(false);
                card.Anim.PlayQuickRiffleSound();
                yield return new WaitForSeconds(0.05f);
            }
            yield break;
        }
        private IEnumerator CleanupTradeCards(List<SelectableCard> selectableCards)
        {
            for (int i = selectableCards.Count - 1; i >= 0; i--)
            {
                SelectableCard card = selectableCards[i];
                Vector3 destinationPos = card.transform.position + new Vector3(0f, 0.25f, 5f);
                Vector3 destinationRot = card.transform.eulerAngles + new Vector3(0f, 0f, -7.5f + UnityEngine.Random.value * 7.5f);
                Tween.Position(card.transform, destinationPos, 0.15f, 0f, Tween.EaseIn, Tween.LoopType.None, null, null, true);
                Tween.Rotation(card.transform, destinationRot, 0.15f, 0f, Tween.EaseIn, Tween.LoopType.None, null, null, true);
                Destroy(card.gameObject, 0.3f);
                yield return new WaitForSeconds(0.05f);
            }
            yield break;
        }

        private IEnumerator RemoveTableAnimals()
        {
            foreach (GameObject obj in tableAnimals)
            {
                Tools.FallOntoTable(obj, true);
            }
            yield return new WaitForSeconds(0.3f);
            for (int i = tableAnimals.Count - 1; i >= 0; i--)
            {
                UnityEngine.Object.Destroy(tableAnimals[i]);
            }
            tableAnimals.Clear();
            yield break;
        }
        private IEnumerator AddTableAnimals()
        {
            WolfStatueSlotInteractable[] allSlots = Resources.FindObjectsOfTypeAll<WolfStatueSlotInteractable>();
            if (allSlots.Count() > 0)
            {
                WolfStatueSlotInteractable slot = allSlots[0];
                if (slot != null && slot.pulleysAnim != null && slot.wolfStatue != null)
                {
                    bool wasActiveBefore = slot.wolfStatue.gameObject.activeSelf;
                    slot.wolfStatue.gameObject.SetActive(false);

                    GameObject wolf = Instantiate(slot.wolfStatue.gameObject, SpecialNodeHandler.Instance.tradePeltsSequencer.CARDS_ANCHOR + new Vector3(0, -0.5f, 2.5f), Quaternion.identity);
                    Destroy(wolf.GetComponent<HoldableInteractable>());



                    slot.wolfStatue.gameObject.SetActive(wasActiveBefore);

                    wolf.SetActive(true);

                    wolf.transform.Rotate(Vector3.up, -20);
                    Tools.FallOntoTable(wolf, false);

                    tableAnimals.Add(wolf);



                    GameObject squirrel = Instantiate(slot.pulleysAnim.transform.Find("squirrel").gameObject, SpecialNodeHandler.Instance.tradePeltsSequencer.CARDS_ANCHOR + new Vector3(1, -1f, 1.5f), Quaternion.identity);
                    squirrel.SetActive(true);
                    squirrel.transform.Rotate(Vector3.up, 120);
                    Tools.FallOntoTable(squirrel, false);
                    tableAnimals.Add(squirrel);
                    foreach (Transform child in squirrel.transform.GetComponentsInChildren<Transform>())
                    {
                        UnityEngine.Debug.Log("child/transform: " + child.name);
                    }
                    int squiterator = 0;
                    foreach (Vector4 position in squirrelpositions)
                    {
                    GameObject squirrelFigurine = Instantiate(Singleton<Part1CardDrawPiles>.Instance.sidePileFigurineObjects[(int)SidePileFigurine.Squirrel], new Vector3(position.x, position.y, position.z), Quaternion.identity);
                    squirrelFigurine.SetActive(true);
                    Tools.FallOntoTable(squirrelFigurine, false, 0.15f);
                    tableAnimals.Add(squirrelFigurine);
                        squirrelFigurine.transform.Rotate(Vector3.up, position.w);
                        squiterator++;
                        yield return new WaitForSeconds(0.1f);
                    }
                }
            }
        }

        

        private List<GameObject> tableAnimals;
        private List<string> adjectives = new List<string>()
        {
            "Crippled ",
            "Mauled ",
            "Disfigured ",
            "Eviscerated ",
            "Gored ",
        };
        private List<Ability> negativeSigils = new List<Ability>()
        {
            Doomed.ability,
            Ability.BuffEnemy,
            Abstain.ability,
            Endangered.ability,
        };

        private List<Vector4> squirrelpositions = new List<Vector4>
        {
             new Vector4(-2f, 5.06f, -1.9f, 40.21f), 
             new Vector4(-2f, 5.06f, -1.4f, 58.99f), 
             new Vector4(-2.5f, 5.06f, -1.4f, 58.99f),
             new Vector4(-2.5f, 5.06f, -2.3f, 45.93f), 
              new Vector4(2.3f, 5.06f, -2.3f, 344.83f),
             new Vector4(2.5f, 5.06f, -1.9f, 327.71f), 
             new Vector4(3.5f, 5.06f, -1.3f, 305.52f), 
             new Vector4(2.5f, 7.6f, 1.2999f, 240.49f), 
        };

        public SelectCardFromDeckSlot sacrificeSlot;
        private List<SelectableCard> tradeCards = new List<SelectableCard>();
    }
    public class DeckHasRareCards : CustomNodeData
    {
        public override void Initialize()
        {
            this.AddGenerationPrerequisite(() => (RunState.Run.playerDeck.Cards.FindAll((x) => x != null && x.metaCategories != null && x.metaCategories.Contains(CardMetaCategory.Rare)).Count >= 2) && UnityEngine.Random.value <= 0.5f);
        }
    }
}*/
