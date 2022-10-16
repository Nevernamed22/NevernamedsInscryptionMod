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
using Infiniscryption.PackManagement;

namespace NevernamedsInscryptionMod
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency("cyantist.inscryption.api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("nevernamed.inscryption.sigils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("zorro.inscryption.infiniscryption.packmanager", BepInDependency.DependencyFlags.HardDependency)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PluginGuid = "nevernamedscustominscryptioncards";
        private const string PluginName = "Nevernamed's Deck";
        private const string PluginVersion = "1.0.0.0";
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


            //HIDDEN ABILITIEs
            CreateCopyOnInsects.Init();
            LiliputianPileup.Init();
            OpposedShifter.Init();
            GrueAttackColourOverride.Init();
            BoardWipe.Init();
            CreateCharredLump.Init();

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
            Dolphin.Init();
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
            }

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

            //ACT 3 EXCLUSIVE CARDS
            Crusher.Init();
            Undertecher.Init();
            Shieldrone.Init();
            Omnibot.Init();

            //STARTER DECKS
            StarterDecks.Init();

            //NODES
            //RareSacrifice.Init();

            PackInfo incrediPack = PackManager.GetPackInfo("Nevernamed");
            incrediPack.Title = "Nevernamed's Bestiary";
            incrediPack.SetTexture(Tools.LoadTex("NevernamedsInscryptionMod/Resources/Other/packicon.png"));
            incrediPack.Description = "A collection of all things wise and wonderful, all creatures great and small- all trapped within the paper of a card.";
            incrediPack.ValidFor.Add(PackInfo.PackMetacategory.LeshyPack);

        }
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

        public static readonly CardMetaCategory P03KayceesWizardRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "WizardRegionCards");
        public static readonly CardMetaCategory P03KayceesBastionRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "TechRegionCards");
        public static readonly CardMetaCategory P03KayceesNatureRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "NatureRegionCards");
        public static readonly CardMetaCategory P03KayceesUndeadRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "UndeadRegionCards");

    }
}