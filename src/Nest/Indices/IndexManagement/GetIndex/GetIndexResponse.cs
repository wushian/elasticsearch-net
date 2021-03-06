// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

﻿using System.Collections.Generic;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[JsonFormatter(typeof(ResolvableDictionaryResponseFormatter<GetIndexResponse, IndexName, IndexState>))]
	public class GetIndexResponse : DictionaryResponseBase<IndexName, IndexState>
	{
		public IReadOnlyDictionary<IndexName, IndexState> Indices => Self.BackingDictionary;
	}
}
