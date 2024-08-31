using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Vrykolakas
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Vrykolakas",
                "Vrykolakas",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "Bloated and swollen, this miserable cadaver hungers for the flesh of those far holier than itself. Keep an eye on your liver, dear.",
                bloodCost: 0,
                bonesCost: 7,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Bonelust.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/vrykolakas.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/vrykolakas_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/vrykolakas_pixel.png")
                );
        }
    }
}