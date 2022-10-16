﻿using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class PrototypeGiftbot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed PrototypeGiftbot",
                 "Prototype Giftbot",
                 0,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Tech,
                 description: "",
                 bloodCost: 0,
                 bonesCost: 0,
                 energyCost: 3, 
                 tribes: new List<Tribe>() { },
                 abilities: new List<Ability>() { Ability.ExplodeOnDeath, GiftBearerCustom.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/prototypegiftbot_pixel.png")
                 );
        }
    }
}