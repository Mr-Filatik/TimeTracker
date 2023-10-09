using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Shared.Entity
{
    public class Time
    {
        #region Private Fields

        private byte _hour = default;
        private byte _minute = default;
        private byte _second = default;

        #endregion

        #region Static Fields

        public static byte HoursInDay = 24;
        public static byte MinutesInHour = 60;
        public static byte SecondsInMinute = 60;

        #endregion

        #region Properties

        public byte Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value > (HoursInDay - 1))
                {
                    value -= HoursInDay;
                }
                _hour = value;
            }
        }

        public byte Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value > (MinutesInHour - 1))
                {
                    value -= MinutesInHour;
                    Hour++;
                }
                _minute = value;
            }
        }

        public byte Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (value > (SecondsInMinute - 1))
                {
                    value -= SecondsInMinute;
                    Minute++;
                }
                _second = value;
            }
        }

        #endregion
    }
}
