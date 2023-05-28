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
    static class Bloodbag
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BloodbagFull",
                "Bloodbag",
                0,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Undead,
                description: "",
                bonesCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.TripleBlood },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bloodbagfull_pixel.png")
                );

            CardSetupUtility.NewCard("Nevernamed Bloodbag",
                "Bloodbag",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Evolve },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bloodbag_pixel.png"),
               defaultEvolutionCard: "DeadNevernamed BloodbagFull"
                );
        }
    }
}