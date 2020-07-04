﻿using ElectronicObserver.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Observer.kcsapi.api_req_sortie
{

	public class battleresult : APIBase
	{

		public override void OnResponseReceived(dynamic data)
		{

			KCDatabase.Instance.Battle.LoadFromResponse(APIName, data);
			KCDatabase.Instance.Replays.LoadFromResponse(APIName, data);
			KCDatabase.Instance.TsunDbSubmission.LoadFromResponse(APIName, data);

			base.OnResponseReceived((object)data);
		}


		public override string APIName => "api_req_sortie/battleresult";
	}

}
