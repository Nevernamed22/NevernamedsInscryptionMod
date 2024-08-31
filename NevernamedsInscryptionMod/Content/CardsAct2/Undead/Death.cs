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
    static class Death
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Death",
                "Death",
                2,
                6,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "\"When the Lamb broke the fourth seal, I heard the voice of the fourth living creature saying, \"Come.\" I looked, and behold, an ashen horse; and he who sat on it had the name Death; and Hades was following with him.\"",
                bonesCost: 13,
                abilities: new List<Ability>() { Ability.Deathtouch, RunningStrike.ability },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/death.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/death_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/death_pixel.png")
                );
        }
    }
}