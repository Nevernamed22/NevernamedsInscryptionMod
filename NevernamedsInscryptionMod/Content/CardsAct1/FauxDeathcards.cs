using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{   
    static class FauxDeathcards
    {
        public static void Init()
        {

            CardSetupUtility.NewCard("Nevernamed FauxKaycee",
                "Kaycee",
                1,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 1,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/kaycee.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dc_kaycee_pixel.png"),
                abilities: new List<Ability>() { Ability.SplitStrike, Ability.Sharp, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxReginald",
                "Reginald",
                1,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/reginald.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dc_reginald_pixel.png"),
                abilities: new List<Ability>() { Ability.Deathtouch, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxLouis",
                "Louis",
                1,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 1,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/louis.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dc_louis_pixel.png"),
                abilities: new List<Ability>() { Ability.Strafe, Ability.Submerge, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxKaminski",
                "Kaminski",
                0,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bonesCost: 1,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/kaminski.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dc_kaminski_pixel.png"),
                abilities: new List<Ability>() { Ability.GuardDog, Ability.Sharp, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxJonah",
                "Jonah",
                2,
                5,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/jonah.png"),
                abilities: new List<Ability>() { Ability.BeesOnHit, Ability.Sharp, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxKevin",
                "Kevin",
                2,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/kevin.png"),
                abilities: new List<Ability>() { Ability.StrafeSwap, Ability.TailOnHit, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxSean",
                "Sean",
                1,
                6,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/sean.png"),
                abilities: new List<Ability>() { Ability.Reach, Ability.Deathtouch, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxTamara",
                "Tamara",
                2,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/tamara.png"),
                abilities: new List<Ability>() { Ability.StrafePush, Ability.TailOnHit, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxDaniel",
                "Daniel",
                2,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/daniel.png"),
                abilities: new List<Ability>() { Ability.DoubleStrike, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxCody",
                "Cody",
                3,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/cody.png"),
                abilities: new List<Ability>() { Ability.WhackAMole, Ability.TailOnHit, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxDavid",
                "David",
                2,
                4,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/davidtahnee.png"),
                abilities: new List<Ability>() { Ability.StrafePush, Ability.Sharp, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxTahnee",
                "Tahnee",
                1,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/davidtahnee.png"),
                abilities: new List<Ability>() { Ability.TriStrike, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxBerke",
                "Berke",
                2,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/berke.png"),
                abilities: new List<Ability>() { Ability.IceCube, Ability.GuardDog, }
                );

            CardSetupUtility.NewCard("Nevernamed FauxLuke",
                "Luke",
                3,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/luke.png"),
                abilities: new List<Ability>() { Ability.Sniper, }
                );

            

            CardSetupUtility.NewCard("Nevernamed FauxYou",
                "You",
                1,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/FauxDeathcards/you.png"),
                abilities: new List<Ability>() { Ability.Strafe, },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CustomAppearances.GreyBackground }
                );
        }
    }
}