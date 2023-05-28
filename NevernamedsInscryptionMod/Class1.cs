using System;
using BepInEx;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using DiskCardGame;
using UnityEngine;
using APIPlugin;
using HarmonyLib;
using System.Reflection;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using NevernamedsSigils;
using BepInEx.Bootstrap;
using BepInEx.Configuration;

namespace NevernamedsInscryptionMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("nevernamed.inscryption.sigils", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "nevernamedscustominscryptioncards";
        private const string PluginName = "Nevernamed's Deck";
        private const string PluginVersion = "1.3.0.0";
        public static Texture2D signaturetex;
        public static Texture2D raresignaturetex;


        public static AssetBundle bundle;
        private void Awake()
        {
            bundle = LoadBundle("NevernamedsInscryptionMod/Resources/TalkingCards/nnscryptionbundle");

            Logger.LogInfo($"Loaded {PluginName}!");
            Harmony harmony = new Harmony("nevernamedscustominscryptioncards.harmonypatcher");
            harmony.PatchAll();

            signaturetex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/signature.png");
            raresignaturetex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/signaturerare.png");

            //Talking Card Faces

            //Make certain sigils stackable
            AbilityManager.BaseGameAbilities.AbilityByID(Ability.LatchBrittle).Info.canStack = true;

            //Give static cards act 2 art
            CardInfo card = CardManager.BaseGameCards.CardByName("!STATIC!GLITCH");
            card.SetPixelPortrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/staticpixel.png"));

            CardInfo packrat = CardManager.BaseGameCards.CardByName("PackRat");
            packrat.SetPixelPortrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/packrat_pixel.png"));

            // CardManager.BaseGameCards.CardByName("SentinelOrange").metaCategories.Add(CardMetaCategory.GBCPlayable);

            arachnophobiaMode = base.Config.Bind<bool>("General", "Arachnophobia Mode", false, "Replaces the portraits of spider and spiderlike cards to be less realistic.");

            //HIDDEN ABILITIEs
            CreateCopyOnInsects.Init();
            LiliputianPileup.Init();
            OpposedShifter.Init();
            GrueAttackColourOverride.Init();
            BoardWipe.Init();
            CreateCharredLump.Init();
            ChaosCardBehaviour.Init();

            //stuff and shit
            //OBELISKS
            BlankObelisk.Init();
            SquirrelObelisk.Init();
            MendingObelisk.Init();

            //MIXED CARDS
            PoppingToad.Init();
            BeachedWhale.Init();
            ExplodingAnt.Init();
            AntLarva.Init();
            Copycat.Init();
            Finch.Init();
            Whippoorwill.Init();
            Earthworm.Init();
            VelvetWorm.Init();
            Nematode.Init();
            Marmot.Init();
            TeWheke.Init();
            Cobra.Init();
            KingCobra.Init();
            Capybara.Init();
            Leech.Init();
            DeBug.Init();
            BloatedLeech.Init();
            Mayfly.Init();
            Goose.Init();
            Silkworm.Init();
            Dodo.Init();
            Bugbear.Init();
            Octopus.Init();
            BlindMouse.Init();
            RabidDog.Init();
            Impossibeast.Init();
            Monarch.Init();
            Salamander.Init();
            GreenFang.Init();
            WildBoar.Init();
            Basilisk.Init();
            TrapjawAnt.Init();
            BobbitWorm.Init();
            CursedChild.Init();
            ToothBug.Init();
            JumpingSpider.Init();
            Phouka.Init();
            Brollachan.Init();
            Taurobolium.Init();
            Spambot.Init();
            LoneWolf.Init();
            CamelSpider.Init();
            Mistake.Init();
            Chupacabra.Init();
            Scarab.Init();
            Khepri.Init();
            Huntaway.Init();
            Parrot.Init();
            Karkinos.Init();
            TasmanianDevil.Init();
            ReEm.Init();
            Ladybug.Init();
            Areion.Init();
            Bison.Init();
            Dermestid.Init();
            Huntsman.Init();
            Springbok.Init();
            Crayfish.Init();
            CowardlyLion.Init();

            //ACT 1 EXCLUSIVE CARDS
            TheBlob.Init();
            DeerGod.Init();
            Skinwalker.Init();
            BlueRinged.Init();
            Stonefish.Init();
            SelkieSkin.Init();
            BlindScorpion.Init();
            ThornedCordyceps.Init();
            VisceraTentacle.Init();
            Dhole.Init();
            DudEgg.Init();
            NightMare.Init();
            NightmareFuel.Init();
            Frid.Init();
            Urchin.Init();
            OrbWeaver.Init();
            Barnacle.Init();
            Pygarg.Init();
            SpectralTarsier.Init();
            YaraMaYhaWho.Init();
            ManTis.Init();
            Anansi.Init();
            Gadreel.Init();
            Gnat.Init();
            RhinoBeetle.Init();
            BlackDog.Init();
            Boneworm.Init();
            CarrionFly.Init();
            Pig.Init();
            StarnosedMole.Init();
            BlackGiantSquirrel.Init();
            Empusa.Init();
            BoardTentacle.Init();
            Scylla.Init();
            Bakunawa.Init();
            Kokyangwuti.Init();
            TheFlesh.Init();
            Antlion.Init();
            CactusAnt.Init();
            NoEyeDeer.Init();
            DyingSpider.Init();
            ExplodingBunny.Init();
            Lion.Init();
            BrownRecluse.Init();
            TermiteQueen.Init();
            TermiteKingCard.Init();
            Starling.Init();
            Jackal.Init();
            Isopod.Init();
            Mealybug.Init();
            TitanicIsopod.Init();
            LittleBlue.Init();
            Dingo.Init();
            Dormouse.Init();
            CellarSpider.Init();
            Grue.Init();
            Emmet.Init();
            SnakeEyes.Init();
            Hallucigenia.Init();
            CrabSpider.Init();
            TurtleDove.Init();
            LengSpider.Init();
            Mugwump.Init();
            WhiteTailed.Init();
            DikDik.Init();
            ThickLizard.Init();
            Tick.Init();
            AlligatorGar.Init();
            Fangtooth.Init();
            Pufferfish.Init();
            StarvedRat.Init();
            Myrmecoleon.Init();
            Locust.Init();
            FeatherlessBiped.Init();
            BaldEagle.Init();
            Blowfly.Init();
            FlyingFish.Init();
            Macracantha.Init();
            Popweasel.Init();
            MauiDolphin.Init();
            EagerHatcling.Init();
            SandDollar.Init();
            Nidhoggr.Init();
            RedCard.Init();
            Handragora.Init();
            GiantEarthworm.Init();
            DireRat.Init();
            MoleLizard.Init();
            Moeraki.Init();
            Fantail.Init();
            Harvestman.Init();
            Squidge.Init();
            Albatross.Init();
            AlbatrossChick.Init();
            ThornyDevil.Init();
            FauxDeathcards.Init();
            AderynYCorph.Init();
            RedPanda.Init();
            GiftSpider.Init();
            Gruagach.Init();
            Wishpoosh.Init();
            SeaSpider.Init();
            CanopicHawk.Init();
            AnnoyingDog.Init();
            HiveCrawler.Init();
            Biscione.Init();
            Niao.Init();
            BlackWidow.Init();
            Bowerbird.Init();
            Talbot.Init();
            BloodRedDog.Init();
            BombardierBeetle.Init();
            HotDog.Init();
            Labrats.Init();
            Ararach.Init();
            HeartOfHarts.Init();
            Charybdis.Init();
            ThePack.Init();
            BloodWolf.Init();
            InfectedAnt.Init();
            Macaque.Init();
            Glochidium.Init();
            ConeSnail.Init();
            WhipWorm.Init();
            RedMite.Init();
            Trapezia.Init();
            MayflySwarm.Init();
            Jorogumo.Init();
            CagedBeasts.Init();
            ColossalSquid.Init();
            Masok.Init();
            Vodyanoy.Init();
            Oddfang.Init();
            DiseasedCur.Init();
            BlastTermite.Init();
            ScaleTick.Init();
            CharredLump.Init();
            Kuchipatchi.Init();
            Wyrm.Init();
            Deepstaria.Init();
            LeafcutterAnt.Init();
            DireBeaver.Init();
            Antingaw.Init();
            PeaCrab.Init();
            BrineShrimp.Init();
            Hippopotamus.Init();
            Cow.Init();
            Anemone.Init();
            BoneClutter.Init();
            Hyena.Init();
            EarlyBird.Init();
            Livyatan.Init();
            Warg.Init();
            ParrotFish.Init();
            Fjalar.Init();
            Gullinkambi.Init();
            BeastOfExmoor.Init();
            WhirlingWhimpus.Init();
            Helhest.Init();
            GhostNudi.Init();
            Cockle.Init();
            Coral.Init();
            Chicken.Init();
            Aspidochelone.Init();
            Hammerkop.Init();
            Sphinx.Init();
            Gibbon.Init();
            Hafgufa.Init();
            Neocarus.Init();
            Megaladaptis.Init();
            Goldfinch.Init();
            GoldenCalf.Init();
            SpiderMonkey.Init();
            FrogCrab.Init();
            Ibis.Init();
            Minokawa.Init();
            Terrashot.Init();
            Hugag.Init();
            Crucibulum.Init();
            Roperite.Init();
            Wapaloosie.Init();
            StrangeTurtle.Init();
            Balaur.Init();
            Zmeu.Init();
            Shagamaw.Init();
            Lemur.Init();
            Pachylemur.Init();
            CactusCat.Init();
            Snoligoster.Init();
            MoleCrab.Init();
            Loris.Init();
            Peccary.Init();
            KillerBeehive.Init();
            WanderingSpider.Init();
            BatBomb.Init();
            ItemTentacle.Init();
            Bluebottle.Init();
            Buzzard.Init();
            MethuselahMouse.Init();
            Bolotnik.Init();
            Calygreyhound.Init();
            Bandito.Init();
            Skua.Init();
            Candiru.Init();
            DungBeetle.Init();
            Shrimp.Init();
            Prawn.Init();
            Lobster.Init();
            Sandhopper.Init();
            LittleMiss.Init();
            ItsyBitsy.Init();
            GastricBrooder.Init();
            Archerfish.Init();
            DraculaAnt.Init();
            VampireBat.Init();
            BlueWhale.Init();
            WhiteWhale.Init();
            Changeling.Init();
            AmorphousShame.Init();
            FetchCard.Init();
            ChaosCard.Init();
            BlackEgg.Init();
            TummyBug.Init();            
            SeaLouse.Init();
            Ahuizotl.Init();
            Mongoose.Init();
            Krill.Init();
            Gorilla.Init();
            Chimpanzee.Init();
            Piure.Init();
            Sicarius.Init();
            WastingDeer.Init();

            //ACT 1 ENERGY COST CARDS
            Blockhead.Init();
            YellowSacSpider.Init();
            EggSac.Init();
            Fennec.Init();
            Minnow.Init();
            LionsManeJelly.Init();
            Moa.Init();
            WildHare.Init();
            Puffin.Init();
            Crab.Init();
            Hummingbird.Init();
            Leatherback.Init();
            Woodpecker.Init();
            MantaRay.Init();
            Bannana.Init();
            AngelShark.Init();
            FishingCat.Init();
            Batfly.Init();
            Camazotz.Init();
            Anaconda.Init();
            DynaMite.Init();
            Chameleon.Init();
            Deathstalker.Init();
            Theow.Init();
            SunWukong.Init();
            PrarieDog.Init();
            Dove.Init();
            Takahe.Init();
            Bellbird.Init();
            BlackKite.Init();
            Darter.Init();
            Pidgeon.Init();
            Chuman.Init();
            SeaNettle.Init();
            Hogfish.Init();
            Scapegoat.Init();
            Gazelle.Init();
            StuntedGrizzly.Init();
            BoxJelly.Init();
            DropBear.Init();
            MoonJelly.Init();
            Copepod.Init();
            Anteater.Init();
            Cowbird.Init();
            Dolphin.Init();
            Tapeworm.Init();
            Tarantula.Init();
            Kusimanse.Init();

            //ACT 1 TALKING CARDS
            if (bundle != null)
            {
                PallasNoctua.Init();
                DecoratorCrab.Init();
                CustomStoat.Init();
                CustomStinkbug.Init();
                CustomStuntedWolf.Init();
                Cyclops.Init();
                Husky.Init();
                Woodmouse.Init();
                BrazenBull.Init();
                HappyFaceSpider.Init();
            }

            //ACT 2 TALKING CARDS
            Keepers.Init();

            //ACT 2 EXCLUSIVE CARDS
            TheBlobAct2.Init();
            Firelight.Init();
            Ziburinis.Init();
            DentalMage.Init();
            GoreyGirl.Init();
            TheGoodDoctor.Init();
            CrystalHealer.Init();
            CamDrone.Init();
            BatTery.Init();
            MagicTrap.Init();
            Gembrain.Init();
            EnergyCube.Init();
            CrookedWraith.Init();
            BustedBot.Init();
            CapybaraAct2.Init();
            Sluagh.Init();
            Hypermage.Init();
            RenegadeSorcerer.Init();
            Mermage.Init();
            Photocopier.Init();
            Nanomachines.Init();
            ChaosEngine.Init();
            QT.Init();
            LuckyCoin.Init();
            MagicBag.Init();
            FearGorta.Init();
            SmiteMage.Init();
            DeathsDoor.Init();
            LiliputianSkeleton.Init();
            Chochin.Init();
            Wight.Init();
            StrikeDrone.Init();
            Bishop.Init();
            Rook.Init();
            Wiztank.Init();
            Cremator.Init();
            Dozer.Init();
            PidgeonBot.Init();
            Trenchfoot.Init();
            Oz.Init();
            Scarecrow.Init();
            IIEyes.Init();
            MorphMage.Init();
            Moxcrafter.Init();
            Professor.Init();
            Druid.Init();
            RageMage.Init();
            MoleMage.Init();
            H4wk.Init();
            Counstabot.Init();
            Flammenwarlock.Init();
            Helidrone.Init();
            Sparky.Init();
            VesselLord.Init();
            Foddroid.Init();
            VesselBall.Init();
            RedCap.Init();
            Jikininki.Init();
            Talos.Init();
            Enchantress.Init();
            Trojan.Init();
            Bellbot.Init();
            Nosferat.Init();
            Bhoot.Init();
            Adipocere.Init();
            BloodySack.Init();
            PrototypeGiftbot.Init();
            AceLord.Init();
            PincerMage.Init();
            Conjurer.Init();
            Dicebot.Init();
            PortalMage.Init();
            Necrophidius.Init();
            DrClaphamLee.Init();
            SanguineSlime.Init();
            Yorick.Init();
            Pishacha.Init();
            PalidOoze.Init();
            Forevenant.Init();
            Vila.Init();
            Viscount.Init();
            Suangi.Init();
            Shtriga.Init();
            Mavka.Init();
            Vrykolakas.Init();
            Pricolici.Init();
            MagicHat.Init();
            Pawn.Init();
            Tallock.Init();
            Babai.Init();
            Lobasta.Init();
            Strigoi.Init();
            ChickenBones.Init();
            ChiralCrawler.Init();
            Vodyanitsa.Init();
            ZhaleznyChalavek.Init();
            Cubit.Init();
            GolemArm.Init();
            FisherMage.Init();
            Kodoku.Init();
            Nixie.Init();
            TestGhost.Init();
            SpoonBender.Init();
            MagisterGeneral.Init();
            Merle.Init();
            Diviner.Init();
            GoblinMage.Init();
            FleshPillar.Init();
            WhiteMage.Init();
            Jester.Init();
            EsotericMox.Init();
            SurgemMagister.Init();
            ArtfulMagister.Init();
            MagnusMagister.Init();
            Catron.Init();
            RitualFlesh.Init();
            SorcerersApprentice.Init();
            WickedWitch.Init();
            Vaconda.Init();
            WonderousWall.Init();
            Clanklion.Init();
            Witchfinder.Init();
            Bloodbag.Init();
            Jumpscare.Init();
            Ghost.Init();
            GhostTrain.Init();
            HodgePodge.Init();
            Unravelled.Init();
            P4kBot.Init();

            //ACT 3 EXCLUSIVE CARDS
            Crusher.Init();
            Undertecher.Init();
            Shieldrone.Init();
            Omnibot.Init();
            Reavance.Init();
            Growbot.Init();
            Balloondroid.Init();
            LazySusan.Init();
            RemoteBot.Init();
            PylonBot.Init();
            TripleGunner.Init();
            MiniModulo.Init();
            ToyRobot.Init();
            Scoopy.Init();
            DocBuzz.Init();
            CatalogueKeeper.Init();
            Energunner.Init();
            Sc0rp10.Init();
            Submachine.Init();
            Magnetick.Init();
            Orbot.Init();
            TestDummy.Init();
            BotPrinter.Init();

            //GRIMORA CARDS

            //STARTER DECKS
            StarterDecks.Init();

            //NODES
            //RareSacrifice.Init();



            Debug.Log($"BeastNevernamed Cards: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed")).Count}");
            Debug.Log($"    Canine: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed") && x.tribes.Contains(Tribe.Canine)).Count} / {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.tribes.Contains(Tribe.Canine)).Count}");
            Debug.Log($"    Avian: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed") && x.tribes.Contains(Tribe.Bird)).Count} / {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.tribes.Contains(Tribe.Bird)).Count}");
            Debug.Log($"    Reptile: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed") && x.tribes.Contains(Tribe.Reptile)).Count} / {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.tribes.Contains(Tribe.Reptile)).Count}");
            Debug.Log($"    Hooved: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed") && x.tribes.Contains(Tribe.Hooved)).Count} / {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.tribes.Contains(Tribe.Hooved)).Count}");
            Debug.Log($"    Insect: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed") && x.tribes.Contains(Tribe.Insect)).Count} / {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.tribes.Contains(Tribe.Insect)).Count}");
            Debug.Log($"    Arachnid: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed") && x.tribes.Contains(NevernamedsTribes.Arachnid)).Count} / {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.tribes.Contains(NevernamedsTribes.Arachnid)).Count}");
            Debug.Log($"    Crustacean: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed") && x.tribes.Contains(NevernamedsTribes.Crustacean)).Count} / {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.tribes.Contains(NevernamedsTribes.Crustacean)).Count}");
            Debug.Log($"    Rodent: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed") && x.tribes.Contains(NevernamedsTribes.Rodent)).Count} / {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.tribes.Contains(NevernamedsTribes.Rodent)).Count}");
            Debug.Log($"    None: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed") && x.tribes.Count == 0).Count} / {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.tribes.Count == 0 && x.temple == CardTemple.Nature).Count}");
            Debug.Log($"TechNevernamed Cards: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("TechNevernamed")).Count}");
            Debug.Log($"    With Act 3 Art: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("TechNevernamed") && x.portraitTex != null).Count}");
            Debug.Log($"DeadNevernamed Cards: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("DeadNevernamed")).Count}");
            Debug.Log($"WizardNevernamed Cards: {ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("WizardNevernamed")).Count}");
            List<CardInfo> genInfos = ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.name.StartsWith("Nevernamed"));
            Debug.Log($"Nevernamed Cards: {genInfos.Count}");
            foreach (CardInfo inf in genInfos)
            {
                Debug.Log(inf.name);
            }

            CardManager.ModifyCardList += delegate (List<CardInfo> cards)
            {
                if (Plugin.arachnophobiaMode.Value == true)
                {
                    Debug.Log("Arachnophobia Mode Enabled: Modifying Spider Portraits");
                    foreach (CardInfo idv in cards.FindAll(x => arachnophobiaModifications.ContainsKey(x.name)))
                    {
                        idv.ArachnophobiaMode(arachnophobiaModifications[idv.name]);
                    }
                }
                foreach (CardInfo idv in cards)
                { 
                    if (card.name == "SigilNevernamed MoreFish") { card.metaCategories.Add(CardMetaCategory.Rare); }
                }
                    return cards;
            };
        }
        public static Dictionary<string, string> arachnophobiaModifications = new Dictionary<string, string>()
        {
            {"BeastNevernamed Anansi", "anansi"},
            {"BeastNevernamed Ararach", "ararach"},
            {"BeastNevernamed BlackWidow", "blackwidow"},
            {"BeastNevernamed BrownRecluse", "brownrecluse"},
            {"BeastNevernamed Bugbear", "bugbear"},
            {"BeastNevernamed CamelSpider", "camelspider"},
            {"BeastNevernamed CellarSpider", "cellarspider"},
            {"BeastNevernamed CrabSpider", "crabspider"},
            {"BeastNevernamed CrayfishDuo", "crayfish"},
            {"BeastNevernamed CrayfishBi", "crayfish"},
            {"BeastNevernamed Deathstalker", "deathstalker"},
            {"BeastNevernamed DyingSpider", "dyingspider"},
            {"BeastNevernamed Emmet", "emmet"},
            {"BeastNevernamed GiftSpider", "giftspider"},
            {"BeastNevernamed Huntsman", "huntsman"},
            {"BeastNevernamed Isopod", "isopod"},
            {"BeastNevernamed ItsyBitsy", "itsybitsy"},
            {"BeastNevernamed Jorogumo", "jorogumo"},
            {"BeastNevernamed JumpingSpider", "jumpingspider"},
            {"BeastNevernamed Kokyangwuti", "kokyangwuti"},
            {"BeastNevernamed LengSpider", "lengspider"},
            {"BeastNevernamed LittleMiss", "littlemiss"},
            {"BeastNevernamed Tarantula", "tarantula"},
            {"BeastNevernamed Sicarius", "sicarius"},
            {"BeastNevernamed SicariusBuried", "sicariusburied"},
        };
        public static Dictionary<string, string> arachnophobiaModificationsPixel = new Dictionary<string, string>()
        {
            {"BeastNevernamed CrayfishDuo", "crayfish"},
            {"BeastNevernamed CrayfishBi", "crayfish"},
            {"BeastNevernamed DyingSpider", "dyingspider"},
            {"BeastNevernamed Huntsman", "huntsman"},
        };
        public static AssetBundle LoadBundle(string path)
        {
            using (Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream(path.Replace("\\", ".").Replace("/", ".")))
            {
                return AssetBundle.LoadFromStream(s);
            }
        }
        private void Start()
        {
            //Encounters
            //SetupCustomEncounters.Init();

        }
        internal static ConfigEntry<bool> arachnophobiaMode;

        //P03Kaycees
        public static readonly CardMetaCategory P03KayceesWizardRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "WizardRegionCards");
        public static readonly CardMetaCategory P03KayceesBastionRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "TechRegionCards");
        public static readonly CardMetaCategory P03KayceesNatureRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "NatureRegionCards");
        public static readonly CardMetaCategory P03KayceesUndeadRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "UndeadRegionCards");
     
        //Act2Endless
        public static readonly CardMetaCategory ExcludeFromAct2Endless = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("mrfantastik.inscryption.infact2", "ExcludeFromAct2Endless");

        //Grimora
        public static readonly CardMetaCategory GrimoraChoiceNode = GuidManager.GetEnumValue<CardMetaCategory>("arackulele.inscryption.grimoramod", "GrimoraModChoiceNode");
    }
}