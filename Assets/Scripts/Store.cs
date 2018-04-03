using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using AssemblyCSharp;

public class Store : MonoBehaviour {
	public Worker Worker;
	public Ore Ore;
	public Text currentBalanceText;
	private float clickValue;
	private float currentBalance;


	// Use this for initialization
	void Start () {		
		clickValue = 1;
		currentBalance = 0;
		currentBalanceText.text = "$" + currentBalance.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
//		MathHandler ();
		UpdateText ();
		Ore.HandleSlider ();
	}

	public void Click()
	{
		IterateBalance(clickValue);
	}
		
		

	public void UpdateText()
	{
		Ore.copperAvailableText.text = Ore.copperAvailable > 0 ? Ore.copperAvailable.ToString () : "";
		Worker.buyAWorkerText.text = "Buy a Worker (" + Math.Floor(currentBalance / Worker.workerPrice).ToString () + ")";
		Worker.totalWorkersText.text = "Workers: " + Worker.copperWorkers.ToString ();
		Ore.copperPriceText.text = "Price: $" + Ore.copperPrice.ToString ();
		Ore.totalCopperPossessedText.text = "Copper: " + Ore.totalCopperPossessed.ToString ();
		currentBalanceText.text = "$" + currentBalance.ToString ();
		Ore.currentCopperText.text = "Sell for " + Ore.copperPriceText;
	}

	private void IterateBalance(float iterateBy)
	{
		currentBalance = currentBalance + iterateBy;
		currentBalanceText.text = "$" + currentBalance.ToString ();
	}


	public void UpgradePickaxe()
	{
		//When you get enough ore, you can upgrade this and get more $$$$ per click?
	}
}
