using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentt
{
    public class BananaRipenessRange<T> where T : IComparable<T>
    {
        private readonly T _minRipeness;
        private readonly T _maxRipeness;

        public BananaRipenessRange(T minRipeness, T maxRipeness)
        {
            if (minRipeness.CompareTo(maxRipeness) > 0)
            {
                throw new ArgumentException("Minimum ripeness can't be greater than maximum ripeness.");
            }

            _minRipeness = minRipeness;
            _maxRipeness = maxRipeness;
        }

        public bool IsPerfectBanana(T ripeness)
        {
            return ripeness.CompareTo(_minRipeness) >= 0 && ripeness.CompareTo(_maxRipeness) <= 0;
        }
    }
}
