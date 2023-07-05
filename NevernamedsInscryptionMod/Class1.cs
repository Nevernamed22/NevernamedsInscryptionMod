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
            AbilityManager.BaseGameAbilities.AbilityByID(Ability.GainBattery).Info.canStack = true;
            AbilityManager.BaseGameAbilities.AbilityByID(Ability.QuadrupleBones).Info.canStack = true;
            AbilityManager.BaseGameAbilities.AbilityByID(Ability.DrawRabbits).Info.canStack = true;
            AbilityManager.BaseGameAbilities.AbilityByID(Ability.Loot).Info.canStack = true;

            //Give static cards act 2 art
            CardInfo card = CardManager.BaseGameCards.CardByName("!STATIC!GLITCH");
            card.SetPixelPortrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/staticpixel.png"));

            CardInfo packrat = CardManager.BaseGameCards.CardByName("PackRat");
            packrat.SetPixelPortrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/packrat_pixel.png"));

            CardManager.BaseGameCards.CardByName("BatteryBot").SetExtendedProperty("GBCMycologistFusedVersion", "TechNevernamed SporenergyBot");
            CardManager.BaseGameCards.CardByName("Family").SetExtendedProperty("GBCMycologistFusedVersion", "DeadNevernamed TheSporekers");
            CardManager.BaseGameCards.CardByName("Warren").SetExtendedProperty("GBCMycologistFusedVersion", "BeastNevernamed Sporren");
            CardManager.BaseGameCards.CardByName("MasterOrlu").SetExtendedProperty("GBCMycologistFusedVersion", "WizardNevernamed MasterSporlu");

            //CardManager.BaseGameCards.CardByName("Lice").metaCategories.Add(CardMetaCategory.GBCPlayable);
            //CardManager.BaseGameCards.CardByName("Amalgam").metaCategories.Add(CardMetaCategory.GBCPlayable);

            arachnophobiaMode = base.Config.Bind<bool>("General", "Arachnophobia Mode", false, "Replaces the portraits of spider and spiderlike cards to be less realistic.");

            //HIDDEN ABILITIEs
            CreateCopyOnInsects.Init();
            LiliputianPileup.Init();
            OpposedShifter.Init();
            GrueAttackColourOverride.Init();
            BoardWipe.Init();
            CreateCharredLump.Init();
            ChaosCardBehaviour.Init();
            WizardOfOz.Init();

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
            AxehandleHound.Init();
            Gull.Init();
            WorldTurtle.Init();
            Macrobacterium.Init();
            GiftHorse.Init();
            Kiwi.Init();

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
            YetiCrab.Init();
            Hagfish.Init();

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
            MrNeedlemouth.Init();
            ElectricEel.Init();
            TinMan.Init();
            StageMagician.Init();
            SelflessCell.Init();
            KnightCell.Init();
            BloodKnight.Init();
            Octomancer.Init();
            GlueMage.Init();
            CrimsonPaladin.Init();
            HostileInjector.Init();
            LiveWire.Init();
            StimulantConduit.Init();
            Composer.Init();
            MirrorLord.Init();
            Gristle.Init();
            MotherMatryoshka.Init();
            Tr1ckb0t.Init();
            Hambone.Init();
            EnchantedBlade.Init();
            ShadowChild.Init();
            FalseProphet.Init();
            Handmaster.Init();
            GiftConduit.Init();
            BustedConduit.Init();
            GrimChanter.Init();
            TurtleMine.Init();
            AxeMurderer.Init();
            Energem.Init();
            Recyclotron.Init();
            FileShredder.Init();
            Malbot.Init();
            PupilOfGun.Init();
            Famine.Init();
            Death.Init();
            Boil.Init();
            Pestilence.Init();
            War.Init();
            Mandrake.Init();
            FlankGunner.Init();
            GiantClam.Init();
            FogMachine.Init();
            ShieldMage.Init();
            Turret.Init();
            MysteryGolem.Init();
            Techromancer.Init();
            BloodWitch.Init();
            VortexCaster.Init();
            GrandHighIllusionist.Init();
            Tlamacazqui.Init();
            Techtacles.Init();
            Molly.Init();
            Replicant.Init();
            StandardBearer.Init();
            PracticeSage.Init();
            Mageskull.Init();
            Dowser.Init();
            ClumsyPupil.Init();
            JumperCable.Init();
            Automamox.Init();
            LunarCell.Init();
            GreenArchmage.Init();
            Mourner.Init();
            FrogR.Init();
            GemFrog.Init();
            BloodCell.Init();
            Lockbot.Init();
            Necravager.Init();
            ZombieRaider.Init();
            Drawtomaton.Init();
            Lancer.Init();
            Mandroid.Init();
            ThePunishment.Init();
            BodySnatcher.Init();
            HighCalibre.Init();
            CattleRustler.Init();
            Belladin.Init();
            BindWarden.Init();
            Tim.Init();
            Voltcaster.Init();
            FileSearcher.Init();
            SentryConduit.Init();
            QuillConduit.Init();
            NanoConduit.Init();
            SteamConduit.Init();
            Speyeral.Init();
            MastersBones.Init();
            SpinyCell.Init();
            DiceGoblin.Init();
            SpiritWalker.Init();
            Sibyl.Init();
            IronMaiden.Init();
            BoneCell.Init();
            StimCell.Init();
            InstallationWizard.Init();
            PinnacleMox.Init();
            Skelemagnus.Init();

            //Make clear mox cost later
            MobiusGolem.Init();

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
            CodeThief.Init();
            ShockTrooper.Init();
            Rover.Init();
            DrainDrone.Init();
            ViridescentDroid.Init();
            WildCell.Init();
            Rockette.Init();
            Enginoid.Init();
            Lvl2FactoryConduit.Init();
            Omegear.Init();
            Flammaball.Init();

            //SPORE CARDS
            SporenergyBot.Init();
            Sporren.Init();
            TheSporekers.Init();
            MasterSporlu.Init();

            //GRIMORA CARDS 

            //STARTER DECKS
            StarterDecks.Init();

            //NODES
            //RareSacrifice.Init();



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
                    if (idv.name == "SigilNevernamed MoreFish") { idv.metaCategories.Add(CardMetaCategory.Rare); }

                    
                }

                return cards;
            };

            StartCoroutine(Late());
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
            {"BeastNevernamed Neocarus", "neocarus"},
            {"BeastNevernamed NeocarusTwo", "neocarus"},
            {"BeastNevernamed NeocarusThree", "neocarus"},
            {"BeastNevernamed Macracantha", "macracantha"},
            {"BeastNevernamed MacracanthaBi", "macracantha"},
            {"BeastNevernamed MacracanthaTri", "macracantha"},
            {"BeastNevernamed OrbWeaver", "orbweaver"},
            {"BeastNevernamed SeaSpider", "seaspider"},
            {"BeastNevernamed WhiteTailed", "whitetailed"},
            {"BeastNevernamed WanderingSpider", "wanderingspider"},
            {"BeastNevernamed Bannana", "bannana"},
            {"BeastNevernamed Harvestman", "harvestman"},
            {"BeastNevernamed YellowSacSpider", "yellowsacspider"},
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
        public static IEnumerator Late()
        {
            yield return null;
            List<CardInfo> BeastCards = ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.temple == CardTemple.Nature);
            List<CardInfo> TechCards = ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.temple == CardTemple.Tech);
            List<CardInfo> UndeadCards = ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.temple == CardTemple.Undead);
            List<CardInfo> MoxCards = ScriptableObjectLoader<CardInfo>.AllData.FindAll((CardInfo x) => x.temple == CardTemple.Wizard);

            List<CardInfo> ModBeasts = BeastCards.FindAll((CardInfo x) => x.name.StartsWith("BeastNevernamed"));
            List<CardInfo> ModTech = TechCards.FindAll((CardInfo x) => x.name.StartsWith("TechNevernamed"));
            List<CardInfo> ModUndead = UndeadCards.FindAll((CardInfo x) => x.name.StartsWith("DeadNevernamed"));
            List<CardInfo> ModWizards = MoxCards.FindAll((CardInfo x) => x.name.StartsWith("WizardNevernamed"));

            List<CardInfo> CommonBeasts = BeastCards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.ChoiceNode) || x.metaCategories.Contains(CardMetaCategory.TraderOffer));
            List<CardInfo> CommonModdedBeasts = ModBeasts.FindAll(x => x.metaCategories.Contains(CardMetaCategory.ChoiceNode) || x.metaCategories.Contains(CardMetaCategory.TraderOffer));
            List<CardInfo> RareBeasts = BeastCards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> RareModdedBeasts = ModBeasts.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Rare));

            List<CardInfo> CommonWizards = MoxCards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable) && !x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> CommonModdedWizards = ModWizards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable) && !x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> RareWizards = MoxCards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable) && x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> RareModdedWizards = ModWizards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable) && x.metaCategories.Contains(CardMetaCategory.Rare));

            List<CardInfo> CommonUndead = UndeadCards.FindAll(x => !x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> CommonModdedUndead = ModUndead.FindAll(x => !x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> RareUndead = UndeadCards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> RareModdedUndead = ModUndead.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Rare));

            List<CardInfo> CommonTech = TechCards.FindAll(x => !x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> RareTech = TechCards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> CommonModdedTech = ModTech.FindAll(x => !x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> RareModdedTech = ModTech.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Rare));

            List<CardInfo> CommonTech2 = CommonTech.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable));
            List<CardInfo> RareTech2 = RareTech.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable));
            List<CardInfo> CommonModdedTech2 = CommonModdedTech.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable));
            List<CardInfo> RareModdedTech2 = RareModdedTech.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable));

            List<CardInfo> CommonBeasts2 = BeastCards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable) && !x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> CommonModdedBeasts2 = ModBeasts.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable) && !x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> RareBeasts2 = BeastCards.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable) && x.metaCategories.Contains(CardMetaCategory.Rare));
            List<CardInfo> RareModdedBeasts2 = ModBeasts.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable) && x.metaCategories.Contains(CardMetaCategory.Rare));

            List<CardInfo> CommonTech3 = CommonTech.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Part3Random) || x.metaCategories.Contains(CardMetaCategory.ChoiceNode) || x.metaCategories.Contains(Plugin.P03KayceesBastionRegion) || x.metaCategories.Contains(Plugin.P03KayceesNatureRegion) || x.metaCategories.Contains(Plugin.P03KayceesUndeadRegion) || x.metaCategories.Contains(Plugin.P03KayceesWizardRegion));
            List<CardInfo> RareTech3 = RareTech.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Part3Random) || x.metaCategories.Contains(CardMetaCategory.ChoiceNode) || x.metaCategories.Contains(Plugin.P03KayceesBastionRegion) || x.metaCategories.Contains(Plugin.P03KayceesNatureRegion) || x.metaCategories.Contains(Plugin.P03KayceesUndeadRegion) || x.metaCategories.Contains(Plugin.P03KayceesWizardRegion));
            List<CardInfo> CommonModdedTech3 = CommonModdedTech.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Part3Random) || x.metaCategories.Contains(CardMetaCategory.ChoiceNode) || x.metaCategories.Contains(Plugin.P03KayceesBastionRegion) || x.metaCategories.Contains(Plugin.P03KayceesNatureRegion) || x.metaCategories.Contains(Plugin.P03KayceesUndeadRegion) || x.metaCategories.Contains(Plugin.P03KayceesWizardRegion));
            List<CardInfo> RareModdedTech3 = RareModdedTech.FindAll(x => x.metaCategories.Contains(CardMetaCategory.Part3Random) || x.metaCategories.Contains(CardMetaCategory.ChoiceNode) || x.metaCategories.Contains(Plugin.P03KayceesBastionRegion) || x.metaCategories.Contains(Plugin.P03KayceesNatureRegion) || x.metaCategories.Contains(Plugin.P03KayceesUndeadRegion) || x.metaCategories.Contains(Plugin.P03KayceesWizardRegion));

            Debug.Log($"All Cards Total: {ModBeasts.Count + ModTech.Count + ModUndead.Count + ModWizards.Count}/{BeastCards.Count + TechCards.Count + UndeadCards.Count + MoxCards.Count}");

            Debug.Log($"BeastNevernamed Cards Total: {ModBeasts.Count}/{BeastCards.Count}\n");
            Debug.Log($"    Act 1 Total: Common({CommonModdedBeasts.Count}/{CommonBeasts.Count}) Rare({RareModdedBeasts.Count}/{RareBeasts.Count}) All({CommonModdedBeasts.Count + RareModdedBeasts.Count}/{CommonBeasts.Count + RareBeasts.Count})");
            PrintForTribe("Canine", Tribe.Canine, CommonBeasts, RareBeasts, CommonModdedBeasts, RareModdedBeasts);
            PrintForTribe("Bird", Tribe.Bird, CommonBeasts, RareBeasts, CommonModdedBeasts, RareModdedBeasts);
            PrintForTribe("Reptile", Tribe.Reptile, CommonBeasts, RareBeasts, CommonModdedBeasts, RareModdedBeasts);
            PrintForTribe("Hooved", Tribe.Hooved, CommonBeasts, RareBeasts, CommonModdedBeasts, RareModdedBeasts);
            PrintForTribe("Insect", Tribe.Insect, CommonBeasts, RareBeasts, CommonModdedBeasts, RareModdedBeasts);
            PrintForTribe("Squirrel", Tribe.Squirrel, CommonBeasts, RareBeasts, CommonModdedBeasts, RareModdedBeasts);
            PrintForTribe("Arachnid", NevernamedsTribes.Arachnid, CommonBeasts, RareBeasts, CommonModdedBeasts, RareModdedBeasts);
            PrintForTribe("Crustacean", NevernamedsTribes.Crustacean, CommonBeasts, RareBeasts, CommonModdedBeasts, RareModdedBeasts);
            PrintForTribe("Rodent", NevernamedsTribes.Rodent, CommonBeasts, RareBeasts, CommonModdedBeasts, RareModdedBeasts);
            Debug.Log($"        Untribed: Common ({CommonModdedBeasts.FindAll(x => x.tribes.Count == 0).Count}/{CommonBeasts.FindAll(x => x.tribes.Count == 0).Count}) Rare ({RareModdedBeasts.FindAll(x => x.tribes.Count == 0).Count}/{RareBeasts.FindAll(x => x.tribes.Count == 0).Count}) All ({CommonModdedBeasts.FindAll(x => x.tribes.Count == 0).Count + RareModdedBeasts.FindAll(x => x.tribes.Count == 0).Count}/{CommonBeasts.FindAll(x => x.tribes.Count == 0).Count + RareBeasts.FindAll(x => x.tribes.Count == 0).Count})\n");
            Debug.Log($"    Act 2 Total: Common({CommonModdedBeasts2.Count}/{CommonBeasts2.Count}) Rare({RareModdedBeasts2.Count}/{RareBeasts2.Count}) All({CommonModdedBeasts2.Count + RareModdedBeasts2.Count}/{CommonBeasts2.Count + RareBeasts2.Count})");

            Debug.Log($"----------------------------------------------------------------");

            Debug.Log($"TechNevernamed Cards Total: {ModTech.Count}/{TechCards.Count}\n");
            Debug.Log($"    Act 2 Total: Common ({CommonModdedTech2.Count}/{CommonTech2.Count}) Rare ({RareModdedTech2.Count}/{RareTech2.Count}) All({CommonModdedTech2.Count + RareModdedTech2.Count}/{CommonTech2.Count + RareTech2.Count})");
            Debug.Log($"    Act 3 Total: Common ({CommonModdedTech3.Count}/{CommonTech3.Count}) Rare ({RareModdedTech3.Count}/{RareTech3.Count}) All({CommonModdedTech3.Count + RareModdedTech3.Count}/{CommonTech3.Count + RareTech3.Count})");
            Debug.Log($"----------------------------------------------------------------");

            Debug.Log($"DeadNevernamed Cards Total: {ModUndead.Count}/{UndeadCards.Count}\n");
            Debug.Log($"    Act 2 Total: Common({CommonModdedUndead.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable)).Count}/{CommonUndead.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable)).Count}) Rare({RareModdedUndead.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable)).Count}/{RareUndead.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable)).Count}) All({CommonModdedUndead.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable)).Count + RareModdedUndead.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable)).Count}/{CommonUndead.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable)).Count + RareUndead.FindAll(x => x.metaCategories.Contains(CardMetaCategory.GBCPlayable)).Count})");
            Debug.Log($"    Grimoramod Total: Common({CommonModdedUndead.FindAll(x => x.metaCategories.Contains(GrimoraChoiceNode)).Count}/{CommonUndead.FindAll(x => x.metaCategories.Contains(GrimoraChoiceNode)).Count}) Rare({RareModdedUndead.FindAll(x => x.metaCategories.Contains(GrimoraChoiceNode)).Count}/{RareUndead.FindAll(x => x.metaCategories.Contains(GrimoraChoiceNode)).Count}) All({CommonModdedUndead.FindAll(x => x.metaCategories.Contains(GrimoraChoiceNode)).Count + RareModdedUndead.FindAll(x => x.metaCategories.Contains(GrimoraChoiceNode)).Count}/{CommonUndead.FindAll(x => x.metaCategories.Contains(GrimoraChoiceNode)).Count + RareUndead.FindAll(x => x.metaCategories.Contains(GrimoraChoiceNode)).Count})");
            Debug.Log($"----------------------------------------------------------------");

            Debug.Log($"WizardNevernamed Cards Total: {ModWizards.Count}/{MoxCards.Count}\n");
            Debug.Log($"    Act 2 Total: Common({CommonModdedWizards.Count}/{CommonWizards.Count}) Rare({RareModdedWizards.Count}/{RareWizards.Count}) All({CommonModdedWizards.Count + RareModdedWizards.Count}/{CommonWizards.Count + RareWizards.Count})");
            Debug.Log($"        Free: Common({CommonModdedWizards.FindAll(x => x.gemsCost.Count == 0).Count}/{CommonWizards.FindAll(x => x.gemsCost.Count == 0).Count}) Rare({RareModdedWizards.FindAll(x => x.gemsCost.Count == 0).Count}/{RareWizards.FindAll(x => x.gemsCost.Count == 0).Count})");
            Debug.Log($"        Blue: Common({CommonModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Blue })).Count}/{CommonWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Blue })).Count}) Rare({RareModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Blue })).Count}/{RareWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Blue })).Count})");
            Debug.Log($"        Green: Common({CommonModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Green })).Count}/{CommonWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Green })).Count}) Rare({RareModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Green })).Count}/{RareWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Green })).Count})");
            Debug.Log($"        Orange: Common({CommonModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange })).Count}/{CommonWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange })).Count}) Rare({RareModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange })).Count}/{RareWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange })).Count})");
            Debug.Log($"        Blue/Green: Common({CommonModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Blue, GemType.Green })).Count}/{CommonWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Blue, GemType.Green })).Count}) Rare({RareModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Blue, GemType.Green })).Count}/{RareWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Blue, GemType.Green })).Count})");
            Debug.Log($"        Green/Orange: Common({CommonModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Green })).Count}/{CommonWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Green })).Count}) Rare({RareModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Green })).Count}/{RareWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Green })).Count})");
            Debug.Log($"        Green/Blue: Common({CommonModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Blue })).Count}/{CommonWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Blue })).Count}) Rare({RareModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Blue })).Count}/{RareWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Blue })).Count})");
            Debug.Log($"        All Mox: Common({CommonModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Blue, GemType.Green })).Count}/{CommonWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Blue, GemType.Green })).Count}) Rare({RareModdedWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Blue, GemType.Green })).Count}/{RareWizards.FindAll(x => isJustGems(x, new List<GemType>() { GemType.Orange, GemType.Blue, GemType.Green })).Count})");


            yield break;
        }
        public static void PrintForTribe(string name, Tribe tribe, List<CardInfo> commons, List<CardInfo> rares, List<CardInfo> moddedcommons, List<CardInfo> moddedrares)
        {
            Debug.Log($"        {name}: Common ({moddedcommons.FindAll(x => x.IsOfTribe(tribe)).Count}/{commons.FindAll(x => x.IsOfTribe(tribe)).Count}) Rare ({moddedrares.FindAll(x => x.IsOfTribe(tribe)).Count}/{rares.FindAll(x => x.IsOfTribe(tribe)).Count}) All ({moddedcommons.FindAll(x => x.IsOfTribe(tribe)).Count + moddedrares.FindAll(x => x.IsOfTribe(tribe)).Count}/{commons.FindAll(x => x.IsOfTribe(tribe)).Count + rares.FindAll(x => x.IsOfTribe(tribe)).Count})");
        }
        public static bool isJustGems(CardInfo inf, List<GemType> gems)
        {
            bool inconsistency = true;
            if (gems.Contains(GemType.Blue) != inf.gemsCost.Contains(GemType.Blue)) { inconsistency = false; }
            if (gems.Contains(GemType.Green) != inf.gemsCost.Contains(GemType.Green)) { inconsistency = false; }
            if (gems.Contains(GemType.Orange) != inf.gemsCost.Contains(GemType.Orange)) { inconsistency = false; }
            return inconsistency;
        }
        internal static ConfigEntry<bool> arachnophobiaMode;

        //P03Kaycees
        public static readonly CardMetaCategory P03KayceesWizardRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "WizardRegionCards");
        public static readonly CardMetaCategory P03KayceesBastionRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "TechRegionCards");
        public static readonly CardMetaCategory P03KayceesNatureRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "NatureRegionCards");
        public static readonly CardMetaCategory P03KayceesUndeadRegion = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "UndeadRegionCards");
        public static readonly CardMetaCategory P03KayceesNeutralRegion = GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.p03kayceerun", "NeutralRegionCards");

        //Act2Endless
        public static readonly CardMetaCategory ExcludeFromAct2Endless = (CardMetaCategory)GuidManager.GetEnumValue<CardMetaCategory>("mrfantastik.inscryption.infact2", "ExcludeFromAct2Endless");

        //Grimora
        public static readonly CardMetaCategory GrimoraChoiceNode = GuidManager.GetEnumValue<CardMetaCategory>("arackulele.inscryption.grimoramod", "GrimoraModChoiceNode");
    }
}