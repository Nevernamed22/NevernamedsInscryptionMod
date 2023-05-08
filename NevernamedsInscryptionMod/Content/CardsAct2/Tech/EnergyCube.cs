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
    static class EnergyCube
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed EnergyCube",
                "Energy Cube",
                0,
                6,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { EnergyDependent.ability, Ability.Reach },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/energycube_pixel.png"),
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/energycube.png")
                );
        }
    }
}