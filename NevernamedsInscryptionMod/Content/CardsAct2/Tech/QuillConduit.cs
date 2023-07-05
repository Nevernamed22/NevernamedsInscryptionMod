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
    static class QuillConduit
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed QuillConduit",
                "Quill Conduit",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { ThornyConduit.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/quillconduit_pixel.png")
                );
        }
    }
}