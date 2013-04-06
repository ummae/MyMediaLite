// Copyright (C) 2011, 2012, 2013 Zeno Gantner
// Copyright (C) 2010 Steffen Rendle, Zeno Gantner
//
// This file is part of MyMediaLite.
//
// MyMediaLite is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// MyMediaLite is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with MyMediaLite.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using MyMediaLite.DataType;

namespace MyMediaLite.Correlation
{
	/// <summary>Class for storing and computing the Jaccard index</summary>
	/// <remarks>
	/// The Jaccard index is also called the Tanimoto coefficient.
	///
	/// http://en.wikipedia.org/wiki/Jaccard_index
	/// </remarks>
	public sealed class Jaccard : IBinaryCorrelation
	{
		public bool IsSymmetric { get { return true; } }

		///
		public float ComputeFromOverlap(float overlap, float count_x, float count_y)
		{
			if (overlap != 0)
				return overlap / (count_x + count_y - overlap);
			else
				return 0.0f;
		}
	}
}
