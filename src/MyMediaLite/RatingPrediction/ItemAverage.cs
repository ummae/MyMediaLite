// Copyright (C) 2011, 2012, 2013 Zeno Gantner
// Copyright (C) 2010 Zeno Gantner, Steffen Rendle
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
using System.Collections.Generic;
using MyMediaLite.Data;
using MyMediaLite.Taxonomy;

namespace MyMediaLite.RatingPrediction
{
	/// <summary>Uses the average rating value of an item for prediction</summary>
	/// <remarks>
	/// This recommender supports incremental updates.
	/// </remarks>
	public class ItemAverage : EntityAverage
	{
		///
		public override void Train()
		{
			Train(EntityType.ITEM);
		}

		///
		public override bool CanPredict(int user_id, int item_id)
		{
			return (item_id <= MaxItemID);
		}

		///
		public override float Predict(int user_id, int item_id)
		{
			if (item_id <= MaxItemID)
				return entity_averages[item_id];
			else
				return global_average;
		}
	}
}