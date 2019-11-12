using System;
using System.Collections.Generic;
using System.Text;
using trycalc.Models;

namespace trycalc.ViewModels
{
    public class StrategieDetailViewModel : BaseViewModel
    {
        public CardDataModel StrategieItem { get; set; }

        public StrategieDetailViewModel(CardDataModel item)
        {
            StrategieItem = item;
            //StrategieItem.StrategieAvatar = item.StrategieAvatar;
            //StrategieItem.StrategieName = item.StrategieName;
        }
    }
}
