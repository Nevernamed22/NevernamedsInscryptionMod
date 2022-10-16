using DiskCardGame;
using System;
using System.Collections.Generic;
using System.Text;

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
	}
}
