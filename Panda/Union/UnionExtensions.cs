
using System;

namespace Panda
{
    public static class MatchExtensions
    {
        public static void Match<T1, T2>(this IUnion<T1, T2> self, Action<T1> first, Action<T2> second)
        {
            if(self is T1)
            {
                first((T1)self);
            }
            else if(self is T2)
            {
                second((T2)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static TRet Match<T1, T2, TRet>(this IUnion<T1, T2> self, Func<T1, TRet> first, Func<T2, TRet> second)
        {
            if(self is T1)
            {
                return first((T1)self);
            }
            else if(self is T2)
            {
                return second((T2)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static void Match<T1, T2, T3>(this IUnion<T1, T2, T3> self, Action<T1> first, Action<T2> second, Action<T3> third)
        {
            if(self is T1)
            {
                first((T1)self);
            }
            else if(self is T2)
            {
                second((T2)self);
            }
            else if(self is T3)
            {
                third((T3)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static TRet Match<T1, T2, T3, TRet>(this IUnion<T1, T2, T3> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third)
        {
            if(self is T1)
            {
                return first((T1)self);
            }
            else if(self is T2)
            {
                return second((T2)self);
            }
            else if(self is T3)
            {
                return third((T3)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static void Match<T1, T2, T3, T4>(this IUnion<T1, T2, T3, T4> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
        {
            if(self is T1)
            {
                first((T1)self);
            }
            else if(self is T2)
            {
                second((T2)self);
            }
            else if(self is T3)
            {
                third((T3)self);
            }
            else if(self is T4)
            {
                fourth((T4)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static TRet Match<T1, T2, T3, T4, TRet>(this IUnion<T1, T2, T3, T4> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth)
        {
            if(self is T1)
            {
                return first((T1)self);
            }
            else if(self is T2)
            {
                return second((T2)self);
            }
            else if(self is T3)
            {
                return third((T3)self);
            }
            else if(self is T4)
            {
                return fourth((T4)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static void Match<T1, T2, T3, T4, T5>(this IUnion<T1, T2, T3, T4, T5> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
        {
            if(self is T1)
            {
                first((T1)self);
            }
            else if(self is T2)
            {
                second((T2)self);
            }
            else if(self is T3)
            {
                third((T3)self);
            }
            else if(self is T4)
            {
                fourth((T4)self);
            }
            else if(self is T5)
            {
                fifth((T5)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static TRet Match<T1, T2, T3, T4, T5, TRet>(this IUnion<T1, T2, T3, T4, T5> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth, Func<T5, TRet> fifth)
        {
            if(self is T1)
            {
                return first((T1)self);
            }
            else if(self is T2)
            {
                return second((T2)self);
            }
            else if(self is T3)
            {
                return third((T3)self);
            }
            else if(self is T4)
            {
                return fourth((T4)self);
            }
            else if(self is T5)
            {
                return fifth((T5)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static void Match<T1, T2, T3, T4, T5, T6>(this IUnion<T1, T2, T3, T4, T5, T6> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
        {
            if(self is T1)
            {
                first((T1)self);
            }
            else if(self is T2)
            {
                second((T2)self);
            }
            else if(self is T3)
            {
                third((T3)self);
            }
            else if(self is T4)
            {
                fourth((T4)self);
            }
            else if(self is T5)
            {
                fifth((T5)self);
            }
            else if(self is T6)
            {
                sixth((T6)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static TRet Match<T1, T2, T3, T4, T5, T6, TRet>(this IUnion<T1, T2, T3, T4, T5, T6> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth, Func<T5, TRet> fifth, Func<T6, TRet> sixth)
        {
            if(self is T1)
            {
                return first((T1)self);
            }
            else if(self is T2)
            {
                return second((T2)self);
            }
            else if(self is T3)
            {
                return third((T3)self);
            }
            else if(self is T4)
            {
                return fourth((T4)self);
            }
            else if(self is T5)
            {
                return fifth((T5)self);
            }
            else if(self is T6)
            {
                return sixth((T6)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static void Match<T1, T2, T3, T4, T5, T6, T7>(this IUnion<T1, T2, T3, T4, T5, T6, T7> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
        {
            if(self is T1)
            {
                first((T1)self);
            }
            else if(self is T2)
            {
                second((T2)self);
            }
            else if(self is T3)
            {
                third((T3)self);
            }
            else if(self is T4)
            {
                fourth((T4)self);
            }
            else if(self is T5)
            {
                fifth((T5)self);
            }
            else if(self is T6)
            {
                sixth((T6)self);
            }
            else if(self is T7)
            {
                seventh((T7)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static TRet Match<T1, T2, T3, T4, T5, T6, T7, TRet>(this IUnion<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth, Func<T5, TRet> fifth, Func<T6, TRet> sixth, Func<T7, TRet> seventh)
        {
            if(self is T1)
            {
                return first((T1)self);
            }
            else if(self is T2)
            {
                return second((T2)self);
            }
            else if(self is T3)
            {
                return third((T3)self);
            }
            else if(self is T4)
            {
                return fourth((T4)self);
            }
            else if(self is T5)
            {
                return fifth((T5)self);
            }
            else if(self is T6)
            {
                return sixth((T6)self);
            }
            else if(self is T7)
            {
                return seventh((T7)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8>(this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
        {
            if(self is T1)
            {
                first((T1)self);
            }
            else if(self is T2)
            {
                second((T2)self);
            }
            else if(self is T3)
            {
                third((T3)self);
            }
            else if(self is T4)
            {
                fourth((T4)self);
            }
            else if(self is T5)
            {
                fifth((T5)self);
            }
            else if(self is T6)
            {
                sixth((T6)self);
            }
            else if(self is T7)
            {
                seventh((T7)self);
            }
            else if(self is T8)
            {
                eighth((T8)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

        public static TRet Match<T1, T2, T3, T4, T5, T6, T7, T8, TRet>(this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth, Func<T5, TRet> fifth, Func<T6, TRet> sixth, Func<T7, TRet> seventh, Func<T8, TRet> eighth)
        {
            if(self is T1)
            {
                return first((T1)self);
            }
            else if(self is T2)
            {
                return second((T2)self);
            }
            else if(self is T3)
            {
                return third((T3)self);
            }
            else if(self is T4)
            {
                return fourth((T4)self);
            }
            else if(self is T5)
            {
                return fifth((T5)self);
            }
            else if(self is T6)
            {
                return sixth((T6)self);
            }
            else if(self is T7)
            {
                return seventh((T7)self);
            }
            else if(self is T8)
            {
                return eighth((T8)self);
            }
            else
            {
                throw new ArgumentException("Could not find correct match for self", "self");
            }
        }

    }
}
