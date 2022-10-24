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
    static class PeaCrab
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed PeaClawLeft",
                "Pea Claw",
                1,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/peaclaw_left.png"),
                abilities: new List<Ability>() { CrookedStrikeRight.ability, Claw.ability, Ability.Brittle },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );

            CardSetupUtility.NewCard("Nevernamed PeaClawRight",
                "Pea Claw",
                1,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/peaclaw_right.png"),
                abilities: new List<Ability>() { CrookedStrikeLeft.ability, Claw.ability, Ability.Brittle },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );

            CardSetupUtility.NewCard("Nevernamed PeaCrab",
                "Pea Crab",
                1,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/peacrab.png"),
                abilities: new List<Ability>() {  },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/peacrab_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/peacrab_pixel.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                overrideLeftClaw: "BeastNevernamed PeaClawLeft",
                overrideRightClaw: "BeastNevernamed PeaClawRight"
                );
        }
    }
}