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
    static class Crab
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Crab",
                "Crab",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Time for crab.",
                bloodCost: 0,
                bonesCost: 5,
                //energyCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crab.png"),
                abilities: new List<Ability>() { Ability.DeathShield, Ability.Strafe },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/crab_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crab_emission.png")
                );
        }
    }
}
