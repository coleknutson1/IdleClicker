using System;
using UnityEngine.UI;

namespace AssemblyCSharp
{
	public class Worker
	{
		public Text copperWorkersText;
		public Text buyAWorkerText;
		public Text totalWorkersText;
		public Button buyAWorkerButton;
		public int copperWorkers;
		public float workerPrice;
		public int workersAvailable;
		public bool canBuyWorker;
		public Worker ()
		{			
			canBuyWorker = false;
			buyAWorkerText.text = "";
			copperWorkersText.text = "buy";
			copperWorkers = 0;
		}

		public void BuyAWorker(ref float currentBalance, ref Text currentBalanceText )
		{
			if (currentBalance >= workerPrice) 
			{
				copperWorkers++;
				currentBalance -= workerPrice;
				workerPrice += 10;
				currentBalanceText.text = currentBalance.ToString ();
			}
		}

		public void Update(float currentBalance)
		{
			canBuyWorker = currentBalance >= workerPrice ? true : false;
		}
	}
}

