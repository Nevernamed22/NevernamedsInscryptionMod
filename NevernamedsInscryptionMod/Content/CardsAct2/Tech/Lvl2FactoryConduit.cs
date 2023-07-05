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
    static class Lvl2FactoryConduit
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Lvl2FactoryConduit",
                "Lvl. 2 Factory Conduit",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                energyCost: 6,
                abilities: new List<Ability>() { Ability.ConduitFactory },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/lvl2factoryconduit.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/lvl2factoryconduit_pixel.png")
                ).SetFactoryConduitSpawns("Automaton");
        }
    }
}