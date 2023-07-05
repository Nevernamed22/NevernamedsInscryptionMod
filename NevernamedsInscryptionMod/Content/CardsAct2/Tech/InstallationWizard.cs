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
    static class InstallationWizard
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed InstallationWizard",
                "Installation Wizard",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                energyCost: 2,
                abilities: new List<Ability>() { Magitech.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/installationwizard_pixel.png")
                );
        }
    }
}