/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dyvmsapi;
using Aliyun.Acs.Dyvmsapi.Transform;
using Aliyun.Acs.Dyvmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
    public class SingleCallByTtsRequest : RpcAcsRequest<SingleCallByTtsResponse>
    {
        public SingleCallByTtsRequest()
            : base("Dyvmsapi", "2017-05-25", "SingleCallByTts")
        {
        }

		private long? resourceOwnerId;

		private string ttsParam;

		private int? speed;

		private string calledNumber;

		private string calledShowNumber;

		private string resourceOwnerAccount;

		private string ttsCode;

		private int? playTimes;

		private long? ownerId;

		private int? volume;

		private string outId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string TtsParam
		{
			get
			{
				return ttsParam;
			}
			set	
			{
				ttsParam = value;
				DictionaryUtil.Add(QueryParameters, "TtsParam", value);
			}
		}

		public int? Speed
		{
			get
			{
				return speed;
			}
			set	
			{
				speed = value;
				DictionaryUtil.Add(QueryParameters, "Speed", value.ToString());
			}
		}

		public string CalledNumber
		{
			get
			{
				return calledNumber;
			}
			set	
			{
				calledNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledNumber", value);
			}
		}

		public string CalledShowNumber
		{
			get
			{
				return calledShowNumber;
			}
			set	
			{
				calledShowNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledShowNumber", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string TtsCode
		{
			get
			{
				return ttsCode;
			}
			set	
			{
				ttsCode = value;
				DictionaryUtil.Add(QueryParameters, "TtsCode", value);
			}
		}

		public int? PlayTimes
		{
			get
			{
				return playTimes;
			}
			set	
			{
				playTimes = value;
				DictionaryUtil.Add(QueryParameters, "PlayTimes", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? Volume
		{
			get
			{
				return volume;
			}
			set	
			{
				volume = value;
				DictionaryUtil.Add(QueryParameters, "Volume", value.ToString());
			}
		}

		public string OutId
		{
			get
			{
				return outId;
			}
			set	
			{
				outId = value;
				DictionaryUtil.Add(QueryParameters, "OutId", value);
			}
		}

        public override SingleCallByTtsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SingleCallByTtsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
