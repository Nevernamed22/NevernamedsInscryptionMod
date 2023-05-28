using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using NevernamedsSigils;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Orbot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed PlasmaBlast",
                "Plasma Blast",
                0,
                5,
                new List<CardMetaCategory> {  },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                abilities: new List<Ability>() { Abstain.ability, Doomed.ability, Annihilation.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/plasmablast.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/scoopy_pixel.png")

                );

            CardSetupUtility.NewCard("Nevernamed IncomingStrike",
                "Incoming Strike",
                0,
                5,
                new List<CardMetaCategory> { },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                abilities: new List<Ability>() {Immaterial.ability, Abstain.ability, Ability.Evolve  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/incomingstrike.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/incomingstrike_pixel.png"),
                defaultEvolutionCard: "TechNevernamed PlasmaBlast",
                defaultEvolutionTurns: 2
                );

            CardSetupUtility.NewCard("Nevernamed Orbot",
                "Orbot",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4,
                abilities: new List<Ability>() { Ability.Flying, GraveyardShift.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/orbot.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/orbot_pixel.png"),
                defaultFrozenCard: "TechNevernamed IncomingStrike"
                );
        }
    }
}