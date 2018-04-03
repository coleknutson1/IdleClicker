using System;
using UnityEngine.UI;

namespace AssemblyCSharp
{
	public class Ore
	{
		public Slider progressSlider;
		public Text copperPriceText;
		public Text copperAvailableText;
		public Text totalCopperPossessedText;
		public Button buyCopperButton;
		public Text currentCopperText;
		public float copperPrice;
		public float copperAvailable;
		public int totalCopperPossessed;
		public float joulesRequiredToMine;
		public float copperCoefficient;

		public Ore ()
		{			
			copperAvailable = 0;
			progressSlider.maxValue = joulesRequiredToMine;
		}

		public void SellCopper(ref float currentBalance)
		{
			if (totalCopperPossessed > 0) {			
				currentBalance += copperPrice;
				totalCopperPossessed--;
			}
		}

		public void MineOre()
		{
			if (copperAvailable > 0) {
				totalCopperPossessed++;
				copperAvailable--;
			}
		}

		public void HandleSlider()
		{
			progressSlider.maxValue = joulesRequiredToMine;
			if (progressSlider.value >= joulesRequiredToMine) {
				OreStruck ();
			}	
		}

		public void OreStruck()
		{
			copperAvailable++;
		}
	}
}

