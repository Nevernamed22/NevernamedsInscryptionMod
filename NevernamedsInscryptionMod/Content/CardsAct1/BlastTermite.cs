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
    static class BlastTermite
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BlastTermite",
                "Blast Termite",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The disgusting blasting termite. It explodes it's foes upon death.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blasttermite.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/blasttermite_pixel.png"),
                abilities: new List<Ability>() { Ability.LatchExplodeOnDeath },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blasttermite_emission.png")
                );
        }
    }
}