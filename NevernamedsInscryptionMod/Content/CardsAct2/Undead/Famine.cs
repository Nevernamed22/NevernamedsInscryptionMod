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
    static class Famine
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Famine",
                "Famine",
                0,
                7,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "\"When He broke the third seal, I heard the third living creature saying, \"Come.\" I looked, and behold, a black horse; and he who sat on it had a pair of scales in his hand.\"",
                bonesCost: 13,
                abilities: new List<Ability>() { Ability.Strafe },
                specialAbilities: new List<SpecialTriggeredAbility>() { Starved.ability, InherentGraveyardShift.ability },
                variableStat: Starved.specialStatIcon,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/famine.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/famine_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/famine_pixel.png"),
                defaultFrozenCard: "Starvation"
                );
        }
    }
}