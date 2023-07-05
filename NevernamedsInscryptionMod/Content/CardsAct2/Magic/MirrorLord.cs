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
    static class MirrorLord
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MirrorLord",
                "Mirror Lord",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Blue },
                tribes: new List<Tribe>() { },
                variableStat: SpecialStatIcon.Mirror,
                specialAbilities: new List<SpecialTriggeredAbility>() { SpecialTriggeredAbility.Mirror },
                abilities: new List<Ability>() { SigilMimic.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mirrorlord_pixel.png")
                );
        }
    }
}