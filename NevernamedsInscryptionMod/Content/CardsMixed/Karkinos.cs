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
    static class Karkinos
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GreatClawLeft",
                "Great Claw",
                2,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/claw_left.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/claw_left_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/clawleft_pixel.png"),
                abilities: new List<Ability>() { CrookedStrikeRight.ability, Claw.ability },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );

            CardSetupUtility.NewCard("Nevernamed GreatClawRight",
                "Great Claw",
                2,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/claw_right.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/claw_right_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/clawright_pixel.png"),
                abilities: new List<Ability>() { CrookedStrikeLeft.ability, Claw.ability },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/karkinos.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Karkinos",
                "Karkinos",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "Karkinos, the Dread Crab. Loathe as I am to take inspiration from... them, here I will make an exception.",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Clawed.ability, Ability.DeathShield },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/karkinos_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/karkinos_pixel.png"),
                overrideLeftClaw: "BeastNevernamed GreatClawLeft",
                overrideRightClaw: "BeastNevernamed GreatClawRight"
                );
        }
    }
}
