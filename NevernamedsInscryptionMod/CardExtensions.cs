using DiskCardGame;
using System;
using System.Collections.Generic;
using System.Text;
using InscryptionAPI.Helpers;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    public static class CardExtensions
    {
        public static void WipeAllAbilities(this PlayableCard card)
        {
            CardModificationInfo cardModificationInfo = new CardModificationInfo();
            cardModificationInfo.negateAbilities = new List<Ability>();
            foreach (CardModificationInfo cardModificationInfo2 in card.TemporaryMods)
            {
                cardModificationInfo.negateAbilities.AddRange(cardModificationInfo2.abilities);
            }
            cardModificationInfo.negateAbilities.AddRange(card.Info.Abilities);
            card.AddTemporaryMod(cardModificationInfo);
        }

        public static void ArachnophobiaMode(this CardInfo card, string name)
        {
            card.portraitTex = Tools.ConvertTexToSprite(Tools.LoadTex($"NevernamedsInscryptionMod/Resources/ArachnophobiaMode/{name}phobia.png"));
            card.portraitTex.RegisterEmissionForSprite(Tools.ConvertTexToSprite(Tools.LoadTex($"NevernamedsInscryptionMod/Resources/ArachnophobiaMode/{name}phobia_emission.png")));
            Debug.Log($"    Modified: {name}");
        }
        public static void ArachnophobiaModePixel(this CardInfo card, string name)
        {
            card.pixelPortrait = Tools.ConvertTexToSprite(Tools.LoadTex($"NevernamedsInscryptionMod/Resources/ArachnophobiaMode/{name}phobia_pixel.png"));          
            Debug.Log($"    Modified: {name} (Pixel)");
        }
    }
}
