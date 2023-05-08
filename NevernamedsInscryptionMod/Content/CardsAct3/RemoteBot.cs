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
    static class RemoteBot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed RemoteBot",
                "RemoteBot",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { RemoteControlled.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/remotebot.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/remotebot_pixel.png")
                );
        }
    }
}