using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using DiskCardGame;
using UnityEngine;
using BepInEx.Logging;
using System.Collections;
using Pixelplacement;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    public static class Tools
    {
        public static CardModificationInfo CondenseMods(this PlayableCard card, List<Ability> excludedabilities = null)
        {
            CardModificationInfo mod = new CardModificationInfo();
            foreach (CardModificationInfo mod1 in card.temporaryMods)
            {
                if (excludedabilities != null) mod.abilities.AddRange(mod1.abilities.FindAll((x) => !excludedabilities.Contains(x)));
                else mod.abilities.AddRange(mod1.abilities);
                mod.attackAdjustment = mod1.attackAdjustment;
                mod.healthAdjustment = mod1.healthAdjustment;
            }
            foreach (CardModificationInfo mod2 in card.Info.mods)
            {
                if (excludedabilities != null) mod.abilities.AddRange(mod2.abilities.FindAll((x) => !excludedabilities.Contains(x)));
                mod.attackAdjustment = mod2.attackAdjustment;
                mod.healthAdjustment = mod2.healthAdjustment;
            }
            if (mod.abilities.Count > 0) mod.fromCardMerge = true;
            return mod;
        }
        public static bool CardIsInSideDeck(this CardInfo card)
        {
            if (CardDrawPiles3D.Instance.SideDeck.Cards.FindAll((x) => x != null && x.name == card.name).Count > 0) return true;
            else return false;
        }
        public static void FallOntoTable(GameObject obj, bool reverse, float time = 0.3f)
        {
            if (!reverse)
            {
            Vector3 startval = obj.transform.position;
            obj.transform.position += new Vector3(0, 5, 0);
            Tween.Position(obj.transform, startval, time, 0f, Tween.EaseBounce);
            }
            else
            {
                Vector3 targetval = obj.transform.position + new Vector3(0,5,0);
                Tween.Position(obj.transform, targetval, time, 0f, Tween.EaseIn);
            }
        }

        public static CardInfo TrueClone(CardInfo original)
        {
            CardInfo clone = CardLoader.Clone(original);
            clone.abilities = original.abilities;
            clone.baseAttack = original.baseAttack;
            clone.baseHealth = original.baseHealth;
            clone.mods.AddRange(original.mods);
            return clone;
        }
        public static void LogComponents(GameObject obj)
        {
            foreach (Component component in obj.GetComponentsInChildren<Component>())
            {
                Debug.Log(component.GetType().ToString());
            }
        }
        public static bool IsFree(this CardInfo card)
        {
            if (card.bonesCost == 0 && card.BloodCost == 0 && card.energyCost == 0 && card.gemsCost.Count == 0) { return true; }
            else return false;
        }

        public static bool MeetsDependantRequirements(this CardInfo card)
        {
            bool meetsRequirements = true;
            if (card.HasAbility(Ability.GemDependant) && ResourcesManager.Instance.gems.Count <= 0) meetsRequirements = false;
            if (card.HasAbility(EnergyDependent.ability) && ResourcesManager.Instance.PlayerEnergy <= 0) meetsRequirements = false;
            return meetsRequirements;
        }
        public static void ClearBoard(List<CardSlot> exemptions = null, bool eraseInsteadOfKill = false)
        {
            foreach (CardSlot cardSlot in Singleton<BoardManager>.Instance.AllSlots)
            {
                if (exemptions == null || exemptions.Count <= 0 || !exemptions.Contains(cardSlot))
                {
                    if (cardSlot.Card != null)
                    {
                        PlayableCard card = cardSlot.Card;
                        if (!card.Dead)
                        {
                            if (eraseInsteadOfKill)
                            {
                                card.UnassignFromSlot();
                                UnityEngine.Object.Destroy(card.gameObject);
                            }
                            else
                            {
                                card.Die(false);
                            }
                        }
                    }
                }
            }
        }
        public static Sprite ConvertTexToSprite(Texture2D tex, Vector2? pivot = null)
        {
            Vector2 actualPivot = new Vector2(0.5f, 0.5f);
            if (pivot != null)
            {
                actualPivot = new Vector2(pivot.Value.x, pivot.Value.y);
            }
            tex.filterMode = FilterMode.Point;
            Sprite texSprite1 = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), actualPivot, 100.0f);
            return texSprite1;
        }
        public static Sprite GenerateAct2Portrait(Texture2D tex)
        {
            tex.filterMode = FilterMode.Point;
            Sprite texSprite1 = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
            return texSprite1;
        }
        public static IEnumerator ForceCardAttackOutsideOfCombat(this PlayableCard attackercard)
        {
            int damageToAddToScales = 0;
            List<CardSlot> slots = attackercard.GetOpposingSlots();
            foreach (CardSlot slot in slots)
            {
                if (attackercard.CanAttackDirectly(slot)) damageToAddToScales = attackercard.Attack;
                yield return Singleton<TurnManager>.Instance.CombatPhaseManager.SlotAttackSlot(attackercard.Slot, slot, 0f);
                yield return new WaitForSeconds(0.15f);
            }
            yield return new WaitForSeconds(0.4f);
            yield return Singleton<TurnManager>.Instance.CombatPhaseManager.VisualizeDamageMovingToScales(true);
            int excessDamage = 0;
            excessDamage = Singleton<LifeManager>.Instance.Balance + damageToAddToScales - 5;
            excessDamage = Mathf.Max(0, excessDamage);

            int damage = damageToAddToScales - excessDamage;

            yield return Singleton<LifeManager>.Instance.ShowDamageSequence(damage, damage, false, 0f, null, 0f, true);

            if (excessDamage > 0 && Singleton<TurnManager>.Instance.Opponent.NumLives == 1 && Singleton<TurnManager>.Instance.Opponent.GiveCurrencyOnDefeat)
            {
                yield return Singleton<TurnManager>.Instance.Opponent.TryRevokeSurrender();
                RunState.Run.currency += excessDamage;
                yield return Singleton<TurnManager>.Instance.CombatPhaseManager.VisualizeExcessLethalDamage(excessDamage, Singleton<TurnManager>.Instance.SpecialSequencer);
            }
            yield break;
        }
        public static void SpawnParticlesOnCard(this PlayableCard target, Texture2D tex, bool reduceY = false)
        {
            PaperCardAnimationController anim = target.Anim as PaperCardAnimationController;
            GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(anim.deathParticles);
            ParticleSystem particle = gameObject.GetComponent<ParticleSystem>();
            ParticleSystem.MainModule mainMod = particle.main;
            particle.startColor = Color.white;
            particle.GetComponent<ParticleSystemRenderer>().material = new Material(particle.GetComponent<ParticleSystemRenderer>().material) { mainTexture = tex };
            mainMod.startColor = new ParticleSystem.MinMaxGradient(Color.white);
            gameObject.SetActive(true);
            gameObject.transform.SetParent(anim.transform);
            gameObject.transform.position = anim.deathParticles.transform.position;
            gameObject.transform.localScale = anim.deathParticles.transform.localScale;
            gameObject.transform.rotation = anim.deathParticles.transform.rotation;
            if (reduceY)
            {
                particle.transform.position = new Vector3(particle.transform.position.x, particle.transform.position.y - 0.1f, particle.transform.position.z);
            }
            UnityEngine.Object.Destroy(gameObject, 6f);
        }
        public static void TemporarilyRemoveAbilityFromCard(this PlayableCard card, Ability toRemove)
        {
            CardModificationInfo removeAbility = new CardModificationInfo();
            removeAbility.negateAbilities.Add(toRemove);
            card.AddTemporaryMod(removeAbility);
            card.Status.hiddenAbilities.Add(toRemove);
            card.RenderCard();
        }
        public static CardInfo GetRandomCardOfTempleAndQuality(CardTemple temple, int act, bool isRare, Tribe requiredTribe = Tribe.None, bool checkDependant = false)
        {
            CardMetaCategory categoryToCheck = CardMetaCategory.NUM_CATEGORIES;
            if (act > 0 && act < 4)
            {
                switch (temple)
                {
                    case CardTemple.Nature:
                        if (act == 1)
                        {
                            if (isRare) categoryToCheck = CardMetaCategory.Rare;
                            else categoryToCheck = CardMetaCategory.ChoiceNode;
                        }
                        else if (act == 2) categoryToCheck = CardMetaCategory.GBCPack;
                        else Debug.LogWarning($"Tried to get a card of the {temple} temple in act {act} which is not a valid act for the given temple.");
                        break;
                    case CardTemple.Tech:
                        if (act == 2) categoryToCheck = CardMetaCategory.GBCPack;
                        else if (act == 3) categoryToCheck = CardMetaCategory.Part3Random;
                        else Debug.LogWarning($"Tried to get a card of the {temple} temple in act {act} which is not a valid act for the given temple.");
                        break;
                    case CardTemple.Undead:
                        if (act == 2) categoryToCheck = CardMetaCategory.GBCPack;
                        else Debug.LogWarning($"Tried to get a card of the {temple} temple in act {act} which is not a valid act for the given temple.");
                        break;
                    case CardTemple.Wizard:
                        if (act == 2) categoryToCheck = CardMetaCategory.GBCPack;
                        else Debug.LogWarning($"Tried to get a card of the {temple} temple in act {act} which is not a valid act for the given temple.");
                        break;
                }
            }
            else Debug.LogWarning($"Tried to get a card of act {act} which is not valid.");


            if (act != 1) requiredTribe = Tribe.None;

            if (categoryToCheck != CardMetaCategory.NUM_CATEGORIES)
            {
                List<CardInfo> cards = ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) =>
                x.metaCategories.Contains(categoryToCheck) &&
                x.temple == temple &&
                ((checkDependant && x.MeetsDependantRequirements()) || !checkDependant) &&
                !x.specialAbilities.Contains(SpecialTriggeredAbility.RandomCard) &&
                ConceptProgressionTree.Tree.CardUnlocked(x, false) &&
                !x.traits.Contains(Trait.Terrain) &&
                ((x.HasRareTagOrBackground() == isRare) || act == 3) &&
                ((requiredTribe == Tribe.None) || x.tribes.Contains(requiredTribe))
            );
                if (cards.Count > 0) return SeededRandomElement(cards, GetRandomSeed());
                else return null;
            }
            else Debug.LogWarning($"Valid category for given criteria was not found!");

            return null;
        }
        public static int GetActAsInt()
        {
            if (SaveManager.SaveFile.IsPart1) return 1;
            if (SaveManager.SaveFile.IsPart2) return 2;
            if (SaveManager.SaveFile.IsPart3) return 3;
            if (SaveManager.SaveFile.IsGrimora) return 4;
            if (SaveManager.SaveFile.IsMagnificus) return 5;
            else return 0;
        }
        public static bool HasRareTagOrBackground(this CardInfo card)
        {
            if (card.metaCategories.Contains(CardMetaCategory.Rare) || card.appearanceBehaviour.Contains(CardAppearanceBehaviour.Appearance.RareCardBackground)) return true;
            else return false;
        }
        public static CardInfo GetRandomChoosableCardOfTribesWithExceptions(int randomSeed, List<Tribe> tribes, List<CardInfo> exceptions)
        {
            List<CardInfo> list = CardLoader.GetUnlockedCards(CardMetaCategory.ChoiceNode, CardTemple.Nature).FindAll((CardInfo x) => x.IsOfAnyTribe(tribes) && !exceptions.Exists((CardInfo y) => y.name == x.name));
            if (list.Count == 0)
            {
                return CardLoader.GetCardByName("Amalgam");
            }
            else
            {
                return CardLoader.Clone(list[SeededRandom.Range(0, list.Count, randomSeed)]);
            }
        }
        public static bool IsOfAllTribes(this CardInfo inf, List<Tribe> tribes)
        {
            if (tribes != null && tribes.Count > 0)
            {
                foreach (Tribe t in tribes)
                {
                    if (!inf.tribes.Contains(t))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsOfAnyTribe(this CardInfo inf, List<Tribe> tribes)
        {
            if (tribes != null)
            {
                foreach (Tribe t in tribes)
                {
                    if (inf.tribes.Contains(t))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool HasTrait(this PlayableCard card, Trait type)
        {
            if (card != null && card.Info != null && card.Info.traits != null)
            {
                if (card.Info.traits.Count > 0 && card.Info.traits.Contains(type))
                {
                    return true;
                }
            }
            return false;
        }
        public static List<Ability> GetAllAbilities(this PlayableCard c)
        {
            List<Ability> ab = new List<Ability>();
            if (c != null)
            {
                if (c.Info != null && c.Info.Abilities != null)
                {
                    foreach (Ability a in c.Info.Abilities)
                    {
                        if (c.temporaryMods != null)
                        {
                            if (!c.temporaryMods.Exists((CardModificationInfo mo) => mo.negateAbilities.Contains(a)))
                            {
                                ab.Add(a);
                            }
                        }
                        else
                        {
                            ab.Add(a);
                        }
                    }
                }
                if (c.temporaryMods != null)
                {
                    foreach (CardModificationInfo i in c.temporaryMods)
                    {
                        if (i.abilities != null)
                        {
                            foreach (Ability a in i.abilities)
                            {
                                if (!c.temporaryMods.Exists((CardModificationInfo mo) => mo.negateAbilities.Contains(a)))
                                {
                                    ab.Add(a);
                                }
                            }
                        }
                    }
                }
            }
            return ab;
        }
        public static PlayableCard GetStrongestCardOnBoard(bool playerSide)
        {
            PlayableCard strongest = null;
            List<CardSlot> viableslots = new List<CardSlot>();
            if (!playerSide) viableslots = Singleton<BoardManager>.Instance.opponentSlots;
            else viableslots = Singleton<BoardManager>.Instance.playerSlots;
            foreach (CardSlot slot in viableslots)
            {
                if (slot && slot.Card)
                {
                    if (strongest == null || strongest.PowerLevel < slot.Card.PowerLevel)
                    {
                        strongest = slot.Card;
                    }
                }
            }
            return strongest;
        }
        public static Texture2D LoadTex(string path)
        {            
            byte[] imgBytes = ExtractEmbeddedResource(path);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(imgBytes);
            tex.filterMode = FilterMode.Point;
            return tex;
        }
        public static byte[] ExtractEmbeddedResource(String filePath)
        {
            filePath = filePath.Replace("/", ".");
            filePath = filePath.Replace("\\", ".");
            var baseAssembly = Assembly.GetCallingAssembly();
            using (Stream resFilestream = baseAssembly.GetManifestResourceStream(filePath))
            {
                if (resFilestream == null)
                {

                    return null;
                }
                byte[] ba = new byte[resFilestream.Length];
                resFilestream.Read(ba, 0, ba.Length);
                return ba;
            }
        }
        public static T RandomElement<T>(List<T> list)
        {
            return list[UnityEngine.Random.Range(0, list.Count)];
        }
        public static T SeededRandomElement<T>(List<T> list, int seed)
        {
            return list[SeededRandom.Range(0, list.Count, seed)];
        }
        public static int GetRandomSeed()
        {
            return SaveManager.SaveFile.GetCurrentRandomSeed() + Singleton<GlobalTriggerHandler>.Instance.NumTriggersThisBattle;
        }
    }
}
