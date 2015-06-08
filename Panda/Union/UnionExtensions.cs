
using System;

namespace Panda.Union
{
    public static class MatchExtensions
    {
        public static void Match<T1, T2>(this IUnion<T1, T2> self, Action<T1> first, Action<T2> second)
            where T1 : class
            where T2 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                first(maybeT1);
                return;
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                second(maybeT2);
                return;
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static TRet Match<T1, T2, TRet>(this IUnion<T1, T2> self, Func<T1, TRet> first, Func<T2, TRet> second)
            where T1 : class
            where T2 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                return first(maybeT1);
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                return second(maybeT2);
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static void Match<T1, T2, T3>(this IUnion<T1, T2, T3> self, Action<T1> first, Action<T2> second, Action<T3> third)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                first(maybeT1);
                return;
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                second(maybeT2);
                return;
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                third(maybeT3);
                return;
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static TRet Match<T1, T2, T3, TRet>(this IUnion<T1, T2, T3> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third)
            where T1 : class
            where T2 : class
            where T3 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                return first(maybeT1);
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                return second(maybeT2);
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                return third(maybeT3);
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static void Match<T1, T2, T3, T4>(this IUnion<T1, T2, T3, T4> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                first(maybeT1);
                return;
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                second(maybeT2);
                return;
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                third(maybeT3);
                return;
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                fourth(maybeT4);
                return;
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static TRet Match<T1, T2, T3, T4, TRet>(this IUnion<T1, T2, T3, T4> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                return first(maybeT1);
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                return second(maybeT2);
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                return third(maybeT3);
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                return fourth(maybeT4);
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static void Match<T1, T2, T3, T4, T5>(this IUnion<T1, T2, T3, T4, T5> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                first(maybeT1);
                return;
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                second(maybeT2);
                return;
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                third(maybeT3);
                return;
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                fourth(maybeT4);
                return;
            }
            T5 maybeT5 = self as T5;
            if(maybeT5 != null)
            {
                fifth(maybeT5);
                return;
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static TRet Match<T1, T2, T3, T4, T5, TRet>(this IUnion<T1, T2, T3, T4, T5> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth, Func<T5, TRet> fifth)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                return first(maybeT1);
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                return second(maybeT2);
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                return third(maybeT3);
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                return fourth(maybeT4);
            }
            T5 maybeT5 = self as T5;
            if(maybeT5 != null)
            {
                return fifth(maybeT5);
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static void Match<T1, T2, T3, T4, T5, T6>(this IUnion<T1, T2, T3, T4, T5, T6> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                first(maybeT1);
                return;
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                second(maybeT2);
                return;
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                third(maybeT3);
                return;
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                fourth(maybeT4);
                return;
            }
            T5 maybeT5 = self as T5;
            if(maybeT5 != null)
            {
                fifth(maybeT5);
                return;
            }
            T6 maybeT6 = self as T6;
            if(maybeT6 != null)
            {
                sixth(maybeT6);
                return;
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static TRet Match<T1, T2, T3, T4, T5, T6, TRet>(this IUnion<T1, T2, T3, T4, T5, T6> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth, Func<T5, TRet> fifth, Func<T6, TRet> sixth)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                return first(maybeT1);
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                return second(maybeT2);
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                return third(maybeT3);
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                return fourth(maybeT4);
            }
            T5 maybeT5 = self as T5;
            if(maybeT5 != null)
            {
                return fifth(maybeT5);
            }
            T6 maybeT6 = self as T6;
            if(maybeT6 != null)
            {
                return sixth(maybeT6);
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static void Match<T1, T2, T3, T4, T5, T6, T7>(this IUnion<T1, T2, T3, T4, T5, T6, T7> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                first(maybeT1);
                return;
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                second(maybeT2);
                return;
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                third(maybeT3);
                return;
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                fourth(maybeT4);
                return;
            }
            T5 maybeT5 = self as T5;
            if(maybeT5 != null)
            {
                fifth(maybeT5);
                return;
            }
            T6 maybeT6 = self as T6;
            if(maybeT6 != null)
            {
                sixth(maybeT6);
                return;
            }
            T7 maybeT7 = self as T7;
            if(maybeT7 != null)
            {
                seventh(maybeT7);
                return;
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static TRet Match<T1, T2, T3, T4, T5, T6, T7, TRet>(this IUnion<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth, Func<T5, TRet> fifth, Func<T6, TRet> sixth, Func<T7, TRet> seventh)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                return first(maybeT1);
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                return second(maybeT2);
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                return third(maybeT3);
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                return fourth(maybeT4);
            }
            T5 maybeT5 = self as T5;
            if(maybeT5 != null)
            {
                return fifth(maybeT5);
            }
            T6 maybeT6 = self as T6;
            if(maybeT6 != null)
            {
                return sixth(maybeT6);
            }
            T7 maybeT7 = self as T7;
            if(maybeT7 != null)
            {
                return seventh(maybeT7);
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8>(this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> self, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                first(maybeT1);
                return;
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                second(maybeT2);
                return;
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                third(maybeT3);
                return;
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                fourth(maybeT4);
                return;
            }
            T5 maybeT5 = self as T5;
            if(maybeT5 != null)
            {
                fifth(maybeT5);
                return;
            }
            T6 maybeT6 = self as T6;
            if(maybeT6 != null)
            {
                sixth(maybeT6);
                return;
            }
            T7 maybeT7 = self as T7;
            if(maybeT7 != null)
            {
                seventh(maybeT7);
                return;
            }
            T8 maybeT8 = self as T8;
            if(maybeT8 != null)
            {
                eighth(maybeT8);
                return;
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

        public static TRet Match<T1, T2, T3, T4, T5, T6, T7, T8, TRet>(this IUnion<T1, T2, T3, T4, T5, T6, T7, T8> self, Func<T1, TRet> first, Func<T2, TRet> second, Func<T3, TRet> third, Func<T4, TRet> fourth, Func<T5, TRet> fifth, Func<T6, TRet> sixth, Func<T7, TRet> seventh, Func<T8, TRet> eighth)
            where T1 : class
            where T2 : class
            where T3 : class
            where T4 : class
            where T5 : class
            where T6 : class
            where T7 : class
            where T8 : class
        {
            T1 maybeT1 = self as T1;
            if(maybeT1 != null)
            {
                return first(maybeT1);
            }
            T2 maybeT2 = self as T2;
            if(maybeT2 != null)
            {
                return second(maybeT2);
            }
            T3 maybeT3 = self as T3;
            if(maybeT3 != null)
            {
                return third(maybeT3);
            }
            T4 maybeT4 = self as T4;
            if(maybeT4 != null)
            {
                return fourth(maybeT4);
            }
            T5 maybeT5 = self as T5;
            if(maybeT5 != null)
            {
                return fifth(maybeT5);
            }
            T6 maybeT6 = self as T6;
            if(maybeT6 != null)
            {
                return sixth(maybeT6);
            }
            T7 maybeT7 = self as T7;
            if(maybeT7 != null)
            {
                return seventh(maybeT7);
            }
            T8 maybeT8 = self as T8;
            if(maybeT8 != null)
            {
                return eighth(maybeT8);
            }
            throw new ArgumentException("Could not find correct match for self", "self");
        }

    }
}
