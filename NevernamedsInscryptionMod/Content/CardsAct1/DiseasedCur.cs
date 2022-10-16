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
    static class DiseasedCur
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed DiseasedCur",
                "Diseased Cur",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The miserable diseased cur. It's affliction spreads when it is slain.",
                bloodCost: 1,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/diseasedcur.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/diseasedcur_pixel.png"),
                abilities: new List<Ability>() { Ability.LatchBrittle },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/diseasedcur_emission.png")
                );
        }
    }
}