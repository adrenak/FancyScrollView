﻿using System.Collections.Generic;
using UnityEngine;

namespace FancyScrollView.Example07
{
    public class FancyScrollRect : FancyScrollRect<ItemData, Context>
    {
        [SerializeField] GameObject cellPrefab = default;

        protected override GameObject CellPrefab => cellPrefab;

        public int DataCount => ItemsSource.Count;

        public void UpdateData(IList<ItemData> items)
        {
            UpdateContents(items);
        }

        public void JumpTo(int index, Alignment alignment = Alignment.Center)
        {
            Context.SelectedIndex = index;
            Refresh();

            UpdatePosition(index, alignment);
        }
    }
}
