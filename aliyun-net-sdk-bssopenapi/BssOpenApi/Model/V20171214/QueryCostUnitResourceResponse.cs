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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QueryCostUnitResourceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private QueryCostUnitResource_Data data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public QueryCostUnitResource_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryCostUnitResource_Data
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private List<QueryCostUnitResource_ResourceInstanceList> resourceInstanceDtoList;

			private QueryCostUnitResource_CostUnit costUnit;

			private QueryCostUnitResource_CostUnitStatisInfo costUnitStatisInfo;

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<QueryCostUnitResource_ResourceInstanceList> ResourceInstanceDtoList
			{
				get
				{
					return resourceInstanceDtoList;
				}
				set	
				{
					resourceInstanceDtoList = value;
				}
			}

			public QueryCostUnitResource_CostUnit CostUnit
			{
				get
				{
					return costUnit;
				}
				set	
				{
					costUnit = value;
				}
			}

			public QueryCostUnitResource_CostUnitStatisInfo CostUnitStatisInfo
			{
				get
				{
					return costUnitStatisInfo;
				}
				set	
				{
					costUnitStatisInfo = value;
				}
			}

			public class QueryCostUnitResource_ResourceInstanceList
			{

				private long? resourceUserId;

				private long? resourceId;

				private string commodityCode;

				private string resourceUserName;

				private string commodityName;

				private string resourceGroup;

				private string resourceTag;

				private string resourceNick;

				private string resourceType;

				private string resourceStatus;

				private string relatedResources;

				private string apportionCode;

				private string apportionName;

				public long? ResourceUserId
				{
					get
					{
						return resourceUserId;
					}
					set	
					{
						resourceUserId = value;
					}
				}

				public long? ResourceId
				{
					get
					{
						return resourceId;
					}
					set	
					{
						resourceId = value;
					}
				}

				public string CommodityCode
				{
					get
					{
						return commodityCode;
					}
					set	
					{
						commodityCode = value;
					}
				}

				public string ResourceUserName
				{
					get
					{
						return resourceUserName;
					}
					set	
					{
						resourceUserName = value;
					}
				}

				public string CommodityName
				{
					get
					{
						return commodityName;
					}
					set	
					{
						commodityName = value;
					}
				}

				public string ResourceGroup
				{
					get
					{
						return resourceGroup;
					}
					set	
					{
						resourceGroup = value;
					}
				}

				public string ResourceTag
				{
					get
					{
						return resourceTag;
					}
					set	
					{
						resourceTag = value;
					}
				}

				public string ResourceNick
				{
					get
					{
						return resourceNick;
					}
					set	
					{
						resourceNick = value;
					}
				}

				public string ResourceType
				{
					get
					{
						return resourceType;
					}
					set	
					{
						resourceType = value;
					}
				}

				public string ResourceStatus
				{
					get
					{
						return resourceStatus;
					}
					set	
					{
						resourceStatus = value;
					}
				}

				public string RelatedResources
				{
					get
					{
						return relatedResources;
					}
					set	
					{
						relatedResources = value;
					}
				}

				public string ApportionCode
				{
					get
					{
						return apportionCode;
					}
					set	
					{
						apportionCode = value;
					}
				}

				public string ApportionName
				{
					get
					{
						return apportionName;
					}
					set	
					{
						apportionName = value;
					}
				}
			}

			public class QueryCostUnitResource_CostUnit
			{

				private long? ownerUid;

				private long? parentUnitId;

				private long? unitId;

				private string unitName;

				public long? OwnerUid
				{
					get
					{
						return ownerUid;
					}
					set	
					{
						ownerUid = value;
					}
				}

				public long? ParentUnitId
				{
					get
					{
						return parentUnitId;
					}
					set	
					{
						parentUnitId = value;
					}
				}

				public long? UnitId
				{
					get
					{
						return unitId;
					}
					set	
					{
						unitId = value;
					}
				}

				public string UnitName
				{
					get
					{
						return unitName;
					}
					set	
					{
						unitName = value;
					}
				}
			}

			public class QueryCostUnitResource_CostUnitStatisInfo
			{

				private long? resourceCount;

				private long? resourceGroupCount;

				private long? subUnitCount;

				private long? userCount;

				private long? totalResourceCount;

				private long? totalUserCount;

				private long? totalResourceGroupCount;

				public long? ResourceCount
				{
					get
					{
						return resourceCount;
					}
					set	
					{
						resourceCount = value;
					}
				}

				public long? ResourceGroupCount
				{
					get
					{
						return resourceGroupCount;
					}
					set	
					{
						resourceGroupCount = value;
					}
				}

				public long? SubUnitCount
				{
					get
					{
						return subUnitCount;
					}
					set	
					{
						subUnitCount = value;
					}
				}

				public long? UserCount
				{
					get
					{
						return userCount;
					}
					set	
					{
						userCount = value;
					}
				}

				public long? TotalResourceCount
				{
					get
					{
						return totalResourceCount;
					}
					set	
					{
						totalResourceCount = value;
					}
				}

				public long? TotalUserCount
				{
					get
					{
						return totalUserCount;
					}
					set	
					{
						totalUserCount = value;
					}
				}

				public long? TotalResourceGroupCount
				{
					get
					{
						return totalResourceGroupCount;
					}
					set	
					{
						totalResourceGroupCount = value;
					}
				}
			}
		}
	}
}
